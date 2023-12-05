using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameover : MonoBehaviour {

	// Use this for initialization
    public Canvas can;
    public GameObject sc;
	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            can.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
            if(PlayerPrefs.GetInt("HighScore")<sc.GetComponent<ScoreUI>().score)
            {
                PlayerPrefs.SetInt("HighScore", sc.GetComponent<ScoreUI>().score);
                Debug.Log("New High Score:" + sc.GetComponent<ScoreUI>().score);
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
