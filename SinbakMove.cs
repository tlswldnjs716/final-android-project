using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinbakMove : MonoBehaviour {

    AudioSource m_AudioSource;
    AudioClip m_AudioClip;
    AudioClip mm_AudioClip;

    private float movePower = 5f;
    Animator animator;
    Rigidbody rigid;

    public GameObject mentL;

    GameObject clock;
    GameObject hour;
    GameObject minute;
     //도서관_시계

    GameObject book;
    GameObject ex1;
    GameObject ex2;
    GameObject ex3;

    GameObject flower;
    GameObject ex4;
    GameObject ex5;
    GameObject ex6;

    GameObject bookshelf;
    GameObject ex7;
    GameObject ex8;
    GameObject ex9;
    //도서관 일대일

    //public GameObject card; 
    // 장난감_카드게임

    public GameObject ferris;
    public GameObject num1,num2,num3;
    //놀이공원_규칙적기

    // Use this for initialization
    void Start () {

        m_AudioSource = GetComponent<AudioSource>();
        

        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        clock = GameObject.Find("clock");
        hour = GameObject.Find("hour");
        minute = GameObject.Find("minute");

        if (mentL != null)
        {
            mentL.SetActive(false);
        }


        //도서관_시계
        if (clock != null)
        {  
            clock.SetActive(false);
        }

        if (hour != null)
        {
            hour.SetActive(false);
        }

        if (minute != null)
        {
            minute.SetActive(false);
        }



        //도서관 일대일
        book = GameObject.Find("Asset 72");
        ex1 = GameObject.Find("pen");
        ex2 = GameObject.Find("one");
        ex3 = GameObject.Find("3");

        if (book != null)
        {
            book.SetActive(false);
        }

        if (ex1 != null)
        {
            ex1.SetActive(false);
        }

        if (ex2 != null)
        {
            ex2.SetActive(false);
        }

        if (ex3 != null)
        {
            ex3.SetActive(false); 
        }

        //도서관 일대일 2번째
        flower = GameObject.Find("Asset 103");
        ex4 = GameObject.Find("book");
        ex5 = GameObject.Find("two");
        ex6 = GameObject.Find("6");

        if (flower != null)
        {
            flower.SetActive(false);
        }

        if (ex4 != null)
        {
            ex4.SetActive(false);
        }

        if (ex5 != null)
        {
            ex5.SetActive(false);
        }

        if (ex6 != null)
        {
            ex6.SetActive(false);
        }

        //도서관 일대일 3번째
        bookshelf = GameObject.Find("Asset 116");
        ex7 = GameObject.Find("ten");
        ex8 = GameObject.Find("six");
        ex9 = GameObject.Find("flower");

        if (bookshelf != null)
        {
            bookshelf.SetActive(false);
        }

        if (ex7 != null)
        {
            ex7.SetActive(false);
        }

        if (ex8 != null)
        {
            ex8.SetActive(false);
        }

        if (ex9 != null)
        {
            ex9.SetActive(false);
        }

        // 장난감 _카드게임 
        //card = GameObject.Find("MainCard");
        /*if (card != null)
        {
            card.SetActive(false); 
        }*/


        //놀이공원 규칙// 안됨
        // ferris = GameObject.Find("ferris");
        if (ferris != null)
        {
            ferris.SetActive(false);
        }

        if (num1 != null)
        {
            num1.SetActive(false);
        }

        if (num2 != null)
        {
            num2.SetActive(false);
        }

        if (num3 != null)
        {
            num3.SetActive(false);
        }


        /*if (ferris.activeSelf == false)
        {
            Debug.Log("1");
        }
        else
        {
            Debug.Log("2");
        }*/
    }
	
	// Update is called once per frame
	void Update () {
        CharacterStart();
	}

    IEnumerator CoroutineTimeMF0()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeMF1()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeMF2()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeMM0()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        Destroy(m_AudioSource);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeMM1()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        Destroy(m_AudioSource);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeMM2()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7);
        Destroy(m_AudioSource);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeLC0()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(6);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeLC1()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(6);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeLC2()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeLO0()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeLO1()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeLO2()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeA0()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeA1()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator CoroutineTimeA2()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7);

        //After we have waited 5 seconds print the time again.
        animator.SetBool("IsTalkFinish", true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }



    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == ("banana0"))
            {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeMF0());
            /*if (m_AudioSource.time == true)
            {
                m_AudioSource.Play();
            }

            else if(m_AudioDlip. >= 4)
            {
                animator.SetBool("IsTalkFinish", true);
            }*/


            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");

            AnimatorStateInfo currInfo = animator.GetCurrentAnimatorStateInfo(0);
            //Debug.Log(currInfo.normalizedTime);
        }

        if (collision.collider.tag == ("banana1"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeMF1());
            /*if (m_AudioSource.time == true)
            {
                m_AudioSource.Play();
            }

            else if(m_AudioDlip. >= 4)
            {
                animator.SetBool("IsTalkFinish", true);
            }*/


            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");

            AnimatorStateInfo currInfo = animator.GetCurrentAnimatorStateInfo(0);
            //Debug.Log(currInfo.normalizedTime);
        }

        if (collision.collider.tag == ("banana2"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeMF2());
            /*if (m_AudioSource.time == true)
            {
                m_AudioSource.Play();
            }

            else if(m_AudioDlip. >= 4)
            {
                animator.SetBool("IsTalkFinish", true);
            }*/


            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");

            AnimatorStateInfo currInfo = animator.GetCurrentAnimatorStateInfo(0);
            //Debug.Log(currInfo.normalizedTime);
        }

        //마트 물건 찾기



        else if (collision.collider.tag == ("Counter0"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            
            StartCoroutine(CoroutineTimeMM0());


            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }

        else if (collision.collider.tag == ("Counter1"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            
            StartCoroutine(CoroutineTimeMM1());


            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }

        else if (collision.collider.tag == ("Counter2"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            
            StartCoroutine(CoroutineTimeMM2());


            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }

        //마트 돈 내기



        else if (collision.collider.tag == ("Clock0"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeLC0());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            clock.SetActive(true);
            hour.SetActive(true);
            minute.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }

        else if (collision.collider.tag == ("Clock1"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeLC1());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            clock.SetActive(true);
            hour.SetActive(true);
            minute.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }

        else if (collision.collider.tag == ("Clock2"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeLC2());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            clock.SetActive(true);
            hour.SetActive(true);
            minute.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }

        //도서관 시계



        else if (collision.collider.tag == ("Book"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeLO0());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            book.SetActive(true);
            ex1.SetActive(true);
            ex2.SetActive(true);
            ex3.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }


        else if (collision.collider.tag == ("Flower"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeLO1());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            flower.SetActive(true);
            ex4.SetActive(true);
            ex5.SetActive(true);
            ex6.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }
        else if (collision.collider.tag == ("bookshelf"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeLO2());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            bookshelf.SetActive(true);
            ex7.SetActive(true);
            ex8.SetActive(true);
            ex9.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
        }
        else if (collision.collider.tag == ("Card"))
        {
            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);

            //card.SetActive(true);
            mentL.SetActive(true);
            Debug.Log("충돌감지");
            SceneManager.LoadScene("Pairs1");
        }

        else if (collision.collider.tag == ("Ferris0"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeA0());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            ferris.SetActive(true);
            num1.SetActive(true);
            num2.SetActive(true);
            num3.SetActive(true);
            mentL.SetActive(true);

            Debug.Log("충돌감지");
        }

        else if (collision.collider.tag == ("Ferris1"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeA1());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            ferris.SetActive(true);
            num1.SetActive(true);
            num2.SetActive(true);
            num3.SetActive(true);
            mentL.SetActive(true);

            Debug.Log("충돌감지");
        }

        else if (collision.collider.tag == ("Ferris2"))
        {
            m_AudioClip = m_AudioSource.clip;
            m_AudioSource.Play();
            StartCoroutine(CoroutineTimeA2());

            movePower = 0.0f;
            transform.Rotate(0, 90, 0);
            animator.SetBool("IsCollision", true);
            ferris.SetActive(true);
            num1.SetActive(true);
            num2.SetActive(true);
            num3.SetActive(true);
            mentL.SetActive(true);

            Debug.Log("충돌감지");
        }

    }

    public void CharacterStart()
    {
        transform.position += Vector3.right * movePower * Time.deltaTime;
    }
}
