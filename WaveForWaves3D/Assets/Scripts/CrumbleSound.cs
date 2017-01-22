using UnityEngine;
using System.Collections;

public class CrumbleSound : MonoBehaviour {

	public bool iscrumbling = false;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine ("AdjustCrumbleVolume");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator AdjustCrumbleVolume()
	{
		while (true) 
		{
			if ((iscrumbling) && (this.GetComponents<AudioSource> () [1].volume < 0.2f)) 
			{
				this.GetComponents<AudioSource> () [1].volume += 0.05f;
			} 
			else if ((!iscrumbling) && (this.GetComponents<AudioSource> () [1].volume > 0f)) 
			{
				this.GetComponents<AudioSource> () [1].volume -= 0.05f;
			}
			yield return new WaitForSeconds (0.05f);
		}
	}
}
