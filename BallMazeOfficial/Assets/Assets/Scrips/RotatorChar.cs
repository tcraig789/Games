using UnityEngine;
using System.Collections;

public class RotatorChar : MonoBehaviour {
	private GameObject downRotate;
	public float zSpeed;
	public float ySpeed;
	public float xSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.UpArrow)){
			zSpeed++;
		}

		else if (Input.GetKey(KeyCode.DownArrow)){
			zSpeed--;
		}

		else if (Input.GetKey(KeyCode.LeftArrow)){
			xSpeed--;
		}

		else if (Input.GetKey(KeyCode.RightArrow)){
			xSpeed++;
		}
		else {
			zSpeed = 0;
			ySpeed = 0;
			xSpeed = 0;
		}
		if (Input.GetKey (KeyCode.Space)) {
			zSpeed = 0;
		} 
	}
}
