using UnityEngine;
using System.Collections;

public class WaveImpact : MonoBehaviour {
	GameObject mc;

	// Use this for initialization
	void Start () {
		mc = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

	void OnTriggerEnter(Collider other)
	{
        ScoreManager.score += Random.Range(800, 1200);
        this.GetComponent<Rigidbody> ().AddExplosionForce (1000f, this.transform.position, 10f);
		mc.GetComponent<CrumbleSound> ().iscrumbling = true;
	}
}