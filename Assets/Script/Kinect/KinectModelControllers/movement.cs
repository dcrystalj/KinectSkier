using UnityEngine;
using System.Collections;
using System;


public class movement : MonoBehaviour {
	public GameObject mouseLook;
	public SkeletonWrapper sw;
	public int player;
	string display = " ";
	float leftRight;
	float upDown;

	// Update is called once per frame
	void Update () {
		if (player == -1)
						return;
		if (sw.pollSkeleton ()) 
		{
			Vector3 Hip_Center = new Vector3(
				sw.bonePos [player, 0].x,
				sw.bonePos [player, 0].y,
				sw.bonePos [player, 0].z);

			Vector3 Shoulder_Center = new Vector3(
				sw.bonePos [player, 2].x,
				sw.bonePos [player, 2].y,
				sw.bonePos [player, 2].z);
			this.leftRight = Shoulder_Center.x - Hip_Center.x;
			this.upDown = Hip_Center.y;
		}
		mouseLook.SendMessage("setX", leftRight);

	}

	public int getLeftRight(){
				if (leftRight > 0.1) {
						return 1;
				} else if (leftRight < -0.1) {
						return 2;
				} else {
						return 3;
				}
		}

	public int getUpDown(){
		if (upDown <1) {
			return 1;
		} else if (upDown >1.2) {
			return 2;
		} else {
			return 3;
		}
	}

}
