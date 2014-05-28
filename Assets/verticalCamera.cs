using UnityEngine;
using System.Collections;

public class verticalCamera : MonoBehaviour {

	public GameObject mc;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit rcHit = new RaycastHit();
		
		Ray bottom = new Ray(this.camera.transform.position,Vector3.down);



		if (Physics.Raycast(bottom,out rcHit,20))
		{
			double posy = mc.transform.position.y;
			//with this you rotate object to adjust with terrain
			Quaternion ro= mc.transform.rotation;
			Vector3 rn = rcHit.normal;

			Quaternion q = Quaternion.FromToRotation (Vector3.up * Time.deltaTime, rn);
			q.x=0;
			q.z=0;

			mc.transform.rotation = Quaternion.Slerp(
				mc.transform.rotation, 
				q,
				Time.deltaTime
				);
		}
	}
}
