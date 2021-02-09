using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswerM : MonoBehaviour
{
    private float interval;
    private float time = 0f;
    public GameObject Seikou;
    public GameObject Sippai;
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip SeikaiSE;
    public AudioClip SippaiSE;

    public void Start()
    {
        interval = 3.0f;
    }

    public void Awake()
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
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
            ClickAnswer.seikou = 0;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Destroy(this.gameObject);
            ClickAnswer.seikou = 0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(this.gameObject);
            ClickAnswer.seikou = 1;
            ScoreText.score += 100;
        }

        time += Time.deltaTime;
        if (time >= interval)
        {
            Destroy(this.gameObject);
        }
    }
}
