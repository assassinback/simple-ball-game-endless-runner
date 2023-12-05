using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoard : MonoBehaviour {

	// Use this for initialization
    public GameObject[] gobject;
    public GameObject ball;
    public GameObject wallleft;
    
	void Start () {
        ball = GameObject.Find("ball");
        wallleft = GameObject.Find("start border back");
	}
	
	// Update is called once per frame
	void Update () {
		if(gobject!=null)
        {
            try
            {
                if (ball.transform.position.x > gobject[2].transform.position.x+20)
                {
                    //wallleft.transform.position = new Vector3(gobject[2].transform.position.x - 5, wallleft.transform.position.y, wallleft.transform.position.z);
                    Destroy(gobject[0]);
                    Destroy(gobject[1]);
                    Destroy(gobject[2]);
                    Destroy(this);
                }
            }
            catch(System.Exception)
            {

            }
        }

	}
}
