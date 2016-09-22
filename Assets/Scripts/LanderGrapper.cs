using UnityEngine;
using System.Collections;

public class LanderGrapper : MonoBehaviour {

	private Crate currentPayload;
	private Crate currentPayloadCargo;
	private float crateMass;
	public bool hasCargo;
	public SpriteRenderer pickupInstrictions;

	void OnTriggerEnter2D(Collider2D other) 
	{
		Crate payload = other.GetComponent<Crate> ();

		if (payload == null) 
		{
			return;
		}
		currentPayload = payload;

		//Check for colliding with a crate and we have no cargo
		if (hasCargo == false && currentPayload == payload)
		{
			//show pickup instructions
			print ("Show");
			pickupInstrictions.gameObject.SetActive (true);
		}

	}

	void OnTriggerExit2D(Collider2D other)
	{
		Crate payload = other.GetComponent<Crate> ();

		if (payload == currentPayload)
		{
			currentPayload = null;
		}

		//hide pickup instructions
		pickupInstrictions.gameObject.SetActive (false);

	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.E) && currentPayload != null && currentPayloadCargo == null)
		{
			currentPayload.transform.SetParent (transform, true);

			Rigidbody2D cb = currentPayload.GetComponent<Rigidbody2D> ();
			//Rigidbody2D lb = GetComponentInParent<Rigidbody2D>();

			crateMass = cb.mass;

			GetComponentInParent<Rigidbody2D> ().mass += crateMass;

			Destroy(cb);

			currentPayloadCargo = currentPayload;

			currentPayload = null;
			hasCargo = true;
			pickupInstrictions.gameObject.SetActive (false);

			return;
		}
		if(Input.GetKeyDown(KeyCode.E) && currentPayloadCargo != null)
		{
			Vector2 cratePosition = currentPayloadCargo.transform.position;

			currentPayloadCargo.transform.SetParent (null, true);

			currentPayloadCargo.transform.position = cratePosition;

			Rigidbody2D cb = currentPayloadCargo.gameObject.AddComponent<Rigidbody2D> ();

			cb.mass = crateMass;

			Rigidbody2D landerBody = GetComponentInParent<Rigidbody2D> ();

			landerBody.mass -= crateMass;

			//landerBody.GetRelativePointVelocity (transform.localPosition);

			Vector2 crateVelocity = landerBody.GetRelativePointVelocity (transform.localPosition);

			cb.velocity = crateVelocity;

			currentPayloadCargo = null;
			hasCargo = false;

			return;
		}
	}
		
}
