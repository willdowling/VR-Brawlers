using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	
	
	public float strafeSpeed = 150.0f;
	public float runSpeed = 3.0f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * runSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
