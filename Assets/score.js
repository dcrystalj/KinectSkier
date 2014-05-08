#pragma strict
var score: int = 0;
var scoreText : GUIText;


function Update () {
	scoreText.text = "Score: " + score.ToString();
}

function incrementScore() {
	this.score += 1;
}