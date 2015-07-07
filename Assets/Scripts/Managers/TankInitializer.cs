using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankInitializer : MonoBehaviour {

	public GameObject cronwell;
	public GameObject m4a3;
	public GameObject t34;
	public GameObject panther;
	public GameObject stug;
	public GameObject m24;
	public GameObject ma8;

	public Text tankName;

	// Use this for initialization
	void Start () {		
		cronwell.SetActive (cronwell.name.Equals (TankSelector.currentTankSelected));
		m4a3.SetActive (m4a3.name.Equals (TankSelector.currentTankSelected));
		t34.SetActive (t34.name.Equals (TankSelector.currentTankSelected));
		panther.SetActive (panther.name.Equals (TankSelector.currentTankSelected));
		stug.SetActive (stug.name.Equals (TankSelector.currentTankSelected));
		m24.SetActive (m24.name.Equals (TankSelector.currentTankSelected));
		ma8.SetActive (ma8.name.Equals (TankSelector.currentTankSelected));

		
		tankName.text = "Tanque: " + TankSelector.currentTankSelected;
	}

}
