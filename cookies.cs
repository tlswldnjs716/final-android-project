using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookies : MonoBehaviour
{
    public GameObject cookiecheck;
    public Text score;

    // Use this for initialization
    void Start()
    {
        //이상하게 2배네..
        int count = 1;
        PlayerPrefs.SetInt("count", PlayerPrefs.GetInt("count")+count);
        //PlayerPrefs.SetInt("count", PlayerPrefs.GetInt("count")/2);
        //print(PlayerPrefs.GetInt("score"));
    }
    void Update()
    {
        PlayerPrefs.SetInt("score", 10);
        score.text = PlayerPrefs.GetInt("score").ToString();
        //score.text = PlayerPrefs.GetInt("score").ToString();
    }
}

