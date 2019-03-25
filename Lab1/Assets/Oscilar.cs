using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour {

    bool movingUp = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (movingUp) {
            transform.Translate(0f, 1f * Time.deltaTime, 0f);
            if (transform.position.y >= 3)
            {
                movingUp = false;
            }
        }
        else {
            transform.Translate(0f, -1f * Time.deltaTime, 0f);
            if (transform.position.y <= 0.5)
            {
                movingUp = true;
            }
        }
	}
}
