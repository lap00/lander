using UnityEngine;
using System.Collections;

public class Lifespan : MonoBehaviour {

	public float lifespan = 1;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifespan);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
