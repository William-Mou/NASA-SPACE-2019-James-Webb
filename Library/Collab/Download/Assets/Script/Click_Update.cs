using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Click_Update : MonoBehaviour
{
    public static bool multi_sunshi = false;
    public static bool solar_power = false;
    public static bool thermal_ctrl = false;
    public static bool electrical_sys = false;
    //propulsion_system
    public static bool trim_flap = false;
    public static bool ctrl_sys = false;
    public static bool comm_sys = false;
    public static bool comm_data_sys = false;
    public static bool propulsion = false;
    //sensor_system
    public static bool mirror_comp = false;
    public static bool coolong_sys = false;
    public static bool Near_inf_cam = false;
    public static bool Near_inf_spec = false;
    //base_system
    public static int launch_base = 0;
    public static int rocket_fuel = 0;
    public static int oxidizing = 0;
    public static int rocket = 0;

    public void OnClickUpdate(string skill_name)
    {
        if (skill_name == "launch_base" || skill_name == "fuel" || skill_name == "oxidizing" || skill_name == "rocket" )
        {
            skill_name += 1;
        }
        else
        {
            skill_name += true;
        }
        //Debug.Log(skill_name);
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
