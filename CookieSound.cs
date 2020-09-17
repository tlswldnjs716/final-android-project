using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSound : MonoBehaviour {

    public AudioSource CookieAudio;

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void PlayCE()
    {
        CookieAudio.Play();
    }
}
