using UnityEngine;
using System.Collections;

public class RepairPad : MonoBehaviour {

	public LanderController repair;
	private bool repairLander = false;
	private bool startRepair = false;

	void OnTriggerEnter2D(Collider2D other) 
	{

		if (other.gameObject.GetComponent<LanderController>() != null)
		{
			
			StartCoroutine(WaitAndPrint(3.0F));
			repairLander = true;
	
		}
	}
	IEnumerator WaitAndPrint(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);

		if (repairLander == true)
		{
			
			startRepair = true;

		}
		if (repairLander == false) 
		{
			print ("REPAIR CANCELED");
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		repairLander = false;
		startRepair = false;
	}

	void Update ()
	{
		if(startRepair == true && repair.hull < repair.maxHull)
		{
			repair.hull += 15 * Time.deltaTime;

		}
	}
}