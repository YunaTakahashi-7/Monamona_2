using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswer : MonoBehaviour
{
    private float interval;
    private float time = 0f;
    public static int seikou = 2;
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip SeikaiSE;
    public AudioClip SippaiSE;

    public void Start()
    {
        interval = 3.0f;
        audioSource = GetComponent<AudioSource>();
    }

    public void Awake()
    {
        if (seikou == 1)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(SeikaiSE);
        }
        else if (seikou == 0)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(SippaiSE);
        }
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
