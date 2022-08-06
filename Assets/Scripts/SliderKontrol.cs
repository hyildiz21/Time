using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderKontrol : MonoBehaviour
{
    Slider slider;

    public void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1f;
    }

    /// <summary>
    /// bu metot z�plama ba�larken dururken ve s�f�rlan�rken �a�r�lacak
    /// </summary>
    /// <param name="maxDeger"></param>
    /// <param name="gecerliDeger"></param>
    public void sliderDeger(float maxDeger, float gecerliDeger)
    {
        float sliderDeger = maxDeger - gecerliDeger;
        slider.maxValue = maxDeger;
        slider.value = sliderDeger;
    }
}
