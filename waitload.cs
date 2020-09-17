using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class waitload : MonoBehaviour
{

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("confirm");
    }
    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1920, 1200, true);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(NextScene());
    }
}
