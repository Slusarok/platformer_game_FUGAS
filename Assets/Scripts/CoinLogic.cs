using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinLogic : MonoBehaviour
{
    public Text ScoreInLvl, globalScore;
    public int ScoreInLvlCounter;
    public static int globalScoreCounter;
    Rigidbody2D rb;
    Animator animator;
    BoxCollider2D bc2d;
    Collider2D ñ2d;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreInLvl.text = "Coins pickup in lvl:" + ScoreInLvlCounter;
        globalScore.text = "All your coins:" + globalScoreCounter;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            ScoreInLvlCounter += 1;
            globalScoreCounter += 1;
            Destroy(collision.gameObject);
        }
    }
}
