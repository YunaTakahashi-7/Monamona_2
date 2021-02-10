using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswerMN : MonoBehaviour
{
    private float interval = 3.0f;
    private float time = 0f;
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
        else{
            Debug.Log("C");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            ClickAnswer.seikou = 0;
            Destroy(this.gameObject);
            
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            ClickAnswer.seikou = 1;
            ScoreText.score += 100;
            Destroy(this.gameObject);
            
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            ClickAnswer.seikou = 1;
            ScoreText.score += 100;
            Destroy(this.gameObject);
           
        }

        time += Time.deltaTime;
        if (time >= interval)
        {
            ClickAnswer.seikou = 0;
            Destroy(this.gameObject);
        }
    }
}
