using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameClose()
    {
        Application.Quit();
        Debug.Log("is quitting");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
