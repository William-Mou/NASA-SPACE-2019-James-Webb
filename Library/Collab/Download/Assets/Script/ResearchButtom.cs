using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchButtom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        player.money -= RESEARCH_PRICE;
        player.tech_point += RESEARCH_PRICE * RESEARCH_RATE;
        recheck_lights_up_cond();
        // Update is called once per frame
        void Update()
    {
        
    }
}
