﻿using UnityEngine;
using System.Collections;

public class BaseController : MonoBehaviour {

	public enum goDirection {up, down, left, right, stay }
	public goDirection direction;
	public float speed;
	
	private bool shouldGo = false;
	private Quaternion initialRot;
	
	void Start () {
		initialRot = transform.rotation;
	}
	
	void Update () {
		rigidbody.velocity = Vector3.zero;
		
		if (direction == goDirection.right) {
			transform.rotation = initialRot;
			transform.Rotate (new Vector3 (0, -90, 0));
			rigidbody.AddForce (-transform.forward * speed, ForceMode.Impulse);
		} else if (direction == goDirection.left) {
			transform.rotation = initialRot;
			transform.Rotate (new Vector3 (0, 90, 0));
			rigidbody.AddForce (-transform.forward * speed, ForceMode.Impulse);
		} else if (direction == goDirection.up) {
			transform.rotation = initialRot;
			transform.Rotate(new Vector3(90, 0, 0));
			rigidbody.AddForce (-transform.forward * speed, ForceMode.Impulse);
		} else if (direction == goDirection.down) {
			transform.rotation = initialRot;
			transform.Rotate(new Vector3(-90, 0, 0));
			rigidbody.AddForce (-transform.forward * speed, ForceMode.Impulse);
		}
	}
}
