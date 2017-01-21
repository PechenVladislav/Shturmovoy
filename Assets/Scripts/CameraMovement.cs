﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    [SerializeField]
    private Transform target;

    private Vector3 cameraChase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        cameraChase = new Vector3(transform.position.x, target.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, cameraChase, 0.3f);

	}
}