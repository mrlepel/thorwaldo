using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuestion : MonoBehaviour
{
    public string[] randomQuestionArray = {"Placeholder"};
    public Text questionText; 

    // Start is called before the first frame update
    void Start()
    {
        int randomInt = Random.Range(0, randomQuestionArray.Length);
        questionText.text = randomQuestionArray[randomInt];
    }
}
