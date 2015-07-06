using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Threading;

public class PlayerController : MonoBehaviour {

	private bool isPaused;

	public GameObject pausedScreen;
	public Text reloadBullet;
	public Text tankBullets;
	public Text tankName;

	public int maxBullets;
	public int remainingBullets;

	public string tankIdentifier;

	private bool isReload;

	void Start () {
		isPaused = false;
		remainingBullets = maxBullets;
		isReload = false;

		this.gameObject.SetActive (tankIdentifier.Equals (TankSelector.currentTankSelected));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			isPaused = !isPaused;
			pausedScreen.SetActive (isPaused);
			Time.timeScale = (isPaused ? 0 : 1);
		}

		if (Input.GetKey (KeyCode.Space) && !isReload) {
			if (remainingBullets > 0) {
				fire();
			}
		}

		tankBullets.text = remainingBullets + "/" + maxBullets;
		tankName.text = "Tanque: " + TankSelector.currentTankSelected;
	}

	public void fire() {
		remainingBullets--;
		isReload = true;
		reloadBullet.text = "RECARREGANDO...";

		StartCoroutine (reloadArm());
	}

	IEnumerator reloadArm() {
		yield return new WaitForSeconds (3);
		reloadBullet.text = "ARMAS CARREGADAS";
		isReload = false;
	}
}
