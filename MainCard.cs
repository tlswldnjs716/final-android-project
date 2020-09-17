using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour {
    [SerializeField] private SceneController controller;
    //뒷면->앞면
    [SerializeField] private GameObject Card_Back;
    //두번째 카드 선택 후 같은지 확인하는 함수 실행
    public void OnMouseDown()
    {
        if (Card_Back.activeSelf && controller.canReveal)
        {
            Card_Back.SetActive(false);
            controller.CardRevealed(this);
        }
    }
   
    private int _id;
    public int id
    {
        get { return _id; }
    }
    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreveal()
    {
        Card_Back.SetActive(true); 
    }
}
