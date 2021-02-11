using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswerM : MonoBehaviour
{
    private float interval = 3.0f;
    private float time = 0f;
    //public GameObject Seikou;
    //public GameObject Sippai;
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip SeikaiSE;
    public AudioClip SippaiSE;

    public void Start()
    {
        if (ClickAnswer.seikou == 1)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(SeikaiSE);
        }
        else if (ClickAnswer.seikou == 0)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(SippaiSE);
        }
        else
        {
            Debug.Log("C_M");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScoreText.score -= 100;
            ClickAnswer.seikou = 0;
            Destroy(this.gameObject); 
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            ScoreText.score -= 100;
            ClickAnswer.seikou = 0;
            Destroy(this.gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.M))  //正解
        {
            
            ClickAnswer.seikou = 1;
            ScoreText.score += 200;
            Destroy(this.gameObject);  
        }

        time += Time.deltaTime;
        if (time >= interval)
        {
            ScoreText.score -= 100;
            ClickAnswer.seikou = 0;
            Destroy(this.gameObject);
        }
    }
}
