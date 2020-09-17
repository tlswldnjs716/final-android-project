using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHint : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    //뒷면->앞면
    [SerializeField] private GameObject Card_Back;
    private GameObject clone;

    //두번째 카드 선택 후 같은지 확인하는 함수 실행
    public void OnMouseDown()
    {
        if (Card_Back.activeSelf && controller.canReveal)
        {
            Card_Back.SetActive(false);
            if (GameObject.Find("MainCard(Clone)") == true)
            {
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
                clone = GameObject.Find("Asset 7");
                clone.SetActive(false);
            }
        }

    }
    public void Unreveal()
    {
        Card_Back.SetActive(true);
    }
}
