using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class amuse : MonoBehaviour {
    Button num4;
    public int a;
    //public GameObject num4;
    //public GameObject Q;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }
    public void OnClick3()
    {
        a = 0;
        Debug.Log(a);
       }
    public void OnClick4()
    {
        a = 1;
        Debug.Log(a);
        //ClickButton(num4);
    }
    public void OnClick5()
    {
        a = 0;
        Debug.Log(a);
    }
    public void ChangeGameScene() {
        if(GameObject.Find("num4").GetComponent<amuse>().a == 1)
        {
            SceneManager.LoadScene("amuseAO");
        }
        else
        {
            SceneManager.LoadScene("amuseAW");
        }
    }
    /*
    public void ClickButton(GameObject target)
    {
        if (target == num4)
        {
            SceneManager.LoadScene("AO"); 
        }
        else
        {
            SceneManager.LoadScene("AW");
        }
    }
    */
}
