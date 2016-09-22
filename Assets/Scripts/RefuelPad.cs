using UnityEngine;
using System.Collections;

public class RefuelPad : MonoBehaviour {

	public LanderController refuel;
	private bool refuelLander = false;

	void OnTriggerEnter2D(Collider2D other) 
	{
		
	if (other.gameObject.GetComponent<LanderController>() != null)
		{
			//print("Starting " + Time.time);
			StartCoroutine(WaitAndPrint(3.0F));
			refuelLander = true;
			//print("Before WaitAndPrint Finishes " + Time.time);

			//print ("Fuelpad detects " + other.collider + ": Refuel starts in a moment");
			//refuel.fuelLevel = 100;
			//refuel.GetComponent<LanderController>().fuelLevel = 100f;
		}
	}
	IEnumerator WaitAndPrint(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);

		if (refuelLander == true)
		{
			refuel.GetComponent<LanderController> ().fuelLevel = 100;
			refuel.GetComponent<LanderController> ().monoPropellant = 100;
			//refuelLander = false;

		}
		if (refuelLander == false) 
		{
			print ("REFUEL CANCELED");
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		refuelLander = false;
	}
}
