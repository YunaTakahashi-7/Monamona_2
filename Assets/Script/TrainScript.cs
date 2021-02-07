using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainScript : MonoBehaviour
{
    public GameObject[] Train;
    public Text ScoreText;
    public int score = 0;

    private float interval;
    private float time = 0f;

    public static int number;

    void Start()
    {
        interval = 3.0f;
        MakeObject();
    }
    public void MakeObject()
    {
        number = Random.Range(0, Train.Length);
        Train[number].SetActive(true);
        Instantiate(Train[number], transform.position, transform.rotation);
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time > interval)
        {
            MakeObject();
            time = 0f;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.M))
        {
            MakeObject();
            time = 0f;
        }
    }
}
