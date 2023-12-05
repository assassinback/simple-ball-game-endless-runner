using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSpawner : MonoBehaviour {

    // Use this for initialization
    public GameObject spawnPoint;
    public GameObject Board;
    public GameObject walltop;
    public GameObject wallfront;
    public GameObject wallbottom;
    public GameObject ball;
    public Transform parent;
    public GameObject[] gob;
    public GameObject cam;
	void Start () {
        gob=new GameObject[3];
        //StartCoroutine(SpawnBoard());
	}
    IEnumerator SpawnBoard()
    {
        while (true)
        {
            
            gob = new GameObject[3];
            gob[0]=Instantiate(walltop, new Vector3(spawnPoint.transform.position.x,walltop.transform.position.y,walltop.transform.position.z), Quaternion.identity);
            //Instantiate(wallfront, new Vector3(spawnPoint.transform.position.x, wallfront.transform.position.y, walltop.transform.position.z), Quaternion.identity);
            gob[1] = Instantiate(wallbottom, new Vector3(spawnPoint.transform.position.x, wallbottom.transform.position.y, walltop.transform.position.z), Quaternion.identity);
            gob[2] = Instantiate(Board, spawnPoint.transform.position, Quaternion.identity);
            parent.transform.position = new Vector3(parent.transform.position.x + 16, parent.transform.position.y, parent.transform.position.z);
            GameObject x = new GameObject();
            x.AddComponent<DestroyBoard>();
            x.GetComponent<DestroyBoard>().gobject = gob;
            yield return new WaitForSeconds(1.5f);
        }
    }
    // Update is called once per frame
    void Update () {
		if(parent.transform.position.x<ball.transform.position.x+20)
        {
            gob = new GameObject[3];
            gob[0] = Instantiate(walltop, new Vector3(spawnPoint.transform.position.x, walltop.transform.position.y, walltop.transform.position.z), Quaternion.identity);
            //Instantiate(wallfront, new Vector3(spawnPoint.transform.position.x, wallfront.transform.position.y, walltop.transform.position.z), Quaternion.identity);
            gob[1] = Instantiate(wallbottom, new Vector3(spawnPoint.transform.position.x, wallbottom.transform.position.y, walltop.transform.position.z), Quaternion.identity);
            gob[2] = Instantiate(Board, spawnPoint.transform.position, Quaternion.identity);
            parent.transform.position = new Vector3(parent.transform.position.x + 16, parent.transform.position.y, parent.transform.position.z);
            GameObject x = new GameObject();
            x.AddComponent<DestroyBoard>();
            x.GetComponent<DestroyBoard>().gobject = gob;
        }
	}
}
