using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFront : MonoBehaviour {

	// Use this for initialization
    public Rigidbody2D rb;
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}
}
