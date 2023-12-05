using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchSound : MonoBehaviour {

    public AudioSource audio;
    public Image x;
    public Image y;
    public Image z;
    public GameObject soundOffButton;
    public GameObject soundOnButton;
    public AudioListener audioListener;
    public int i = 0;
    // Use this for initialization
    void Start()
    {
        //if (AudioListener.pause == true)
        //{
        //    soundOffButton.SetActive(true);
        //    soundOnButton.SetActive(false);
        //}
        //else
        //{
        //    soundOnButton.SetActive(true);
        //    soundOffButton.SetActive(false);
        //}
        //audio = GetComponent<AudioSource>();
        //y = GetComponent<Image>();
        DontDestroyOnLoad();
    }
    void DontDestroyOnLoad()
    {

    }
    public void soundoff()
    {
        // audio.mute = !audio.mute;
        // audio.mute=true;
        // if (i == 0) {
        // 	i = 1;
        // 	y.sprite = x.sprite;
        // } 
        // else if (i == 1) {
        // 	i = 0;
        // 	y.sprite = z.sprite;
        // }
        //soundOffButton.SetActive(true);
        //soundOnButton.SetActive(false);
        if (AudioListener.pause == false)
        {
            AudioListener.pause = true;
            Debug.Log("Sound On");
        }
        else if(AudioListener.pause==true)
        {
            AudioListener.pause = false;
            Debug.Log("Sound Off");
        }

    }
    // Update is called once per frame
    void Update()
    {
        //if (AudioListener.pause == true)
        //{
        //    soundOffButton.SetActive(true);
        //    soundOnButton.SetActive(false);
        //}
        //else
        //{
        //    soundOnButton.SetActive(true);
        //    soundOffButton.SetActive(false);
        //}
    }
    public void SoundOn()
    {
        //soundOffButton.SetActive(false);
        //soundOnButton.SetActive(true);
        //AudioListener.pause = false;
    }
}
