using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public SpriteRenderer sprite;

	void OnEnable ()	{
		// store a reference to the SpriteRenderer on the current GameObject
		SpriteRenderer spRend = GetComponent<SpriteRenderer>();
		// copy the SpriteRenderer's color property
		Color col = spRend.color;
		//  change col's alpha value (0 = invisible, 1 = fully opaque)
		col.a = 0.0f; // 0.5f = half transparent
		// change the SpriteRenderer's color property to match the copy with the altered alpha value
		spRend.color = col;

		StartCoroutine (WaitAndPrint (1.5F));

	}

	IEnumerator WaitAndPrint(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);

		// store a reference to the SpriteRenderer on the current GameObject
		SpriteRenderer spRend = GetComponent<SpriteRenderer>();
		// copy the SpriteRenderer's color property
		Color col = spRend.color;
		//  change col's alpha value (0 = invisible, 1 = fully opaque)
		col.a = 1f; // 0.5f = half transparent
		// change the SpriteRenderer's color property to match the copy with the altered alpha value
		spRend.color = col;

	}
}
