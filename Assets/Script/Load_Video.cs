using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Load_Video : MonoBehaviour
{
    float timer_f;
    void Start()
    {
        timer_f = 0f;
    }
    void Update()
    {
        Debug.Log(timer_f);
        timer_f += Time.deltaTime;
        if (timer_f > 24.9f)
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");//載入場景
    }
}
