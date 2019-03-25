using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0.1f * Input.GetAxis("Horizontal"), 0f, 0.1f * Input.GetAxis("Vertical"));
    }
}
