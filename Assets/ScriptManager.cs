using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptManager : MonoBehaviour
{
    private float Timeremaining;
    private const float TimeMax = 120f;
    public Slider SliderTime;
    public Button Click;
    public GameObject PanellowerRight;
    public GameObject PanelUpperRight;
    public GameObject PanellowerLeft;
    public GameObject PanelUpperLeft;
    private bool LRHandled = true;
    private bool URHandled = true;
    private bool ULHandled = true;
    private bool LLHandled = true;

    public void ClickButton()
    {
        // Timeremaining = 120;

        Timeremaining = TimeMax;
        // PanellowerRight.SetActive(false);

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


        if (LRHandled && 0 < (SliderTime.value) && (SliderTime.value) < 30)
        {
            LRHandled = false;
            //PanellowerRight.SetActive(true);
            PanelUpperRight.SetActive(false);
            PanelUpperLeft.SetActive(false);
            PanellowerLeft.SetActive(false);
            StartCoroutine(BlinkLR(30.0f));


          

        }
        else if (URHandled && 30 < (SliderTime.value) && (SliderTime.value) < 60)
        {
            PanellowerRight.transform.localScale = new Vector3(0, 0, 0);
            LRHandled = false;
            URHandled = false;
            //PanellowerRight.SetActive(false);
            //Debug.Log("first arrow");
            // PanelUpperRight.SetActive(true);
            PanelUpperLeft.SetActive(false);
            PanellowerLeft.SetActive(false);
            StartCoroutine(BlinkUR(30.0f));

            
        }
        else if (ULHandled && 60 < (SliderTime.value) && (SliderTime.value) < 90)
        {
            LRHandled = false;
            URHandled = false;
            ULHandled = false;
            PanelUpperRight.transform.localScale = new Vector3(0, 0, 0);
            PanellowerRight.SetActive(false);
            PanelUpperRight.SetActive(false);
           // PanelUpperLeft.SetActive(true);
            PanellowerLeft.SetActive(false);
            StartCoroutine(BlinkUL(30.0f));
        }
        else if (LLHandled && 90 < (SliderTime.value) && (SliderTime.value) < 120)
        {
            PanelUpperLeft.transform.localScale = new Vector3(0, 0, 0);
            LRHandled = false;
            URHandled = false;
            ULHandled = false;
            LLHandled = false;
            PanellowerRight.SetActive(false);
            PanelUpperRight.SetActive(false);
            PanelUpperLeft.SetActive(false);
            //PanellowerLeft.SetActive(true);
            StartCoroutine(BlinkLL(30.0f));
        }



    }

    float CalculateSliderValue()
    {
        // return (Timeremaining / TimeMax) ;
        return (TimeMax - Timeremaining);
    }



    public IEnumerator BlinkLR(float waitTime)
    {
        var endTime = Time.time + waitTime;
        while (Time.time < endTime)
        {
            PanellowerRight.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            PanellowerRight.SetActive(true);
            yield return new WaitForSeconds(0.2f);

        }
    }
    public IEnumerator BlinkUR(float waitTime)
    {
        var endTime = Time.time + waitTime;
        while (Time.time < endTime)
        {
            PanelUpperRight.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            PanelUpperRight.SetActive(true);
            yield return new WaitForSeconds(0.2f);

        }
    }

    public IEnumerator BlinkUL(float waitTime)
    {
        var endTime = Time.time + waitTime;
        while (Time.time < endTime)
        {
            PanelUpperLeft.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            PanelUpperLeft.SetActive(true);
            yield return new WaitForSeconds(0.2f);

        }
    }

    public IEnumerator BlinkLL(float waitTime)
    {
        var endTime = Time.time + waitTime;
        while (Time.time < endTime)
        {
            PanellowerLeft.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            PanellowerLeft.SetActive(true);
            yield return new WaitForSeconds(0.2f);

        }
        PanellowerLeft.SetActive(false);

    }

   /* public IEnumerator Blink(float waitTime, GameObject panel)
    {
        var endTime = Time.time + waitTime;
        while (Time.time <= endTime)
        {
            panel.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            panel.SetActive(true);
            yield return new WaitForSeconds(0.2f);

        }
    }*/

  
}