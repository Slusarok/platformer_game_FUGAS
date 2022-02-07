using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPlayerName : MonoBehaviour
{
    public TMP_Text Text;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Player Name"))
        {
            Text.text = "Enjoy the game, " + PlayerPrefs.GetString("Player Name");
        }
        else
            Text.text = "Enjoy the game, Player";
    }

}