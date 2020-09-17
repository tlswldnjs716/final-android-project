using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManagerScript : MonoBehaviour {

    public GameObject PanelQA;
    public GameObject PanelClause;
    public GameObject PanelDeveloper;

    // Use this for initialization
    void Start()
    {
        //Scroll.Setactive(false);
        PanelQA.SetActive(false);
        PanelClause.SetActive(false);
        PanelDeveloper.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PanelQAOnClick()
    {
        if (PanelQA != null)
        {
            PanelQA.SetActive(true);
        }

        PanelClause.SetActive(false);
        PanelDeveloper.SetActive(false);
    }

    public void PanelClauseOnClick()
    {
        if (PanelClause != null)
        {
            PanelClause.SetActive(true);
        }

        PanelDeveloper.SetActive(false);
        PanelQA.SetActive(false);
    }

    public void DeveloperOnClick()
    {
        if (PanelDeveloper != null)
        {
            PanelDeveloper.SetActive(true);
        }

        PanelQA.SetActive(false);
        PanelClause.SetActive(false);
    }
}
