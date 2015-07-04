using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool isPaused;
	public GameObject pausedScreen;

	void Start () {
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			isPaused = !isPaused;
			pausedScreen.SetActive (isPaused);
			Time.timeScale = (isPaused ? 0 : 1);
		}
	}
}
