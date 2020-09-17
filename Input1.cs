using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input1 : MonoBehaviour {
    public GameObject Placeholder;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) {
            Placeholder.SetActive(false);
        }
	}
}
