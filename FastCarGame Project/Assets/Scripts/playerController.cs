using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float x;
    public float z;

    public float fSpeed = 300.0f;
    public float rSpeed = 10.0f;

	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * fSpeed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * rSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	}
}
