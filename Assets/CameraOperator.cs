﻿using UnityEngine;
using System.Collections;

public class CameraOperator : MonoBehaviour {
	float dampTime = 0.0f; //offset from the viewport center to fix damping
	Vector3 velocity = Vector3.zero;
	public GameObject target;
	////ukasz edit
	public GameObject second;
	////
	// Use this for initialization
	void Start () {
	
	}
	
	void LateUpdate() {
		if(target) {
			/*
			Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.transform.position);
			Vector3 delta = target.transform.position -
						GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			var destination = transform.position + delta;//przesunięcie względem początku sceny
			destination.y = transform.position.y;// przywrócenie współrzędnej kamery
			destination.z = transform.position.z;
			transform.position = destination;
			*/
			var destination = transform.position;
			destination.x = second.transform.position.x + 0.5f*(target.transform.position.x - second.transform.position.x);
			transform.position = destination; //kamera ustawiana pomiędzy grzesiem i mateuszem
		}
	}
}
