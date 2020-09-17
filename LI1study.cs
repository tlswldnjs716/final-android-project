using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LI1study : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("library");
    }
    public void ChangeGameM()
    {
        SceneManager.LoadScene("libraryM");
    }
    public void ChangeGameH()
    {
        SceneManager.LoadScene("libraryH");
    }


}
