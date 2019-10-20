using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Start : MonoBehaviour
{
    public Button button_stock;
    public void changeMenuScene(string sceneName)
    {
        Debug.Log("ChangeScene");
        if (sceneName == "Phase1")
        {
            GameData.round_money = GameData.money / 100;
            GameData.current_round += 1;
            GameData.money += GameData.round_money;
            GameData.tech_point += GameData.round_tech;

            Debug.Log("current_round" + GameData.current_round);
            Debug.Log("money" + GameData.money);
            Debug.Log("tech_point" + GameData.tech_point);
            /*
            GameObject TechPoint;
            TechPoint = GameObject.FindGameObjectWithTag ("Tech");
            Debug.Log(TechPoint);
            Text txt = TechPoint.GetComponent<Text>();
            txt.text = "Tech_Point: " + GameData.tech_point.ToString();

    */

        }
        Application.LoadLevel(sceneName);
    }

}
