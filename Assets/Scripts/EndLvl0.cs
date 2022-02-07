using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLvl0 : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc2d;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        rb = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 0);
            SceneManager.LoadScene("LVL_1", LoadSceneMode.Single);
        }
        if (collision.gameObject.CompareTag("End1"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 0);
            SceneManager.LoadScene("LVL_2", LoadSceneMode.Single);
        }
        if (collision.gameObject.CompareTag("End2"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 0);
            SceneManager.LoadScene("LVL_3", LoadSceneMode.Single);
        }
        if (collision.gameObject.CompareTag("End3"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 0);
            SceneManager.LoadScene("LVL_4", LoadSceneMode.Single);
        }
        if (collision.gameObject.CompareTag("End4"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 0);
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }

    }
}
