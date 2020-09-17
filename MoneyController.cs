using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MoneyController : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Money");
    }
    public void GameM()
    {
        SceneManager.LoadScene("moneyM");
    }
    public void GameH()
    {
        SceneManager.LoadScene("moneyH");
    }
}
