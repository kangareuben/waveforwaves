using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)
	{
        ScoreManager.score += Random.Range(400, 600);
        Destroy (other.gameObject);
	}
}
