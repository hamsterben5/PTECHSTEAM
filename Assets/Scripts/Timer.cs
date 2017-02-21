using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text counterText;

    public float seconds, minutes;


    void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }


    void Update()
    {
        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}

