using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{

    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
    }
    public void NextRound()
    {
        GameData.round_money = GameData.money / 10 + 1000;
        GameData.current_round += 1;
        GameData.money += GameData.round_money;
        GameData.tech_point += GameData.round_tech;
        Debug.Log("Round" + GameData.current_round.ToString());
    }
    public void CheckStock()
    {
        if (GameData.money >= GameData.STOCK_PRICE)
        {
            GetComponent<Button>().interactable = true;
        }
    }
    public void CheckTech()
    {
        if (GameData.money >= GameData.RESEARCH_PRICE)
        {
            GetComponent<Button>().interactable = true;
        }
    }
    public void StockOnClick()
    {
        if (GameData.money >= GameData.STOCK_PRICE)
            {
                System.Random rnd = new System.Random();
                GameData.money -= GameData.STOCK_PRICE;
                float rate = (float)Random.Range(0.5f, 1.3f);
                GameData.money += (int)(GameData.STOCK_PRICE * rate);
                Debug.Log(rate);

                
                Debug.Log(GameData.money);
                //Debug.Log("You have clicked the button!");
            }
        if (GameData.money <= GameData.STOCK_PRICE)
        {
            GetComponent<Button>().interactable = false;
        }
    }
    public void ResearchOnClick()
    {
        if (GameData.money >= GameData.RESEARCH_PRICE)
        {

            System.Random rnd = new System.Random();
            GameData.money -= GameData.RESEARCH_PRICE;
            float rate = (float)Random.Range(0.0f, 1.0f);
            if (rate < GameData.RESEARCH_RATE)
            {
                Debug.Log(GameData.tech_point);
                GameData.tech_point += 1;

                if (GameData.RESEARCH_RATE > 0.7f)
                {
                    GameData.RESEARCH_RATE -= 0.05f;
                }
                else if (GameData.RESEARCH_RATE > 0.3f)
                {
                    GameData.RESEARCH_RATE -= 0.03f;
                }
            }

            Debug.Log(GameData.tech_point);
        }
        if (GameData.money <= GameData.RESEARCH_PRICE)
        {
            GetComponent<Button>().interactable = false;
        }
    }
}
