using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AMstudy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeGameScene()
    {
            SceneManager.LoadScene("amuse");
    }
    public void GoAmuseM()
    {
        SceneManager.LoadScene("amuseM");
    }
    public void GoAmuseH()
    {
        SceneManager.LoadScene("amuseH");
    }
}
