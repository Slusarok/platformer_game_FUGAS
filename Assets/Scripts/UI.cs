using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour

{
    public static int lastLvl = 2;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        if(scene.buildIndex > 3)
        {
            lastLvl = scene.buildIndex;
            Debug.Log("Max lvl ='" + scene.name + "'.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ProgramExit()
    {
        Application.Quit();
    }
    public void ListLevel()
    {
        SceneManager.LoadScene("PickLVL", LoadSceneMode.Single);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void Lvl_1()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PositionPlayer", 0);
    }
    public void Lvl_2()
    {
        SceneManager.LoadScene("LVL_1", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PositionPlayer", 0);
    }
    public void Lvl_3()
    {
        SceneManager.LoadScene("LVL_2", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PositionPlayer", 0);
    }
    public void Lvl_4()
    {
        SceneManager.LoadScene("LVL_3", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PositionPlayer", 0);
    }
    public void Lvl_5()
    {
        SceneManager.LoadScene("LVL_4", LoadSceneMode.Single);
        PlayerPrefs.SetInt("PositionPlayer", 0);
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void MemoryOFlvl()
    {
        SceneManager.LoadScene(lastLvl, LoadSceneMode.Single); 
    }
    public void Ladderboard()
    {
        SceneManager.LoadScene("Ladderboard", LoadSceneMode.Single);
    }
    public void Rename()
    {
        SceneManager.LoadScene("InputName", LoadSceneMode.Single);
    }
    //SceneManager.LoadScene("LVL_1", LoadSceneMode.Single);
}
