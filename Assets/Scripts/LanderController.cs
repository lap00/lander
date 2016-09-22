using UnityEngine;
using System.Collections;

public class LanderController : MonoBehaviour {


	public float landerRotate = 1.0f;
	public float landerForce = 10.0f;
	Rigidbody2D landerRocket;

	public float credit = 0;
	public float hull = 100;
	public float maxHull = 100;
	public float maxFuel = 100;
	public float fuelLevel = 100;
	public float fuelEffiency = 3.0f;
	public float maxMono = 100;
	public float monoPropellant = 100;
	public float monoEffiency = 0.2f;
	public GameObject flames;

	// Use this for initialization
	void Start () {
		landerRocket = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetButton ("Jump") && fuelLevel > 0) {
			landerRocket.AddRelativeForce (Vector2.up * landerForce);

			fuelLevel -= fuelEffiency * Time.deltaTime;

			flames.SetActive (true);
		} else {
			flames.SetActive (false);
		}

		if (Input.GetButton("Horizontal") && monoPropellant > 0) {
			
			landerRocket.AddTorque (Input.GetAxis ("Horizontal") / landerRotate);

			monoPropellant -= monoEffiency * Time.deltaTime;

			//print (landerRocket.angularVelocity);
		}

		//if (landerRocket.angularVelocity > 0.1 || landerRocket.angularVelocity < -0.1)
		//{
		//	monoPropellant -= 0.1f * Time.deltaTime;
		//}



	}
}
