using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public Transform target;
	//public Transform target2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {

		//transform.position = target.transform.position;
		this.transform.position = new Vector3 (target.transform.position.x, target.transform.position.y, transform.position.z);
	
	}
}
