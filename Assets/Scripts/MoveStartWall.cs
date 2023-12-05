using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStartWall : MonoBehaviour {

	// Use this for initialization
    public GameObject obj;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x < obj.transform.position.x - 12f)
        {
            this.transform.position = new Vector3(obj.transform.position.x - 12f, this.transform.position.y, this.transform.position.y);
        }
	}
}
