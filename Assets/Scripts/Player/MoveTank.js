#pragma strict


import System.Threading;
 
var leftTrack : MoveTrack;
var rightTrack : MoveTrack;

var acceleration : float = 2;

var currentVelocity : float = 0;
var maxSpeed : float = 10;

var rotationSpeed : float = 30;
var numberOfShotsReceived : float = 0;

var remainingBullets : int;
var reloadBullet : int;

var spawnPoint : Transform;
var bulletObject : GameObject;
var fireEffect : GameObject;

private var tankRunning : AudioSource;
private var tankShot : AudioSource;


function Start() {
    // Get Track Controls
    leftTrack = GameObject.Find(gameObject.name + "/Lefttrack").GetComponent(MoveTrack);
    rightTrack = GameObject.Find(gameObject.name + "/Righttrack").GetComponent(MoveTrack);
    
    var sounds = gameObject.GetComponents(AudioSource);
     tankRunning = sounds[0];
    tankShot = sounds[1];
    reloadBullet = 0;
}

function Update () {
    
    if (Input.GetKey (KeyCode.UpArrow)) {
        // plus speed
        if (currentVelocity <= maxSpeed) 
            currentVelocity += acceleration * Time.deltaTime;

    } else if (Input.GetKey (KeyCode.DownArrow)) {
        // minus speed
        if (currentVelocity >= -maxSpeed) 
            currentVelocity -= acceleration * Time.deltaTime;
        
    } else {
        // No key input. 
        if (currentVelocity > 0) 
            currentVelocity -= acceleration * Time.deltaTime;
        else if (currentVelocity < 0) 
            currentVelocity += acceleration * Time.deltaTime;
    }
    
    tankRunning.volume = (Mathf.Abs(currentVelocity) / maxSpeed) + 0.01;

    // Turn off engine if currentVelocity is too small. 
    if (Mathf.Abs(currentVelocity) <= 0.05) {
        currentVelocity = 0;
    }    

    // Move Tank by currentVelocity
    transform.Translate(Vector3(0, 0, currentVelocity * Time.deltaTime));

    // Move Tracks by currentVelocity     
    if (currentVelocity > 0) {
        // Move forward
        leftTrack.speed = currentVelocity;
        leftTrack.GearStatus = 1;
        rightTrack.speed = currentVelocity;
        rightTrack.GearStatus = 1;
    }
    else if (currentVelocity < 0)    {
        // Move Backward
        leftTrack.speed = -currentVelocity;
        leftTrack.GearStatus = 2;
        rightTrack.speed = -currentVelocity;
        rightTrack.GearStatus = 2;
    }
    else {
        // No Move
        leftTrack.GearStatus = 0;    
        rightTrack.GearStatus = 0;        
    }


    // Turn Tank
    if (Input.GetKey (KeyCode.LeftArrow)) {
        if (Input.GetKey(KeyCode.DownArrow)) {
            // Turn right
            transform.Rotate(Vector3(0, rotationSpeed * Time.deltaTime, 0));
            
            leftTrack.speed = rotationSpeed;
            leftTrack.GearStatus = 1;
            rightTrack.speed = rotationSpeed;
            rightTrack.GearStatus = 2;
            
        } else {
            // Turn left
            transform.Rotate(Vector3(0, -rotationSpeed * Time.deltaTime, 0));
            
            leftTrack.speed = rotationSpeed;
            leftTrack.GearStatus = 2;
            rightTrack.speed = rotationSpeed;
            rightTrack.GearStatus = 1;
            
        }
    }

    if (Input.GetKey (KeyCode.RightArrow)) {
        if (Input.GetKey(KeyCode.DownArrow)) {
            // Turn left
            transform.Rotate(Vector3(0, -rotationSpeed * Time.deltaTime, 0));
            leftTrack.speed = rotationSpeed;
            leftTrack.GearStatus = 2;
            rightTrack.speed = rotationSpeed;
            rightTrack.GearStatus = 1;

        } else {
            // Turn right
            transform.Rotate(Vector3(0, rotationSpeed * Time.deltaTime, 0));
            leftTrack.speed = rotationSpeed;
            leftTrack.GearStatus = 1;
            rightTrack.speed = rotationSpeed;
            rightTrack.GearStatus = 2;
            
        }
    }
    
    
    // Fire!
    if (Input.GetButtonDown("Fire1") && remainingBullets > 0 && reloadBullet == 0) {
        // make fire effect.
        Instantiate(fireEffect, spawnPoint.position, spawnPoint.rotation);
        
        // make ball
        Instantiate(bulletObject, spawnPoint.position, spawnPoint.rotation);
        
        tankShot.Play();
        
        reloadBullet = 1;
        remainingBullets--;
        
        StartCoroutine("ReloadBulletThread");
    }
    
}

//Shot received
function OnTriggerEnter(hit: Collider) {

    numberOfShotsReceived += 1;
    if(numberOfShotsReceived == 2) {
        Application.LoadLevel("End Game");
    }
}

function ReloadBulletThread() {
    yield WaitForSeconds(3);
    reloadBullet = 0;
}