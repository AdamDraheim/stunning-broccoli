using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
        {
            gameObject.transform.position += new Vector3(-5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        }
    }
}
