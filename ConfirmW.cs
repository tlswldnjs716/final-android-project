using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConfirmW : MonoBehaviour {
    public InputField InputField;
    WWW www;
    WWW www2;
    public bool isDownloaded = false;
    void Start () {
        StartCoroutine(Send());
    }
    IEnumerator Send() {
        isDownloaded = false;
        www = new WWW("https://www.jiwon7.com/api/coupons");
        yield return www;
        if (www.isDone) isDownloaded = true;
    }
    IEnumerator Sendok()
    {
        isDownloaded = false;
        www2 = new WWW("https://www.jiwon7.com/api/coupons/sppn0410");
        yield return www2;
        if (www.isDone) isDownloaded = true;
    }
    // Update is called once per frame
    void Update () {
        /*
        if (isDownloaded == false)
            Debug.Log(www.progress * 100);
        else
            Debug.Log(www);
        */
        //Debug.Log(www.text);
    }

    public void ChangeGameScene()
    {
        if (isDownloaded == true)
        {
            string first = www.text.Substring(8, 8);
            if (first == InputField.text)
            {
                SceneManager.LoadScene("ConfirmOk");
                StartCoroutine(Sendok());
            }
            else
            {
                SceneManager.LoadScene("ConfirmW");
            }
        }
    }
}

