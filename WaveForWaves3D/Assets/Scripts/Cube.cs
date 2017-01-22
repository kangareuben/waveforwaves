using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "BuildingCub")
        {
            ScoreManager.score += Random.Range(20, 40);
        }
    }
}
