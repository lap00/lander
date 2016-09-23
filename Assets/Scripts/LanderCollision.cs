using UnityEngine;
using System.Collections;

public class LanderCollision : MonoBehaviour {

	public LanderController landerController;
	
	void OnCollisionEnter2D(Collision2D collision) 
	{

		if (collision.relativeVelocity.magnitude > 0.6)
		{
			
			print (collision.relativeVelocity.magnitude);
			landerController.hull -= collision.relativeVelocity.magnitude + (collision.relativeVelocity.magnitude * 10);
		}

	}

}
