using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_Condition : MonoBehaviour
{

    //public int condition_size = 0;
    public Button[] condition = new Button[4];
    // Start is called before the first frame update
    bool unTouch;
    void Start()
    {
        //Debug.Log(condition.Length);
        unTouch = true;
    }

    // Update is called once per frame
    void Update()
    {
        bool isCheck = true;
        for(int i = 0; i < condition.Length; i++)
        {
            //Debug.Log(condition[i].interactable);
            if (condition[i].interactable)
            {
                isCheck = false;
            }
        }
        //Debug.Log(unTouch);
        if (isCheck && unTouch)
        {
            GetComponent<Button>().interactable = true;
            unTouch = false;
        }
    }
}
