using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	GameObject mc;
	float timeSinceCollision = 1000f;

	// Use this for initialization
	void Start () 
	{
		mc = GameObject.Find ("Main Camera");	
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceCollision += Time.deltaTime;
		if ((timeSinceCollision > 3f) && (timeSinceCollision < 1000f)) {
			mc.GetComponent<CrumbleSound> ().iscrumbling = false;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		timeSinceCollision = 0f;
        ScoreManager.score += Random.Range(400, 600);
        Destroy (other.gameObject);
	}
}
