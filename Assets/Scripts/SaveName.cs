using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SaveName : MonoBehaviour
{
    public TMP_InputField InputField;

    public void AddingName()
    {
        PlayerPrefs.SetString("Player Name", InputField.text);
        SceneManager.LoadScene(1);
    }
}