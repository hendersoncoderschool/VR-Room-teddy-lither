using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class clock_time : MonoBehaviour
{

    GameObject hourHand;
    GameObject minuteHand;
    GameObject secondHand;
    // Start is called before the first frame update
    void Start()
    {
        hourHand = transform.Find("Clock_Analog_A_Hour").gameObject;
        minuteHand = transform.Find("Clock_Analog_A_Minute").gameObject;
        secondHand = transform.Find("Clock_Analog_A_Second").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime Moment = DateTime.Now;

        hourHand.transform.localRotation = Quaternion.Euler((Moment.Hour*30f), 0f, 0f);
        minuteHand.transform.localRotation = Quaternion.Euler((Moment.Minute * 6f), 0f, 0f);
        secondHand.transform.localRotation = Quaternion.Euler((Moment.Second* 6f), 0f, 0f);
    }
}
