﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modoru : MonoBehaviour
{
    public void OnclickTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void OnclickRetry()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnclickRanking()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreText.score);
    }
    public void OnclickGallery()
    {
        SceneManager.LoadScene("GalleryScene");
    }
}
