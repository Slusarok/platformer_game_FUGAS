using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    UI ui;
    public GameObject InfoPanel;
    public GameObject Seting;
    public Image[] hpBar;
    public  int countDeath = -2;
    void Start()
    {
        countDeath++;
        if(countDeath == 3)
        {
            InfoPanel.SetActive(true);
            Seting.SetActive(false);
            Time.timeScale = 0;
        }
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        if (PlayerPrefs.GetInt("PositionPlayer") == 1)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"));
        }
        else if (PlayerPrefs.GetInt("PositionPlayer") == 0)
        {
            if(scene.buildIndex == 4)
            {
                transform.position = new Vector2(-7.4f, -2.47f);
            }
            if (scene.buildIndex == 5)
            {
                transform.position = new Vector2(-8.4f, -3.49f);
            }
            if (scene.buildIndex == 6)
            {
                transform.position = new Vector2(-5.757f, -0.912f);
            }
            if (scene.buildIndex == 7)
            {
                transform.position = new Vector2(-8.4f, -3.49f);
            }
            if (scene.buildIndex == 8)
            {
                transform.position = new Vector2(-0.29f, -2.46f);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("cheackpoint"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 1);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
        }
        if (collision.CompareTag("Prirva"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 0);
            CoinLogic.globalScoreCounter = 0;
            hpBar[countDeath].enabled = false;
            Start();
        }
    }

    public void Reset()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("PositionPlayer", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}