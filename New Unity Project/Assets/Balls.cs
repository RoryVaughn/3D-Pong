﻿using UnityEngine;
using System.Collections;

public class Balls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(1f*Time.deltaTime,0f,0f);
	}
}
