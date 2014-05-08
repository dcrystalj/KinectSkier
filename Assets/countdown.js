#pragma strict

var timer : float = 3;
var gui : GUIText;
//var motor: OtherScript = GetComponent(OtherScript);
var fpc: GameObject;

function Update () {
	timer -= Time.deltaTime; 
	if (timer <= 0){
		fpc.SendMessage("SetControllable", true);
		Destroy (gui);	
		Destroy(this);

	}
	gui.text = timer.ToString("0");
}
