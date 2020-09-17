using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitAnswer : MonoBehaviour
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
        //GameObject bag = GameObject.Find("bag");

        //바나나 찾기
        GameObject banana = GameObject.Find("banana");
        //Debug.Log(banana.transform.position);
        //GameObject carrot = GameObject.Find("Carrot");
        //바나나 +1
        //좌표구해서 범위표시
        //Debug로 찍었을 때 좌표임
        int b = 0;
        if (10 <= banana.transform.position.x && banana.transform.position.x <= 25)
        {
            if (-15 <= banana.transform.position.y && banana.transform.position.y <= -10.5)
            {
                if (b == 0)
                {
                    b++;
                }
            }
        }
        if (b == 1)
        {
            SceneManager.LoadScene("AO");
        }
        else
        {
            SceneManager.LoadScene("AW");
        }
        //바나나가 바구니에 들어갔는지 확인
        //과일좌표가 바구니 좌표와 비슷할 때만 바나나 상수 +1, 당근 상수 +3

        //정답을 눌렀을 때 바나나 상수 1, 당근 상수 3이면 맞았습니다.

        //상수가 다르면, 틀렸습니다.
        /*
        int b = 0;
        if(당근과일의 좌표 == 장바구니의 좌표){
            b++;
            Debug.Log(b);
        }
        if (a=1&&b=3) {
            SceneManager.LoadScene("AO");
        }
        */
    }
    public void GameM()
    {
        //GameObject bag = GameObject.Find("bag");

        //바나나 찾기
        GameObject banana = GameObject.Find("banana");
        GameObject apple1 = GameObject.Find("apple1");
        GameObject apple2 = GameObject.Find("apple2");
        GameObject apple3 = GameObject.Find("apple3");
        //Debug.Log(banana.transform.position);
        //GameObject carrot = GameObject.Find("Carrot");
        //바나나 +1
        //좌표구해서 범위표시
        //Debug로 찍었을 때 좌표임
        int b = 0;
        if (10 <= banana.transform.position.x && banana.transform.position.x <= 25)
        {
            if (-15 <= banana.transform.position.y && banana.transform.position.y <= -10.5)
            {
                if (b == 0)
                {
                    b++;
                }
            }
        }
        int a1 = 0;
        if (10 <= apple1.transform.position.x && apple1.transform.position.x <= 25)
        {
            if (-15 <= apple1.transform.position.y && apple1.transform.position.y <= -10.5)
            {
                if (a1 == 0)
                {
                    a1++;
                }
            }
        }
        int a2 = 0;
        if (10 <= apple2.transform.position.x && apple2.transform.position.x <= 25)
        {
            if (-15 <= apple2.transform.position.y && apple2.transform.position.y <= -10.5)
            {
                if (a2 == 0)
                {
                    a2++;
                }
            }
        }
        int a3 = 0;
        if (10 <= apple3.transform.position.x && apple3.transform.position.x <= 25)
        {
            if (-15 <= apple3.transform.position.y && apple3.transform.position.y <= -10.5)
            {
                if (a3 == 0)
                {
                    a3++;
                }
            }
        }
        if (b+a1+a2+a3 == 4)
        {
            SceneManager.LoadScene("MartObjectMAO");
        }
        else
        {
            SceneManager.LoadScene("MartObjectMAW");
        }
    }
    public void GameH()
    {
        //GameObject bag = GameObject.Find("bag");

        GameObject apple1 = GameObject.Find("apple1");
        GameObject apple2 = GameObject.Find("apple2");
        GameObject apple3 = GameObject.Find("apple3");
        //Debug.Log(banana.transform.position);
        //GameObject carrot = GameObject.Find("Carrot");
        //바나나 +1
        //좌표구해서 범위표시
        //Debug로 찍었을 때 좌표임
        int a1 = 0;
        if (10 <= apple1.transform.position.x && apple1.transform.position.x <= 25)
        {
            if (-15 <= apple1.transform.position.y && apple1.transform.position.y <= -10.5)
            {
                if (a1 == 0)
                {
                    a1++;
                }
            }
        }
        int a2 = 0;
        if (10 <= apple2.transform.position.x && apple2.transform.position.x <= 25)
        {
            if (-15 <= apple2.transform.position.y && apple2.transform.position.y <= -10.5)
            {
                if (a2 == 0)
                {
                    a2++;
                }
            }
        }
        int a3 = 0;
        if (10 <= apple3.transform.position.x && apple3.transform.position.x <= 25)
        {
            if (-15 <= apple3.transform.position.y && apple3.transform.position.y <= -10.5)
            {
                if (a3 == 0)
                {
                    a3++;
                }
            }
        }
        if (a1 + a2 == 2 && a3 ==0 || a1 + a3 == 2 && a2 == 0|| a2+a3 == 2 && a1 == 0)
        {
            SceneManager.LoadScene("MartObjectHAO");
        }
        else
        {
            SceneManager.LoadScene("MartObjectHAW");
        }
    }
}
