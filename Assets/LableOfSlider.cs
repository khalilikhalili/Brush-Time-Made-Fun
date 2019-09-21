using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Timeline;

public class LableOfSlider : MonoBehaviour
{


    private string formatText = "{0}" ;
    //private string formattext = "{0}";
    private TextMeshProUGUI Tmprotext;
    [SerializeField]
    //[Tooltip("The text shown will be formatted using this string.  {0} is replaced with the actual value")]

    // Start is called before the first frame update
    void Start()
    {
        Tmprotext = GetComponent<TextMeshProUGUI>();
        
        GetComponentInParent<Slider>().onValueChanged.AddListener(HandleValueChanged);
    }

    private void HandleValueChanged(float value)
    {

        if (0<value && value<=30)
        {
            Tmprotext.text = string.Format(formatText, (value));
        }

        else if (30 < value && value <= 60)
        {
            Tmprotext.text = string.Format(formatText, (value-30));
        }
        else if (60 < value && value <= 90)
        {
            Tmprotext.text = string.Format(formatText, (value - 60));
        }
        else if (90 < value && value <= 120)
        {
            Tmprotext.text = string.Format(formatText, (value - 90));
        }


        // Tmprotext.text = string.Format(formatText, (value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
