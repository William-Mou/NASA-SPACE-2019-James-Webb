using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    //player
    public static int money = 3;
    public static int tech_point = 3;
    public static int round_money = 2;
    public static int round_tech = 1;
    public static int current_round = 0;


    //electrical_system

    //public static bool multi_sunshi = false;
    //public static bool solar_power = false;
    //public static bool thermal_ctrl = false;
    //public static bool electrical_sys = false;
    ////propulsion_system
    //public static bool trim_flap = false;
    //public static bool ctrl_sys = false;
    //public static bool comm_sys = false;
    //public static bool data_sys = false;
    //public static bool propulsion = false;
    ////sensor_system
    //public static bool mirror_comp = false;
    //public static bool coolong_sys = false;
    //public static bool Near_inf_cam = false;
    //public static bool Near_inf_spec = false;
    ////base_system
    //public static int launch_base = 0;
    //public static int fuel = 0;
    //public static int oxidizing = 0;
    //public static int rocket = 0;

    //int STOCK_PRICE;
    public static int RESEARCH_PRICE = 2;
    public static float RESEARCH_RATE = 0.5f;
    public static int STOCK_PRICE = 2;
    public static float STOCK_RATE = 0.5f;
    public static int MAX_ROUND = 30;

    public static bool gameover = false;
}

public class Data_Manager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
