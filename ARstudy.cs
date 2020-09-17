using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARstudy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("ar study");
    }
    public void ChangeGameSceneM()
    {
        SceneManager.LoadScene("MartObjectM");
    }
    public void ChangeGameSceneH()
    {
        SceneManager.LoadScene("MartObjectH");
    }
}
