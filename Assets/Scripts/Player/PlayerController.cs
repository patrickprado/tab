using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Threading;

public class PlayerController : MonoBehaviour {

	private bool isPaused;

	public GameObject pausedScreen;
	public Slider lifeBar;
	public Text reloadBullet;
	public Text tankBullets;
	public Text tankName;

	public static int life;
	public int maxBullets;
	public int remainingBullets;

	private bool isReload;

	void Start () {
		isPaused = false;
		life = 100;
		remainingBullets = maxBullets;
		isReload = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			isPaused = !isPaused;
			pausedScreen.SetActive (isPaused);
			Time.timeScale = (isPaused ? 0 : 1);
		}

		if (Input.GetButtonDown ("Fire1") && !isReload) {
			if (remainingBullets > 0) {
				fire();
			}
		}

		lifeBar.value = life;
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
