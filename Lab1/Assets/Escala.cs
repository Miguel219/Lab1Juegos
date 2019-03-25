using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.K))&& (transform.localScale.x != 4)) {
            transform.localScale += new Vector3(1, 1, 1);
        }else if ((Input.GetKey(KeyCode.L))&& (transform.localScale.x != 1)) {
            transform.localScale += new Vector3(-1, -1, -1);
        }
    }
}
