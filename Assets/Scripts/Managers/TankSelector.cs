using UnityEngine;
using System.Collections;

public class TankSelector : MonoBehaviour {

	public GameObject currentTank;

	public void selectTank(GameObject tank) {
		currentTank.SetActive (false);
		currentTank = tank;
		currentTank.SetActive (true);
	}
}
