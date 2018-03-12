//ака 47
using UnityEngine;

public class RotateByObject : MonoBehaviour {

	[SerializeField] protected Vector3 vc3 = new Vector3(0,0,0);

	// Update is called once per frame
	void Update () {
		transform.Rotate (vc3.x,vc3.y,vc3.z);
	}
}