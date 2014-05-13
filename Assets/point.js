#pragma strict

var flag: GameObject;

function OnTriggerEnter (c : Collider) {
	if(c.name == "First Person Controller")
		flag.SendMessage("incrementScore");
}
