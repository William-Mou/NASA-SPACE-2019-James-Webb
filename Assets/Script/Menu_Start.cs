using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Start : MonoBehaviour
{
    public GameObject TechPoint;
    public GameObject Money;
    public void changeMenuScene(string sceneName)
    {
        Debug.Log("ChangeScene");
        if (sceneName == "Phase1")
        {
            /*GameData.round_money = GameData.money / 10 + 1000;
            GameData.current_round += 1;
            GameData.money += GameData.round_money;
            GameData.tech_point += GameData.round_tech;
            */
            Debug.Log("current_round" + GameData.current_round);
            Debug.Log("money" + GameData.money);
            Debug.Log("tech_point" + GameData.tech_point);

            /*
            Debug.Log(TechPoint);
            Text txt_tech = TechPoint.GetComponent<Text>();
            txt_tech.text = "Tech_Point: " + GameData.tech_point.ToString();
            Text txt_money = Money.GetComponent<Text>();
            txt_money.text = "Tech_Point: " + GameData.tech_point.ToString();*/
        }
        Application.LoadLevel(sceneName);
    }

}
