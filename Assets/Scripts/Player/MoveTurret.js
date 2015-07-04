#pragma strict

var speed : float = 15;

function Update () {
	transform.Rotate(Vector3(0, Input.GetAxis("Mouse X") * Time.deltaTime * speed, 0));
}