using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gallery : MonoBehaviour
{
    public GameObject page1;
    public GameObject page1text;
    public GameObject page2;
    public GameObject page2text;
    public GameObject page3;
    public GameObject page3text;
    public GameObject page4;
    public GameObject page4text;
    public GameObject page5;
    public GameObject page5text;
    public GameObject YazirushiL;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickYazirushiR()
    {
        if (page1.activeSelf)
        {
            page1.SetActive(false);
            page1text.SetActive(false);
            page2.SetActive(true);
            page2text.SetActive(true);
            YazirushiL.SetActive(true);
        }
        else if (page2.activeSelf)
        {
            page2.SetActive(false);
            page2text.SetActive(false);
            page3.SetActive(true);
            page3text.SetActive(true);
        }
        else if (page3.activeSelf)
        {
            page3.SetActive(false);
            page3text.SetActive(false);
            page4.SetActive(true);
            page4text.SetActive(true);   
        }
        else if (page4.activeSelf)
        {
            page4.SetActive(false);
            page4text.SetActive(false);
            page5.SetActive(true);
            page5text.SetActive(true); 
        }
        else if (page5.activeSelf)
        {
            page5.SetActive(false);
            page5text.SetActive(false);
            page1.SetActive(true);
            page1text.SetActive(true);
        }
    }

    public void OnclickYazirushiL()
    {
        if (page1.activeSelf)
        {
            page1.SetActive(false);
            page1text.SetActive(false);
            page5.SetActive(true);
            page5text.SetActive(true);   
        }
        else if (page2.activeSelf)
        {
            page2.SetActive(false);
            page2text.SetActive(false);
            page1.SetActive(true);
            page1text.SetActive(true);  
        }
        else if (page3.activeSelf)
        {
            page3.SetActive(false);
            page3text.SetActive(false);
            page2.SetActive(true);
            page2text.SetActive(true);
        }
        else if (page4.activeSelf)
        {
            page4.SetActive(false);
            page4text.SetActive(false);
            page3.SetActive(true);
            page3text.SetActive(true);
        }
        else if (page5.activeSelf)
        {
            page5.SetActive(false);
            page5text.SetActive(false);
            page4.SetActive(true);
            page4text.SetActive(true);
        }
    }

    public void OnclickModoruYazirushi()
    {
        SceneManager.LoadScene("ClearScene");
    }
}
