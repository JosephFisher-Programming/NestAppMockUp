using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PatInfo", menuName = "ScriptableObjects/PatientTemplate")]
public class PatientInfo : ScriptableObject
{
    public string patName;
    public string transportTeam;
    public string transportOrigin;
    public string ETA;
    public string ExistingCondition;
    
    [Header("Vitals")]
    public string heartRate;
    public string bloodOxy;
    public string Resp;
    public string bloodPressure;
    public string CO2;

    [Header("Chart")]
    public string GestAge;
    public string Weight;
    public string Reason;
    public string Reflexes;
    public string MuscleTone;
    public string SeizureActivity;
    public string RespDistress;
    [TextArea]
    public string [] MedicationInfo;
}
