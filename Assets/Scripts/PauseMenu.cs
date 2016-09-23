using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public string quit;

	public bool isPaused;

	public GameObject pausedMenuCanvas;
	
	// Update is called once per frame
	void Update () {

		if (isPaused) {
			pausedMenuCanvas.SetActive (true);
			Time.timeScale = 0f;

		} else {
			pausedMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			isPaused = !isPaused;
		}
	}

	public void Menu ()
	{
		isPaused = !isPaused;

	}
	public void Resume ()
	{
		isPaused = false;
	}

	public void Restart ()
	{
		//Application.LoadLevel ("LanderGame");
	}

	public void Quit ()
	{
		Application.Quit();
	}
}
