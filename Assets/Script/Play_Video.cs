using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Play_Video : MonoBehaviour
{
    public float limit;
    float timer_f;
    void Start()
    {
        timer_f = 0f;
    }
    void Update()
    {
        Debug.Log(timer_f);
        timer_f += Time.deltaTime;
        if (timer_f > limit)
            UnityEngine.SceneManagement.SceneManager.LoadScene("1-Upgrade");//載入場景
    }
}
