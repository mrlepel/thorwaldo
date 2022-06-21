using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterQuestion : MonoBehaviour
{
    public string[] randomQuestionArray = {"Placeholder"};
    public Text questionText;

    
    int randomInt;

    void Start()
    {
        randomInt = Random.Range(0, randomQuestionArray.Length);
        Debug.Log("pog");
    }
}