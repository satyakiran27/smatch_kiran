using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DigitalClock : MonoBehaviour {
    DateTime DateFetcher;
    public GameObject Hours, Minutes, Seconds;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DateFetcher = DateTime.Now;
        print("print: " + DateFetcher);
        Hours.GetComponent<TextMesh>().text = DateFetcher.Hour.ToString();
        Minutes.GetComponent<TextMesh>().text = DateFetcher.Minute.ToString();
        Seconds.GetComponent<TextMesh>().text = DateFetcher.Second.ToString();

    }
}
