using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Swing : MonoBehaviour
{
    float timer_f = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer_f += Time.deltaTime;
        //Debug.Log(transform.rotation.x);
        if (timer_f > 1 && timer_f <= 2)
        {
            transform.Rotate(Vector3.right * 1);
        }
        else if(timer_f > 2) timer_f = 0f; 
        else
        {
            transform.Rotate(Vector3.left * 1);
        }
    }
}
