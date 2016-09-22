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
	public Image fuelBar;
	public Image monoBar;
	public Image hullBar;

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

		fuelBar.fillAmount = landerController.fuelLevel / 100;
		monoBar.fillAmount = landerController.monoPropellant / 100;
		hullBar.fillAmount = landerController.hull / 100;


		//Fuel guage color control
		if (landerController.fuelLevel < 50 && landerController.fuelLevel > 20) {
			fuelBar.color = new Color (1f, 0.5f, 0.3f, 1f);
			fuelRemaining.color = new Color (1f, 0.5f, 0.3f, 1f);
		
		} else {
			if (landerController.fuelLevel < 20) {
				fuelBar.color = new Color (1f, 0f, 0f, 1f);
				fuelRemaining.color = new Color (1f, 0f, 0f, 1f);
			} else {
				fuelBar.color = new Color (1f, 1f, 1f, 1f);
				fuelRemaining.color = new Color (1f, 0.9f, 0.63f, 1f);
			}
		}
//
//		//Monopropellant guage color control
		if (landerController.monoPropellant < 50 && landerController.monoPropellant > 20) {
			monoBar.color = new Color (1f, 0.5f, 0.3f, 1f);
			monoRemaining.color = new Color (1f, 0.5f, 0.3f, 1f);

		} else {
			if (landerController.monoPropellant < 20 ) {
				monoBar.color = new Color (1f, 0f, 0f, 1f);
				monoRemaining.color = new Color (1f, 0f, 0f, 1f);
			} else {
				
				monoBar.color = new Color (1f, 1f, 1f, 1f);
				monoRemaining.color = new Color (1f, 0.9f, 0.63f, 1f);
			}
		}

		//Hull guage color control
		//Monopropellant guage color control
		if (landerController.hull < 50 && landerController.hull > 20) {
			hullBar.color = new Color (1f, 0.5f, 0.3f, 1f);
			hullRemaining.color = new Color (1f, 0.5f, 0.3f, 1f);

		} else {
			if (landerController.hull < 20) {
				hullBar.color = new Color (1f, 0f, 0f, 1f);
				hullRemaining.color = new Color (1f, 0f, 0f, 1f);
			} else {

				hullBar.color = new Color (1f, 1f, 1f, 1f);
				hullRemaining.color = new Color (1f, 0.9f, 0.63f, 1f);
			}
		}

	}
}
