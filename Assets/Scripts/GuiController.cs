using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiController : MonoBehaviour {

	public LanderController landerController;

	[SerializeField]

	public Text fuelRemaining = null;
	public Text monoRemaining = null;
	public Text hullRemaining = null;
	public Text creditValue = null;

	// Use this for initialization
	void Start () {


		//fuelRemaining.text = "test";

	}
	
	// Update is called once per frame
	void Update () {

		creditValue.text =  "$ " + landerController.credit.ToString ("0");

		hullRemaining.text = landerController.hull.ToString ("0") + "%";
		fuelRemaining.text = landerController.fuelLevel.ToString ("0") + "%";
		monoRemaining.text = landerController.monoPropellant.ToString ("0") + "%";




	}
}
