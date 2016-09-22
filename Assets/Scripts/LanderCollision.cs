using UnityEngine;
using System.Collections;

public class LanderCollision : MonoBehaviour {

	public LanderController landerController;
	
	void OnCollisionEnter2D(Collision2D collision) 
	{

		if (collision.relativeVelocity.magnitude > 3)
		{
			
			print (collision.relativeVelocity.magnitude.ToString("0"));
			landerController.hull -= collision.relativeVelocity.magnitude * 3;
		}

	}

}
