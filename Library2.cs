using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Library2 : MonoBehaviour
{
    Button one;
    Button two;
    public int a;
    public int b;
    public int c;
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
    public void OnClickpen()
    {
        a = 0;
        Debug.Log(a);
    }
    public void OnClickone()
    {
        a = 1;
        Debug.Log(a);
        //ClickButton(num4);
    }
    public void OnClick3()
    {
        a = 0;
        Debug.Log(a);
    }
    public void ChangeGameScene()
    {
        if (GameObject.Find("one").GetComponent<Library2>().a == 1)
        {
            SceneManager.LoadScene("Library2AO");
        }
        else
        {
            SceneManager.LoadScene("Library2AW");
        }
    }
    ////////중급단계 구현/////////
    public void OnClickbook()
    {
        b = 0;
        //Debug.Log(b);
    }
    public void OnClicktwo()
    {
        b = 1;
        //Debug.Log(b);
        //ClickButton(num4);
    }
    public void OnClick6()
    {
        b = 0;
        //Debug.Log(a);
    }
    public void onetoonegameM()
    {
        if (GameObject.Find("two").GetComponent<Library2>().b == 1)
        {
            SceneManager.LoadScene("Library2MAO");
        }
        else
        {
            SceneManager.LoadScene("Library2MAW");
        }
    }
    ////////고급단계 구현/////////
    public void OnClickSix()
    {
        c = 1;
        //Debug.Log(b);
    }
    public void OnClickTen()
    {
        c = 0;
        //Debug.Log(b);
        //ClickButton(num4);
    }
    public void OnClickFlower()
    {
        c = 0;
        //Debug.Log(a);
    }
    public void onetoonegameH()
    {
        if (GameObject.Find("six").GetComponent<Library2>().c == 1)
        {
            SceneManager.LoadScene("library2HAO");
        }
        else
        {
            SceneManager.LoadScene("library2HAW");
        }
    }
}
