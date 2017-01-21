using UnityEngine;
using System.Collections;
using Leap;

public class DetectHands : MonoBehaviour
{
	Controller controller;
	Frame currentFrame;

	public GameObject cube;

	void Awake()
	{
		controller = new Controller();
	}

	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
		currentFrame = controller.Frame();
		cube.transform.position = new Vector3(currentFrame.Hands[0].PalmPosition.x / 20f, currentFrame.Hands[0].PalmPosition.y / 50f - 5f, 0);
	}
}