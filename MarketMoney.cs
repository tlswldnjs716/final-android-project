using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MarketMoney : MonoBehaviour {
    public int b1 = 0;
    //public int b2 = 0;
    public int g1 = 0;
   //100원
    public int hcoin = 0;
    //500원
    public int fhcoin = 0;
    //50원
    //public int fiftycoin = 0;
    //10원
    //public int tencoin = 0;
    void Start () {
    }
    // Update is called once per frame
    void Update()
    {
        //BLUE.gameObject.SetActive(false);
        IEnumerable<TrackableBehaviour> tbs = TrackerManager.Instance.GetStateManager().GetActiveTrackableBehaviours();
        foreach (TrackableBehaviour tb in tbs)
        {
            Debug.Log("TrackableName: " + tb.name);
            GameObject blue = GameObject.Find("1000");
            if (tb.name == "mart")
            {
                blue.SetActive(true);
                //Debug.Log("찾았다");
            }
            //멈추고
            if (tb.name == "10000")
            {
                if (g1 < 1)
                {
                    g1++;
                }
                Debug.Log("g1" + g1 + "입니다");
            }
            //int b1 = 0;
            if (tb.name == "1000")
            {
                if (b1 < 1)
                {
                    b1++;
                }
                Debug.Log("b1" + b1 + "입니다");
            }
            if (tb.name == "100")
            {
                if (hcoin < 1)
                {
                    hcoin++;
                }
                Debug.Log("hcoin" + hcoin + "입니다");
            }
            if (tb.name == "500")
            {
                if (fhcoin < 1)
                {
                    fhcoin++;
                }
                Debug.Log("fhcoin" + fhcoin + "입니다");
            }
            /*
            if (tb.name == "50")
            {
                if (fiftycoin < 1)
                {
                    fiftycoin++;
                }
                Debug.Log("fiftycoin" + fiftycoin + "입니다");
            }
            */
            /*
            if (tb.name == "10")
            {
                if (tencoin < 1)
                {
                   tencoin++;
                }
                Debug.Log("tencoin" + tencoin + "입니다");
            }
            */
            /*
            if (tb.name == "2000")
            {
                //Debug.Log("찾았다");
                if (b2 < 1)
                {
                    b2++;
                }
                Debug.Log("b2" + b2 + "입니다");
            }
            */
            /*
            //int b2 = 0;
            if (tb.name == "2000")
            {
                //Debug.Log("찾았다");
                if (b2 < 1)
                {
                    b2++;
                }
                Debug.Log("b2" + b2 + "입니다");
            }
            */
        }
    }
    public void ChangeGameScene()
    {
        if (b1 == 1)
        {
            SceneManager.LoadScene("MoneyAO");
        }
        else
        {
            SceneManager.LoadScene("moneyAW");
        }
    }
    public void MoneyM()
    {
        if (b1 + g1 == 2)
        {
            SceneManager.LoadScene("moneyMAO");
        }
        else
        {
            SceneManager.LoadScene("moneyMAW");
        }
    }
    public void MoneyH()
    {
        if (b1 + hcoin + fhcoin == 3)
        {
            SceneManager.LoadScene("moneyHAO");
        }
        else
        {
            SceneManager.LoadScene("moneyHAW");
        }
    }
}
  


