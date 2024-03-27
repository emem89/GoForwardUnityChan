using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEControlller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(int num)
    {
        switch (num)
        {
            case 0: //押されたボタンのUnity側で設定された引数が1のだったとき
                Debug.Log("food");
                break;
            case 1: //押されたボタンのUnity側で設定された引数が2のだったとき
                Debug.Log("exercise");
                break;
            case 2: //押されたボタンのUnity側で設定された引数が3のだったとき
                Debug.Log("sleep");
                break;
        }
    }
}
