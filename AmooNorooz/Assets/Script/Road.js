#pragma strict
var Road : GameObject;

function Start () {

}

function OnTriggerEnter (other : Collider) {
if(other.gameObject.name == ("Player")){

Instantiate(Road , transform.position , transform.rotation);
transform.Translate(0, -4, 0);
}
}