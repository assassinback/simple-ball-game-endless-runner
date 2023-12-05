using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discmove : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D rb;
	void Start () {
        rb=this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, -7, 0);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
