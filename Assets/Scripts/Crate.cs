using UnityEngine;
using System.Collections;

public class Crate : MonoBehaviour {

	public int value;
	public MeshRenderer volume;

	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();

		volume.sortingLayerName = sr.sortingLayerName;
		volume.sortingOrder = sr.sortingOrder + 1;

		volume.GetComponent<TextMesh>().text = value.ToString();

		GetComponent<Rigidbody2D> ().mass = value * Random.Range (0.1f, 0.15f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
