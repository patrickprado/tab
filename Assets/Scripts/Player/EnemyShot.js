#pragma strict

var spawnPoint : Transform;
var bulletObject : GameObject;
var fireEffect : GameObject;
var numberOfShotsReceived : float = 0;
private var tankRunning : AudioSource;
private var tankShot : AudioSource;
var windowRect : Rect = Rect (20, 20, 120, 50);

function Start() {
	
	var sounds = gameObject.GetComponents(AudioSource);
 	tankRunning = sounds[0];
	tankShot = sounds[1];
}

function Update () {

   	// Fire!
	//Instantiate(fireEffect, spawnPoint.position, spawnPoint.rotation);
	// make ball
	//Instantiate(bulletObject, spawnPoint.position, spawnPoint.rotation);
	
	//tankShot.Play();
	
}

//Shot received
function OnTriggerEnter(hit: Collider) {

	numberOfShotsReceived += 1;
	if(numberOfShotsReceived == 3) {
		Destroy(gameObject);
		Application.LoadLevel("EndGame");
	}
}

