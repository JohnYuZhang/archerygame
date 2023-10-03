using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowChargeIndicator : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider SlideElement;
    void Start()
    {
        SlideElement.maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPower(int power)
    {
        SlideElement.value = power;
    }
}
