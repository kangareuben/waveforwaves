using UnityEngine;
using System.Collections;
using Leap;

public class WaterImpulse : MonoBehaviour
{
	public GameObject hc;
	Vector3 v3;
	
	// Use this for initialization
	void Start ()
	{
		v3 = new Vector3();
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnTriggerEnter(Collider other)
	{
		Vector v = hc.GetComponent<HandController>().GetLeapController().Frame().Hands[0].PalmVelocity;

		v3.x = v.x;
		v3.y = v.y;
		v3.z = v.z;

		other.GetComponent<Rigidbody>().AddForce(v3 / 5f);
	}
}
