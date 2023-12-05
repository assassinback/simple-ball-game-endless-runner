using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    // Use this for initialization
    public GameObject cam;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(this.gameObject.GetComponent<Transform>().position.x>0)
        cam.transform.position = new Vector3(this.transform.position.x,cam.transform.position.y, cam.transform.position.z);
	}
}
