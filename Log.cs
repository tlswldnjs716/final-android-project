using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Log : MonoBehaviour {

    public Text log;
    WWW www;
    public bool isDownloaded = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(Send());
    }

    IEnumerator Send()
    {
        isDownloaded = false;
        www = new WWW("https://pokeapi.co/api/v2/pokemon/ditto/");
        yield return www;
        if (www.isDone) isDownloaded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isDownloaded == true)
        {
            log.text = www.text;
        }
    }

}
