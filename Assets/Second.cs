using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Second : MonoBehaviour
{

    private float Timeremaining;
    private const float TimeMax = 120f;
    public Slider SliderTime;
    public Button Click;
    public GameObject PanellowerRight;

    public void ClickButton()
    {
        
        Timeremaining = TimeMax;
        PanellowerRight.SetActive (false);
    }

        
    void Update()
    {
        SliderTime.value = CalculateSliderValue();
        if (Timeremaining <= 0)
        {
            Timeremaining = 0;
        }
        else if (Timeremaining > 0)
        {
            Timeremaining -= Time.deltaTime;
        }
        if (0 <( SliderTime.value) && (SliderTime.value) < 30 )
        {
            PanellowerRight.SetActive (true);
        }
    }
    float CalculateSliderValue()
    {
       
        return (TimeMax - Timeremaining);
    }
}
