using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeTheme : MonoBehaviour {

	// Use this for initialization
    public Button b1;
    public Button b2;
    public GameObject mainPanel;
    public GameObject ShopPanel;
    public GameObject SettingPanel;
    public void b1click()
    {
        Color x=new Color(255,0,0,255);
        mainPanel.GetComponent<Image>().color = x;
        Color y = new Color(255, 0, 0,255);
        ShopPanel.GetComponent<Image>().color = y;
        Color z = new Color(255, 0, 0,255);
        SettingPanel.GetComponent<Image>().color = z;
    }
    public void b2click()
    {
        Color x = new Color(0, 0, 255);
        mainPanel.GetComponent<Image>().color = x;
        Color y = new Color(0, 0, 255);
        ShopPanel.GetComponent<Image>().color = y;
        Color z = new Color(0, 0, 255);
        SettingPanel.GetComponent<Image>().color = z;
    }
	void Start () {
        b1.onClick.AddListener(b1click);
        b2.onClick.AddListener(b2click);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
