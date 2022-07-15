using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransportInfoAssigner : MonoBehaviour
{
    public PatientInfo patInfo;
    public Text patName, teamName, hospitalName, ETA, Condition;

    private void Start()
    {
        patName.text = patInfo.patName;
        teamName.text = patInfo.transportTeam;
        hospitalName.text = patInfo.transportOrigin;
        ETA.text = patInfo.ETA;
        Condition.text = patInfo.ExistingCondition;
    }
}
