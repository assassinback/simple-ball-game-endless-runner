using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    // Use this for initialization
    public GameObject currentSurface;
    public GameObject nextSurface;
    public Animator anum;
    void Start()
    {
        StartCoroutine(SpawnSurface());
        if (anum != null)
        {
            anum.Play("PopUp");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnSurface()
    {
        while (true)
        {
            currentSurface = Instantiate(nextSurface, currentSurface.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
