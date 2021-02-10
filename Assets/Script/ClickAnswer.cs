using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswer : MonoBehaviour
{
    private float interval =3.0f;
    private float time = 0f;
    public static int seikou = 2;
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip SeikaiSE;
    public AudioClip SippaiSE;

    public void Start()
    {
        if (seikou == 1)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(SeikaiSE);
            //Debug.Log("A");
        }
        else if (seikou == 0)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(SippaiSE);
            //Debug.Log("B");
        }
        else
        {
            Debug.Log("C");
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            seikou = 1;
            ScoreText.score += 100;
            Destroy(this.gameObject);
        }else if (Input.GetKeyDown(KeyCode.N))
        {
            seikou = 0;
            Destroy(this.gameObject);
           
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            seikou = 0;
            Destroy(this.gameObject);         
        }

        time += Time.deltaTime;
        if (time >= interval)
        {
            seikou = 0;
            Destroy(this.gameObject);            
        }
    }
}
