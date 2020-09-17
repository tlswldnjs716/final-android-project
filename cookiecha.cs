using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookiecha : MonoBehaviour
{
    public Text cookie;
    public Text lovenumber;
    public Text cookie0;
    public int cookiescore;
    public Image lovegage;
    public GameObject CookieButton;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        //number10
        PlayerPrefs.SetInt("score1", PlayerPrefs.GetInt("score") * PlayerPrefs.GetInt("count"));
        int cookiescore = PlayerPrefs.GetInt("score1");
        PlayerPrefs.Save();
        cookie.text = cookiescore.ToString();

        int love = PlayerPrefs.GetInt("love");
        lovenumber.text = love.ToString();
        PlayerHPbar();
        if (cookie.text == "0")
        {
            CookieButton = GameObject.Find("Button");
            CookieButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            CookieButton = GameObject.Find("Button");
            CookieButton.GetComponent<Button>().interactable = true;
        }
        //PlayerPrefs.SetInt("score", 0);
        //PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score")+10);
    }
    public void love()
    {
        PlayerPrefs.SetInt("love", PlayerPrefs.GetInt("score1"));
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("score", 0);
        //int love = PlayerPrefs.GetInt("love");
        //lovenumber.text = love.ToString();
    }
    public void PlayerHPbar()

    {
        int love = PlayerPrefs.GetInt("love");
        //0.1만큼 차오르게 함.
        lovegage.fillAmount = (love / 1000f);
        //lovegage.fillAmount = 0.1f;
        // (Time.deltaTime/100) * 

        //HpText.text = string.Format("HP {0}/100", HP);

    }
}
