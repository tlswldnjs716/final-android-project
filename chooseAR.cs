using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class chooseAR : MonoBehaviour
{
    Button amuse;
    Button mart;
    Button library;
    Button toy;
    public int a;
    public int m;
    public int l;
    public int t;
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
    public void OnClickamuse()
    {
        a = 1;
        Debug.Log(a);
    }
    public void OnClickmart()
    {
        m = 1;
        Debug.Log(m);
        //ClickButton(num4);
    }
    public void OnClicktoy()
    {
        t = 1;
        Debug.Log(t);
    }
    public void OnClicklibrary()
    {
        l = 1;
        Debug.Log(l);
    }
    //게임유형선택으로
    public void ChangeGameScene()
    {
        if (GameObject.Find("amuse").GetComponent<chooseAR>().a == 1)
        {
            SceneManager.LoadScene("TypeAmusement");
        }
        if (GameObject.Find("mart").GetComponent<chooseAR>().m == 1)
        {
            SceneManager.LoadScene("TypeMart");
        }
        if (GameObject.Find("library").GetComponent<chooseAR>().l == 1)
        {
            SceneManager.LoadScene("TypeLibrary");
        }
        if (GameObject.Find("toy").GetComponent<chooseAR>().t == 1)
        {
            SceneManager.LoadScene("TypeToyland");
        }
    }
}
