using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Leap;

public class WaterImpulse : MonoBehaviour
{
	public GameObject hc;
	Vector3 v3;
	static List<GameObject> affectedWaterCubes;
	Collider[] objectsInRadius;
	public GameObject[,] wSurface;
	[SerializeField]
	GameObject WSController;
	int waterWidth=50;
	int waterLength=50;
	
	// Use this for initialization
	void Start ()
	{
		v3 = new Vector3();

		if (affectedWaterCubes == null) 
		{
			affectedWaterCubes = new List<GameObject> ();
			objectsInRadius = Physics.OverlapSphere (new Vector3 (30.8f, 0f, 0f), 4f);
			foreach (Collider c in objectsInRadius) {
				if (c.name == "WaterCube(Clone)") {
					affectedWaterCubes.Add (c.gameObject);
				}
			}

			for (int i = 0; i < waterWidth; i++) 
			{
				for (int j = 0; j < waterLength; j++) 
				{
					if (!((j > 34) && (j < 47))) 
					{
						Destroy (WSController.GetComponent<WaterSurfaceController> ().waterSurface [i, j].GetComponent<Collider> ());
					}
				}
			}
		}

		InvokeRepeating("CheckHandPosition", 0f, 0.05f);
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void CheckHandPosition()
	{
		if(Mathf.Abs(transform.FindChild ("palm").position.y) < 0.5f)
		{
			Vector v = hc.GetComponent<HandController> ().GetLeapController ().Frame ().Hands [0].PalmVelocity;

			v3.x = v.x;
			v3.y = v.y;
			v3.z = v.z;

			foreach(GameObject g in affectedWaterCubes)
			{
				g.GetComponent<Rigidbody>().AddForce(v3);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		/*Vector v = hc.GetComponent<HandController>().GetLeapController().Frame().Hands[0].PalmVelocity;

		v3.x = v.x;
		v3.y = v.y;
		v3.z = v.z;

		other.GetComponent<Rigidbody>().AddForce(v3 / 5f);*/
	}
}
