using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLine : MonoBehaviour {

    // Use this for initialization
    int firsttime = 0;
    public GameObject scoreText;
    public List<LineRenderer> a;
    private LineRenderer line; // Reference to LineRenderer
    private Vector3 mousePos;
    private Vector3 startPos;    // Start position of line
    private Vector3 endPos;    // End position of line
    float ll;
    public Material mat;
    public int j = -2;
    public int u=0;
    static public int i = 0;
    void Start () {
        a = new List<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if(firsttime==0)
            {
                firsttime = 1;
                scoreText.GetComponent<ScoreUI>().enabled = true;
            }
            if (u == 0)
                Time.timeScale = 1;
            //pausepanel.SetActive (true);
            u++;

            if (line == null)
                createLine();
            mousePos = new Vector3();
            //disc.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
            //f.enabled = true;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(0, mousePos);
            startPos = mousePos;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (line)
            {
                mousePos = new Vector3();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, mousePos);
                endPos = mousePos;
                ll = Vector3.Distance(startPos, endPos);
                addColliderToLine();
                line = null;

            }
        }
        else if (Input.GetMouseButton(0))
        {
            if (line)
            {
                mousePos = new Vector3();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, mousePos);
                line.sortingOrder = 2;
            }
        }
    }
    private void createLine()
    {
        line = new GameObject("Line" + i).AddComponent<LineRenderer>();
        //line.material =  new Material(Shader.Find("Diffuse"));


        line.SetVertexCount(2);
        line.SetWidth(0.3f, 0.3f);
        //line.SetColors(Color.black, Color.black);
        line.material = mat;
        line.useWorldSpace = true;
        float lineLength = Vector3.Distance(startPos, endPos);
        print(ll);
        if (ll != 0)
        {
            print(lineLength);
            i += 1;
        }
        //i+=1;
        //linesAmount.text= i.ToString();
        j++;
        a.Add(line);
        if (a.Count >= 3)
        {

            Destroy(a[0].gameObject);

            a.RemoveAt(0);
        }
        
    }
    // Following method adds collider to created line
    private void addColliderToLine()
    {
        BoxCollider2D col = new GameObject("Collider").AddComponent<BoxCollider2D>();
        col.transform.parent = line.transform; // Collider is added as child object of line
        float lineLength = Vector3.Distance(startPos, endPos); // length of line
        col.size = new Vector3(lineLength, 0.1f, 1f); // size of collider is set where X is length of line, Y is width of line, Z will be set as per requirement
        Vector3 midPoint = (startPos + endPos) / 2;
        col.transform.position = midPoint; // setting position of collider object
        // Following lines calculate the angle between startPos and endPos
        float angle = (Mathf.Abs(startPos.y - endPos.y) / Mathf.Abs(startPos.x - endPos.x));
        if ((startPos.y < endPos.y && startPos.x > endPos.x) || (endPos.y < startPos.y && endPos.x > startPos.x))
        {
            angle *= -1;
        }
        angle = Mathf.Rad2Deg * Mathf.Atan(angle);
        col.transform.Rotate(0, 0, angle);
        col.gameObject.AddComponent<Rigidbody2D>();
        col.attachedRigidbody.bodyType = RigidbodyType2D.Static;
        


    }
}
