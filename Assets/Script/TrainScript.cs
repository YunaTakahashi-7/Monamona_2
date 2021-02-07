using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainScript : MonoBehaviour
{
    public GameObject[] Train;
    public Text ScoreText;
    public int score = 0;

    void Start()
    {
        MakeObject();
    }
    public void MakeObject()
    {
        int number = Random.Range(0, Train.Length);
        Train[number].SetActive(true);
        Instantiate(Train[number], transform.position, transform.rotation);
        
        Debug.Log("生成");
    }
    private void Update()
    {
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        if (Train[2].activeSelf || Train[7].activeSelf)
    //        {
    //            Debug.Log("maruSSS");
    //            score += 10;
    //            ScoreText.text = "" + score;
    //        }
    //    }
    //    if (Input.GetKeyDown(KeyCode.N))
    //    {
    //        //Debug.Log("N was pressed.");
    //        if (Train[0].activeSelf || Train[1].activeSelf)
    //        {
    //            Debug.Log("maruNNN");
    //            score += 10;
    //            ScoreText.text = "" + score;
    //            Train[0].SetActive(false);
    //            Train[1].SetActive(false);
    //        }
    //    }
    //    if (Input.GetKeyDown(KeyCode.M))
    //    {
    //        //Debug.Log("M was pressed.");
    //        if (Train[3].activeSelf || Train[4].activeSelf || Train[6].activeSelf || Train[8].activeSelf)
    //        {
    //            Debug.Log("maruMMM");
    //            score += 10;
    //            ScoreText.text = "" + score;
    //        }
    //    }
    //    if (Input.GetKeyDown(KeyCode.J))
    //    {
    //        //Debug.Log("N was pressed.");
    //        if (Train[5].activeSelf)
    //        {
    //            Debug.Log("maruJJJ");
    //            score += 10;
    //            ScoreText.text = "" + score;
    //        }
    //    }
    }
}
