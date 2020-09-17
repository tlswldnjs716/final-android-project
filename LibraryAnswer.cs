using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibraryAnswer : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChangeGameScene()
    {
        GameObject hour = GameObject.Find("hour");
        GameObject minute = GameObject.Find("minute");
        int b = 0;
        if (14 <= hour.transform.eulerAngles.z && hour.transform.eulerAngles.z <= 27)
        {
            if (-10.5 <= minute.transform.eulerAngles.z && minute.transform.eulerAngles.z <= 5)
            {
                if (b == 0)
                {
                    b++;
                }
            }
        }
        if (b == 1)
        {
            SceneManager.LoadScene("Library1AO");
        }
        else
        {
            SceneManager.LoadScene("Library1AW");
        }
    }
    public void GameM()
    {
        GameObject hour = GameObject.Find("hour");
        GameObject minute = GameObject.Find("minute");
        Debug.Log(hour.transform.eulerAngles.z);
        Debug.Log(minute.transform.eulerAngles.z);
        int b = 0;
        if (45 <= hour.transform.eulerAngles.z && hour.transform.eulerAngles.z <= 60)
        {
            if (300 <= minute.transform.eulerAngles.z && minute.transform.eulerAngles.z <= 315)
            {
                if (b == 0)
                {
                    b++;
                }
            }
        }
        if (b == 1)
        {
            SceneManager.LoadScene("LibraryMAO");
        }
        else
        {
            SceneManager.LoadScene("LibraryMAW");
        }
    }
    public void GameH()
    {
        GameObject hour = GameObject.Find("hour");
        GameObject minute = GameObject.Find("minute");
        Debug.Log(hour.transform.eulerAngles.z);
        Debug.Log(minute.transform.eulerAngles.z);
        int b = 0;
        if (95 <= hour.transform.eulerAngles.z && hour.transform.eulerAngles.z <= 115)
        {
            if (98 <= minute.transform.eulerAngles.z && minute.transform.eulerAngles.z <= 105)
            {
                if (b == 0)
                {
                    b++;
                }
            }
        }
        if (b == 1)
        {
            SceneManager.LoadScene("LibraryHAO");
        }
        else
        {
            SceneManager.LoadScene("LibraryHAW");
        }
    }
}
