using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

    // Use this for initialization
    public GameObject ball;
    public GameObject spawnPoint1;
    public GameObject obstacle1;
    public GameObject spawnPoint2;
    public GameObject obstacle2;
    public GameObject spawnPoint3;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public Transform parent;
    GameObject x;
    public int spawnAt1;
    public int spawnAt2;
    public int spawnAt3;
    public GameObject[] obj;
    void Start () {

        //StartCoroutine(SpawnSurface());

    }
    IEnumerator SpawnBoard()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.5f);
        }
    }
    //IEnumerator SpawnSurface()
    //{
    //    while (true)
    //    {
    //        for (int i = 1; i <= 3;i++ )
    //        {
    //            spawnAt1 = Random.Range(1, 4);
    //            x = (GameObject)this.GetType().GetField("spawnPoint"+i).GetValue(this);
    //            Instantiate((GameObject)this.GetType().GetField("obstacle" + spawnAt1).GetValue(this), x.transform.position, Quaternion.identity);
    //        }
    //        //    spawnAt1 = Random.Range(1, 4);
    //        //if (spawnAt1 == 1)
    //        //{
    //        //    Instantiate(obstacle1, spawnPoint1.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt1 == 2)
    //        //{
    //        //    Instantiate(obstacle2, spawnPoint1.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt1 == 3)
    //        //{
    //        //    Instantiate(obstacle3, spawnPoint1.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt1 == 4)
    //        //{
    //        //    Instantiate(obstacle4, spawnPoint1.transform.position, Quaternion.identity);
    //        //}
    //        //spawnAt2 = Random.Range(1, 4);
    //        //if (spawnAt2 == 1)
    //        //{
    //        //    Instantiate(obstacle1, spawnPoint2.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt2 == 2)
    //        //{
    //        //    Instantiate(obstacle2, spawnPoint2.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt2 == 3)
    //        //{
    //        //    Instantiate(obstacle3, spawnPoint2.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt1 == 4)
    //        //{
    //        //    Instantiate(obstacle4, spawnPoint2.transform.position, Quaternion.identity);
    //        //}
    //        //spawnAt3 = Random.Range(1, 4);
    //        //if (spawnAt3 == 1)
    //        //{
    //        //    Instantiate(obstacle1, spawnPoint3.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt3 == 2)
    //        //{
    //        //    Instantiate(obstacle2, spawnPoint3.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt3 == 3)
    //        //{
    //        //    Instantiate(obstacle3, spawnPoint3.transform.position, Quaternion.identity);
    //        //}
    //        //else if (spawnAt1 == 4)
    //        //{
    //        //    Instantiate(obstacle4, spawnPoint3.transform.position, Quaternion.identity);
    //        //}
    //        parent.transform.position = new Vector3(parent.transform.position.x+5, parent.transform.position.y, parent.transform.position.z);
    //        yield return new WaitForSeconds(1.5f);
    //    }
    //}
	// Update is called once per frame
	void Update () {
        if (parent.transform.position.x < ball.transform.position.x + 20)
        {
            int j = 0;
            obj = new GameObject[3];
            for (int i = 1; i <= 3; i++)
            {
                spawnAt1 = Random.Range(1, 6);
                x = (GameObject)this.GetType().GetField("spawnPoint" + i).GetValue(this);
                if (spawnAt1 == 5)
                {
                    obj[j] = Instantiate((GameObject)this.GetType().GetField("obstacle" + spawnAt1).GetValue(this), new Vector3(x.transform.position.x + 20, Random.Range(3.6f, -3.6f), x.transform.position.z), Quaternion.identity);
                }
                else
                {
                    obj[j] = Instantiate((GameObject)this.GetType().GetField("obstacle" + spawnAt1).GetValue(this), new Vector3(x.transform.position.x, Random.Range(3.6f, -3.6f), x.transform.position.z), Quaternion.identity);
                }
                j++;
            }
            parent.transform.position = new Vector3(parent.transform.position.x + 10, parent.transform.position.y, parent.transform.position.z);
            GameObject y = new GameObject();
            y.AddComponent<DesytouObstacles>();
            y.GetComponent<DesytouObstacles>().gobject = obj;
        }
	}
}
