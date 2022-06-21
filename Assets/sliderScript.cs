using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class sliderScript : MonoBehaviour
{
    public void updateInput()
    {
        GameObject inp = GameObject.Find("InputField");
        inp.GetComponent<InputField>().text = this.GetComponent<Slider>().value.ToString();
    }

    public void updateSlider()
    {
        GameObject inp = GameObject.Find("InputField");
        int inputNum = int.Parse(inp.GetComponent<InputField>().text);
        if (inputNum < this.GetComponent<Slider>().minValue)
        {
            inputNum = (int) this.GetComponent<Slider>().minValue;
        }
        if (inputNum > this.GetComponent<Slider>().maxValue)
        {
            inputNum = (int) this.GetComponent<Slider>().maxValue;
        }
        this.GetComponent<Slider>().value = inputNum;
        updateInput();
    }
}
