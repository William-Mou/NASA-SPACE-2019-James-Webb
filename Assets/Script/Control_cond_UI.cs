using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Control_cond_UI : MonoBehaviour
{
    public void Refresh_money()
    {

        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = "Money: " + GameData.money.ToString();
    }

    public void Refresh_tech()
    {

        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = "Tech Point: " + GameData.tech_point.ToString();
    }
    public void Refresh_round()
    {

        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = "Round " + GameData.current_round.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
