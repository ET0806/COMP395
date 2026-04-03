using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenuFox : MonoBehaviour
{
    public Slider slider;
    public static int foxNumber;
    public TextMeshProUGUI foxNumberText;
    //slider
    // Update is called once per frame
    void Update()
    {
        foxNumber = (int)slider.value;
        foxNumberText.text= slider.value.ToString();

    }
}
