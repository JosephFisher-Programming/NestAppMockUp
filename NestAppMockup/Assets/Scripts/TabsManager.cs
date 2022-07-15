using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsManager : MonoBehaviour
{
    PatientScreen patScreen;
    public PatientInfo p;
    [Header("MainMenuTabs")]
    public GameObject transportAssignedTab;
    public GameObject transportUnassignedTab;
    public GameObject HomeBanner;
    public GameObject PatBanner;
    [Header("PatientTabs")]
    public GameObject patVitals;
    public GameObject patEquipment;
    public GameObject patChart;
    public GameObject patNotes;


    // Start is called before the first frame update
    void Start()
    {
        patScreen = gameObject.GetComponent<PatientScreen>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            TurnOnPatTab("Vitals");
            SetPatInfo(p);
            HomeBanner.SetActive(false);
            PatBanner.SetActive(true);
        }
    }

    public void TurnOnAssigned()
    {
        if(PatBanner.activeInHierarchy)
        {
            PatBanner.SetActive(false);
            HomeBanner.SetActive(true);
        }
        turnOffTabs();
        transportAssignedTab.SetActive(true);
    }

    public void TurnOnUnassigned()
    {
        turnOffTabs();
        transportUnassignedTab.SetActive(true);
    }

    public void TurnOnPatTab(string s)
    {
        turnOffTabs();

        switch(s)
        {
            case "Vitals":
                patVitals.SetActive(true);
                break;

            case "Equipment":
                patEquipment.SetActive(true);
                break;

            case "Chart":
                patChart.SetActive(true);
                break;

            case "Notes":
                break;
        }
    }

    public void SetPatInfo(PatientInfo p)
    {
        patScreen.AssignPatient(p);
    }

    void turnOffTabs()
    {
        transportAssignedTab.SetActive(false);
        transportUnassignedTab.SetActive(false);
        patVitals.SetActive(false);
        patEquipment.SetActive(false);
        patChart.SetActive(false);
        patNotes.SetActive(false);
    }
}
