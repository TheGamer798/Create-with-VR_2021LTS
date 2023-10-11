using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DigitalClock : MonoBehaviour
{
    private TextMeshPro textDisplay;
    string hour, minute, second;
    DateTime timeNow;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = DateTime.Now;
        hour = timeNow.Hour.ToString().PadLeft(2, '0');
        minute = timeNow.Minute.ToString().PadLeft(2, '0');
        second = timeNow.Second.ToString().PadLeft(2, '0');

        textDisplay.text = hour + ":" + minute + ":" + second;
    }
}
