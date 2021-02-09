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
        SceneManager.LoadScene("GameScene");
    }
    public void OnClickRuleButton()
    {
        RuleImage.SetActive(true);
        ToziruButton.SetActive(true);
    }
    //public void OnClickRankingButton()
    //{
    //    //SceneManager.LoadScene("GameScene");
    //}
    public void OnClickToziruButton()
    {
        RuleImage.SetActive(false);
        ToziruButton.SetActive(false);
    }
}
