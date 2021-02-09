using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public GameObject RuleImage;
    public GameObject ToziruButton;

    public void OnClickStartButton()
    {
        ScoreText.score = 0;
        ClickAnswer.seikou = 2;
        SceneManager.LoadScene("GameScene");
    }
    public void OnClickRuleButton()
    {
        RuleImage.SetActive(true);
        ToziruButton.SetActive(true);
    }
    
    public void OnClickToziruButton()
    {
        RuleImage.SetActive(false);
        ToziruButton.SetActive(false);
    }
}
