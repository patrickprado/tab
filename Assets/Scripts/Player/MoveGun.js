#pragma strict

var speed : float = 40;

function Update () {	
	transform.Rotate(Vector3(Input.GetAxis("Mouse Y") * Time.deltaTime * -speed, 0, 0));
}