using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswer : MonoBehaviour
{
    private float interval;
    private float time = 0f;
    public GameObject Seikou;
    public GameObject Sippai;
    public static int seikou = 2;

    public void Start()
    {
        interval = 3.0f;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
            seikou = 1;        
            ScoreText.score += 100;
        }else if (Input.GetKeyDown(KeyCode.N))
        {
            seikou = 0;
            Destroy(this.gameObject);      
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(this.gameObject);
            seikou = 0;        
        }

        time += Time.deltaTime;
        if (time >= interval)
        {
            Destroy(this.gameObject);            
        }
    }
}
