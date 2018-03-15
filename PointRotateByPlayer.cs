//ака 47
using UnityEngine;

public class PointRotateByPlayer : MonoBehaviour {

	[SerializeField] protected Vector3[] Distance = null;
	[SerializeField] protected Transform Point = null;
	[SerializeField] protected Transform[] PointObject = null;
	[SerializeField] protected Vector3 Vc3 = new Vector3(0,1,0);

	void Start()
	{
		for(int a = 0 ; a < PointObject.Length ; a++)
		{
			PointObject [a].transform.localPosition = new Vector3(Distance[a].x,Distance[a].y,Distance[a].z);
		}
	}

	// Update is called once per frame
	void Update () 
	{
		Point.transform.localPosition = this.transform.localPosition;
		Point.Rotate (Vc3.x, Vc3.y , Vc3.z);
	}
}