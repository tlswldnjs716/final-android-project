using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class amuseM : MonoBehaviour
{
    Button num10;
    public int a;
    //public GameObject num4;
    //public GameObject Q;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick10()
    {
        a = 1;
        Debug.Log(a);
    }
    public void OnClick11()
    {
        a = 0;
        Debug.Log(a);
    }
    public void OnClick12()
    {
        a = 0;
        Debug.Log(a);
    }
    public void ChangeGameScene()
    {
        if (GameObject.Find("num10").GetComponent<amuseM>().a == 1)
        {
            SceneManager.LoadScene("amuseMAO");
        }
        else
        {
            SceneManager.LoadScene("amuseMAW");
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
