﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {


    //回転速度
    private float roteSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0,360), 0);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, this.roteSpeed, 0);
		
	}
}
