using UnityEngine;
using System.Collections;

public class WaveImpact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		this.GetComponent<Rigidbody> ().AddExplosionForce (1000f, this.transform.position, 10f);
	}
}
