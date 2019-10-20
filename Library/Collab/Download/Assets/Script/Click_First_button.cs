using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click_First_Button : MonoBehaviour
{
    public void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is click
        GameData.STOCK_PRICE += 1;
        GameData.STOCK_RATE += 1;
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = GameData.STOCK_PRICE.ToString();
        //Debug.Log("You have clicked the button!");


    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}