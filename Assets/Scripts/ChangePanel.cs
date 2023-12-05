using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour {

	// Use this for initialization
    public GameObject enableobj;
    public GameObject disableobj;
	void Start () {
		
	}
    public void changepanel()
    {
        enableobj.SetActive(true);
        disableobj.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
