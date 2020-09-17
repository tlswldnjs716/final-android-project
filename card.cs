using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour {
    private GameObject clone;

    // Use this for initialization
    void Start () {
        if (GameObject.Find("ImageTarget") == false) {
            clone.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("ImageTarget") == true) {
            clone = GameObject.Find("MainCard(Clone)");
            clone.SetActive(true);
        }
        else
        {
            //clone.SetActive(false);
        }
    }
}
