using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswerN : MonoBehaviour
{
    private float interval;
    private float time = 0f;

    public void Start()
    {
        interval = 3.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);   
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Destroy(this.gameObject);
            Debug.Log("せいかーい");
            ScoreText.score += 100;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(this.gameObject);
        }

        time += Time.deltaTime;
        if (time >= interval)
        {
            Destroy(this.gameObject);
        }
    }
}
