using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapSelector : MonoBehaviour {

	private Text currentSelected;

	public GameObject backgroundMap;

	public static string mapSelectedName;

	public void changeTextColor(Text textSelected) {

		if (currentSelected != null)
			currentSelected.color = Color.white;

		currentSelected = textSelected;
		currentSelected.color = Color.red;
	}

	public void selectedMap(GameObject obj) {
		mapSelectedName = obj.name;
	}

	public void changeBackgroundTexture(Texture texture) {
		backgroundMap.GetComponent<RawImage> ().texture = texture;
	}

}
