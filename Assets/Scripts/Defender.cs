﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	public int starCost = 10;

	private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();		
	}

	public void AddStars(int amount){
		starDisplay.AddStars (amount);
	}
}
