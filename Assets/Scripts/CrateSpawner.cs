using UnityEngine;
using System.Collections;

public class CrateSpawner : MonoBehaviour {

	public float spawnDelay;
	private float countdown;

	public GameObject crate;

	// Use this for initialization
	void Start () {
		countdown = spawnDelay;
	}
	
	// Update is called once per frame
	void Update () {
	
		countdown -= Time.deltaTime;

		if (countdown <= 0f)
		{
			
			GameObject c = (GameObject)Instantiate (crate, transform.position, transform.rotation);

			c.GetComponent<Crate> ().value = Random.Range (1, 10);

			spawnDelay = Random.Range (5, 15);
			countdown = spawnDelay;
		}
			
	}
}
