using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void changescene(string scenename)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenename);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
