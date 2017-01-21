using UnityEngine;
using System.Collections;

public class GenBuildingAtPoint : MonoBehaviour {

    public Transform spawnPoint;

    public GameObject botFloor;
    public GameObject midFloor;
    public GameObject topFloor;
    /// <summary>
    /// Minimum of 3 for buildings.
    /// </summary>
    public int buildingHeight;
    private float currentHeight;
    // Use this for initialization
    void Start () {

        if(buildingHeight < 3)
        {
            buildingHeight = 3;
        }

        //First, generate the bottom floor at the position of the spawnPoint
        Instantiate(botFloor, spawnPoint.transform.position,spawnPoint.transform.rotation);
        currentHeight = spawnPoint.transform.position.y;
        print(spawnPoint.transform.position.y);
        for(int i = 0; i < buildingHeight-2; i++)
       { 
            spawnPoint.transform.position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y + 1f, spawnPoint.transform.position.z);
            Instantiate(midFloor, spawnPoint.transform.position,spawnPoint.transform.rotation);
            print(spawnPoint.transform.position.y);
        }
        spawnPoint.transform.position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y + 1f, spawnPoint.transform.position.z);
        print(spawnPoint.transform.position.y);
        Instantiate(topFloor, spawnPoint.transform.position, spawnPoint.transform.rotation);

    }
	
	// Update is called once per frameS
	void Update () {
	
	}
}
