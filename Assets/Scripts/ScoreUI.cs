using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour {
    public int score = 0;
    public GameObject ball;
    public int time = 0;
    public GameObject timespent;
	// Use this for initialization
	void Start () {
        StartCoroutine(addScore());
	}
	
	// Update is called once per frame
	void Update () {
        score = (int)ball.transform.position.x+7;
        this.GetComponent<Text>().text = "Score:" + score + "";

	}
    IEnumerator addScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time++;
            timespent.GetComponent<Text>().text = "Time:" + time + "s";
        }
    }
}
