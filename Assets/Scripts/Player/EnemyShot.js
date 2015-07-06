#pragma strict

var spawnPoint : Transform;
var bulletObject : GameObject;
var fireEffect : GameObject;
var numberOfShotsReceived : float = 0;
private var tankRunning : AudioSource;
private var tankShot : AudioSource;
var windowRect : Rect = Rect (20, 20, 120, 50);
var nextUsage : float = 0;
var delay=4;//two seconds delay.

static var enemies : int;

function Start() {
    nextUsage = Time.time + delay;
    var sounds = gameObject.GetComponents(AudioSource);
     tankRunning = sounds[0];
    tankShot = sounds[1];
    enemies = 3;
}

function Update () {

    if (Time.time > nextUsage) {
        nextUsage = Time.time + delay;
           // Fire!
        Instantiate(fireEffect, spawnPoint.position, spawnPoint.rotation);
        // make ball
        Instantiate(bulletObject, spawnPoint.position, spawnPoint.rotation);
        
        tankShot.Play();
    }
    
}

//Shot received
function OnTriggerEnter(hit: Collider) {
    numberOfShotsReceived += 1;
    if(numberOfShotsReceived == 5) {
        Destroy(gameObject);
        enemies--;
        
        if (enemies == 0)
        	Application.LoadLevel("End Game");
    }
}