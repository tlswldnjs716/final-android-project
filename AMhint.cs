using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AMhint : MonoBehaviour
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
        SceneManager.LoadScene("AmuseHint");
    }

    public void GoAmuseMHint()
    {
        SceneManager.LoadScene("AmuseMHint");
    }
    public void GoAmuseHHint()
    {
        SceneManager.LoadScene("AmuseHHint");
    }
}
