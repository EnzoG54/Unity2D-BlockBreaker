﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelmanager;

	void OnTriggerEnter2D (Collider2D trigger) {
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		levelmanager.LoadLevel("Lose");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
