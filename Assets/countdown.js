//#pragma strict

var timer : float = 3;
var gui : GUIText;
//var motor: OtherScript = GetComponent(OtherScript);
var fpc: GameObject;
var sw: GameObject; //SkeletonWrapper;
var mouseLook: GameObject;
var gt: GUIText;

function Update () {
	//t.text = "0";
	if(timer == 3 && gt.guiText == "0")
		return;
	
	timer -= Time.deltaTime; 
	if (timer <= 0){
		fpc.SendMessage("SetControllable", true);
		Destroy (gui);	
		Destroy(this);

	}
	gui.text = timer.ToString("0");
}