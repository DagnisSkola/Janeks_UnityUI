using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ShowTextScript : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ūzstartēts");
    }

    int kadrs = 0;
    // Update is called once per frame
    void Update()
    {
        kadrs++;
        Debug.Log(kadrs);
    }
    */

    string text;
    int year, age;
    public GameObject inputField;
    public GameObject inputFieldAge;
    public GameObject displayField;
    public GameObject displayFieldDesc;



    public void getText()
    {
        text = inputField.GetComponent<Text>().text;
        year = int.Parse(inputFieldAge.GetComponent<Text>().text);
        int CurYear = System.DateTime.Now.Year;
        age = CurYear - year;
        
        displayField.GetComponent<Text>().text = "Player "+text+", is "+age+" years old";
    }

}
