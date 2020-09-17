using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class passtuto : MonoBehaviour
{

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(65);
        SceneManager.LoadScene("name");
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
