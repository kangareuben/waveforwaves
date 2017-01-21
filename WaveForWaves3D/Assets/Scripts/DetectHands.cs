using UnityEngine;
using System.Collections;
using Leap;

public class DetectHands : MonoBehaviour
{
	Controller controller;
	Frame currentFrame;
	Hand interactionHand;

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
		interactionHand = currentFrame.Hands [0];
		cube.transform.position = new Vector3(interactionHand.PalmPosition.x / 20f, interactionHand.PalmPosition.y / 40f - 5f, interactionHand.PalmPosition.z / -30f);
	}
}