using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SideScroller;
public class GUIMenu : MonoBehaviour
{
    public int scrW;
    public int scrH;
    public GameObject cam;
    public bool starter;
    public float Score;
    public float trunct;
    public GameObject character;

    void Start()
    {
        
        cam.GetComponent<Slider>().enabled = false;
    }
    void Update()
    {
        Score = character.transform.position.x /2;
        //trunct = Mathf.Round(Score * 100f) / 100f;
    }
    void OnGUI()
    {
        
        scrW = Screen.width / 16;
        scrH = Screen.height / 9;
        GUI.Box(new Rect(scrW, scrH, scrW, scrH), Score.ToString("F0"));
        GUI.Label(new Rect(scrW, 0.25f * scrH, 2.5f * scrW, scrH), "Double Click if Starting Game.");
        if (GUI.Button(new Rect(scrW, scrH, 2.5f * scrW, scrH), "Play/Pause Game"))
        {
            cam.GetComponent<Slider>().enabled = starter;
            starter = !starter;
        }
    }
}
