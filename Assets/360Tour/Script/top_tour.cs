using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class top_tour : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        //ゲーム画面へ
    public void goGame(){
        SceneManager.LoadScene("360Sample");
        }
}
