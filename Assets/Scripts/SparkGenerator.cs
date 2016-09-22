using UnityEngine;
using System.Collections;

public class SparkGenerator : MonoBehaviour {

	public GameObject sparkPrefab;

	void OnCollisionEnter2D(Collision2D other) 
	{

		foreach (ContactPoint2D p in other.contacts) 
		{
			Instantiate (sparkPrefab, p.point, Quaternion.identity);
		}
			
	}

}
