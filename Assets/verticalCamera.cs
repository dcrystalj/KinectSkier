using UnityEngine;
using System.Collections;

public class verticalCamera : MonoBehaviour {

	public GameObject mc;
	public Terrain terrain;
	public GameObject terrainGO;
	public GameObject fpc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		RaycastHit rcHit = new RaycastHit();

		Vector3 theRay = fpc.transform.TransformDirection (Vector3.down);
		if (Physics.Raycast (transform.position, theRay, out rcHit)) {

			float distance = rcHit.distance;
			Debug.Log(Vector3.up.x + "  " + Vector3.up.y + "  " + Vector3.up.z);
			Debug.Log(rcHit.normal.x + "  " + rcHit.normal.y + "  " + rcHit.normal.z);
			Vector3 tmp =  rcHit.normal;
			tmp.y = transform.rotation.y;
			Quaternion q = Quaternion.FromToRotation (Vector3.up * Time.deltaTime, tmp);
			//float pos = (transform.localPosition.y - distance) +1;
			//transform.localPosition = pos;

			transform.rotation = Quaternion.Slerp(
				transform.rotation, 
				q,
				Time.deltaTime
			);
		}
		//this.transform.position = graphics.transform.position;

		Ray bottom = new Ray(fpc.transform.position, Vector3.down);


	}
}
