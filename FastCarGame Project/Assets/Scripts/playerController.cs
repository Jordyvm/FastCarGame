using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float x;
    public float z;

	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        z = Input.GetAxis("Vertical") * Time.deltaTime * 12.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	}
}
