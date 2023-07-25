using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueSlider : MonoBehaviour
{
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void SetMaxBar (int MaxBar)
    {
        slider.maxValue = MaxBar;
    }

    public void SetCurrentBar (int CurrentBar)
    {
        slider.value = CurrentBar;
    }
}
