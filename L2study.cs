using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L2study : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("library2");
    }
    public void GameM()
    {
        SceneManager.LoadScene("library2M");
    }
    public void GameH()
    {
        SceneManager.LoadScene("library2H");
    }
}
