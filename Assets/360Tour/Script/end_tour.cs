using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移のために必用
using UnityEngine.UI;//ユーザインタフェイス使用に必用

public class end_tour : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        
    }

        //topに戻る
    public void goHomeBtn(){
  
        SceneManager.LoadScene("top_tour");//シーン名topを呼び出して遷移
        }

}
