using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject internalCamera;
	public GameObject externalCamera;
	public GameObject aimHud;

	private int mode;

	void Start() {
		mode = 1;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.C) && mode == 1) {
			internalCamera.SetActive (true);
			externalCamera.SetActive (false);
			aimHud.SetActive (true);
			mode = 2;
		} else if (Input.GetKeyDown (KeyCode.C) && mode == 2) {
			internalCamera.SetActive (false);
			externalCamera.SetActive (true);
			aimHud.SetActive (false);
			mode = 1;
		}

		Cursor.lockState = CursorLockMode.Confined;
	}
}
