using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatientScreen : MonoBehaviour
{
    PatientInfo curPatient;
    public Text patName, medCondition, heartRate, 
    bloodOxy, resp, bloodPressure, CO2, chartName, gestAge, 
    weight, reason, reflexes, muscleTone, seizureActivity, respDistress;

    private void refreshValues()
    {
        patName.text = curPatient.patName;
        medCondition.text = curPatient.Reason;
        heartRate.text = curPatient.heartRate;
        bloodOxy.text = curPatient.bloodOxy;
        resp.text = curPatient.Resp;
        bloodPressure.text = curPatient.bloodPressure;
        CO2.text = curPatient.CO2;
        chartName.text = curPatient.patName;
        gestAge.text = curPatient.GestAge;
        weight.text = curPatient.Weight;
        reason.text = curPatient.Reason;
        reflexes.text = curPatient.Reflexes;
        muscleTone.text = curPatient.MuscleTone;
        seizureActivity.text = curPatient.SeizureActivity;
        respDistress.text = curPatient.RespDistress;
    }

    public void AssignPatient(PatientInfo newPat)
    {
        curPatient = newPat;
        refreshValues();
    }
}
