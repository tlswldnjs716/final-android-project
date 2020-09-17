using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Hint");
    }
    public void ChangeGameSceneM()
    {
        SceneManager.LoadScene("MartObjectMHint");
    }
    public void ChangeGameSceneH()
    {
        SceneManager.LoadScene("MartObjectHHint");
    }
}
