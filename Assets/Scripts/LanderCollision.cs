using UnityEngine;
using System.Collections;

public class LanderCollision : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D other) 
	{

		if (other.transform.IsChildOf(GameObject.Find("level").transform))
		{
			//print ("You are touching " + other.collider);
		}
		//if (other.gameObject.GetComponent<LandingPad>() != null)
		//{
		//	print ("landed!");
		//}
	}

}
