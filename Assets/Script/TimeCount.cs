using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour
{
	public Text timerText;

	public float totalTime;
	public static int seconds;
	bool GameOver = false;
	public GameObject GameOverObj;
	public GameObject Seikou;
	public GameObject Sippai;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
        if (!GameOver)
        {
			timerText.text = seconds.ToString();
		}
		if(totalTime <= 0 && !GameOver)
        {
			SceneManager.LoadScene("ClearScene");
			GameOverObj.SetActive(true);
			GameOver = true;
		}

        if (ClickAnswer.seikou == 1)
        {
			Seikou.SetActive(true);
			Sippai.SetActive(false);
        }
        else if(ClickAnswer.seikou == 0)
        {
			Seikou.SetActive(false);
			Sippai.SetActive(true);
        }
	}
}