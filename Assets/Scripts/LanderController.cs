using UnityEngine;
using System.Collections;

public class LanderController : MonoBehaviour {


	public float landerRotate = 3.5f;
	public float landerForce = 5.0f;
	public float monoForce = 1.5f;
	Rigidbody2D landerRocket;

	public float credit = 0;
	public float hull = 100;
	public float maxHull = 100;
	public float maxFuel = 100;
	public float fuelLevel = 100;
	private float fuelEffiency = 1.0f;
	public float maxMono = 100;
	public float monoPropellant = 100;
	private float monoEffiency = 1.5f;
	public GameObject flames;

	// Use this for initialization
	void Start () {
		landerRocket = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Regualer controlls, thrust and angular movement
		if (Input.GetButton ("Jump") && fuelLevel > 0) {

			landerRocket.AddRelativeForce (Vector2.up * landerForce );
		
			fuelLevel -= fuelEffiency * Time.deltaTime;

			flames.SetActive (true);
		} else {
			flames.SetActive (false);
		}

		if (Input.GetButton("Horizontal") && monoPropellant > 0) {
			
			landerRocket.AddTorque (Input.GetAxis ("Horizontal") / landerRotate);

			monoPropellant -= monoEffiency * Time.deltaTime;

		}

		//Rcs thruster controlls
		if(Input.GetKey(KeyCode.A) && monoPropellant > 0) 
		{
			landerRocket.AddRelativeForce (Vector2.left * monoForce );
			monoPropellant -= monoEffiency * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D)) 
		{
			landerRocket.AddRelativeForce (Vector2.right * monoForce );
			monoPropellant -= monoEffiency * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.W)) 
		{
			landerRocket.AddRelativeForce (Vector2.up * monoForce );
			monoPropellant -= monoEffiency * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S)) 
		{
			landerRocket.AddRelativeForce (Vector2.down * monoForce );
			monoPropellant -= monoEffiency * Time.deltaTime;
		}


	}
}
