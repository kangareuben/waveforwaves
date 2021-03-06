﻿using UnityEngine;
using System.Collections;

public class WaterSurfaceController : MonoBehaviour
{
    public GameObject waterCube;
    public int waterWidth = 50;
    public int waterLength = 50;
    public GameObject[,] waterSurface;
    GameObject tempCube;
    SpringJoint tempspring;

	
    // Use this for initialization
	void Start ()
    {
        waterSurface = new GameObject[waterWidth, waterLength];
        for (int i = 0; i < waterWidth; i++)
            for(int j = 0; j < waterLength; j++)
            {
                waterSurface[i, j] = Instantiate(waterCube);
				waterSurface[i, j].transform.position = new Vector3(i * 1.1f, 0f, j * 1.1f);
                if ( i > 0 && j > 0)
                {
                    //tempspring = waterSurface[i, j].AddComponent<SpringJoint>();
                    //tempspring.connectedBody = waterSurface[i - 1, j - 1].GetComponent<Rigidbody>();
                    //tempspring.damper = 0f;

                    tempspring = waterSurface[i, j].AddComponent<SpringJoint>();
                    tempspring.connectedBody = waterSurface[i, j - 1].GetComponent<Rigidbody>();
                    tempspring.damper = 0f;

                    tempspring = waterSurface[i, j].AddComponent<SpringJoint>();
                    tempspring.connectedBody = waterSurface[i - 1, j].GetComponent<Rigidbody>();
                    tempspring.damper = 0f;
                }
                else 
                if( i > 0)
                    {
                        tempspring = waterSurface[i, j].AddComponent<SpringJoint>();
                        tempspring.connectedBody = waterSurface[i - 1, j].GetComponent<Rigidbody>();
                        tempspring.damper = 0f;
                }
                else
                if(j > 0)
                {
                    tempspring = waterSurface[i, j].AddComponent<SpringJoint>();
                    tempspring.connectedBody = waterSurface[i, j - 1].GetComponent<Rigidbody>();
                    tempspring.damper = 0f;
                }
                
            }
		for (int i = 0; i < 10; i++) {
			waterSurface [Random.Range (30, 50), Random.Range (0, 20)].GetComponent<Rigidbody> ().AddForce (Random.Range (-1f, 1f), 1000f, Random.Range (-1f, 1f));
		}
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
}
