using UnityEngine;
using System.Collections;

public class LandingPad : MonoBehaviour {

	public int requestedValue;
	public MeshRenderer reqVolume;
	public bool requireCrate;
	private int payloadVolume;

	//Cargo delivery
	public LanderGrapper grabber;
	public LanderController payment;
	private bool deliverCrate = false;

	// Use this for initialization
	void Start () {
		
		//Sort textlabel before the landing pad sprite
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		reqVolume.sortingLayerName = sr.sortingLayerName;
		reqVolume.sortingOrder = sr.sortingOrder + 1;

		//Randomize a value the landingpad would like to request 
		requestedValue = Random.Range(10,20);

		reqVolume.GetComponent<TextMesh> ().text = requestedValue.ToString();

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		

		if (other.gameObject.GetComponent<Crate> () != null && grabber.hasCargo == true) 
		{
			print("JETTISON TO DELIVER");

		}
		if (other.gameObject.GetComponent<Crate> () != null && grabber.hasCargo == false) 
		{
			print("DELIVERING");
			payloadVolume = other.GetComponent<Crate>().value;
			deliverCrate = true;
			StartCoroutine(WaitAndPrint(3.0F, other.gameObject));
		}
	}
	IEnumerator WaitAndPrint(float waitTime, GameObject crateObject) 
	{
		yield return new WaitForSeconds(waitTime);

		if (deliverCrate == true && grabber.hasCargo == false)
		{
			requireCrate = true;
			print("CRATE DELIVERED");
			Destroy (crateObject);

		}
		if (deliverCrate == false) 
		{
			print("NO DELIVERY");
		}
	}
	void OnCollisionExit2D(Collision2D other)
	{
		deliverCrate = false;
	}
		
	void Update () {

		if(requireCrate == true) 
		{

			requestedValue -= payloadVolume;
			reqVolume.GetComponent<TextMesh> ().text = requestedValue.ToString();
			print ("pay " + payloadVolume * 50 + " to pilot");

			payment.credit = payment.credit + payloadVolume * 50;

			requireCrate = false;
			deliverCrate = false;

		}

	}
}