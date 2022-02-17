using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class PitchCtrl : MonoBehaviour
{
    [SerializeField] AudioSource[] c;
    UduinoManager manager;
    static float soundvolume;
    static int volume;
    ReadTouch piano;


    void Start()
    {
        manager = UduinoManager.Instance;
        manager.pinMode(AnalogPin.A0, PinMode.Input);
        volume = 1023;
    }

    // Update is called once per frame
    void Update()
    {

        volume = manager.analogRead(AnalogPin.A0);  //読み取り
        //Debug.Log("V:"+volume);

        if (volume < 900 && soundvolume > 1020)　 //押してない＝１０２３
        {
            for(int i = 0; i < 15; i++)
            {
                c[i].volume = 1 - (float)volume / 1024;
            }
            //s1.Play();
        }

        soundvolume = volume; //前回の値を保持
        //Debug.Log("S:" + soundvolume);

    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("V:" + volume);
        Debug.Log("S:" + soundvolume);

        if (volume < 900)
        {
            switch (collision.gameObject.tag) //enum or 関数
            {
                case "ド": c[0].Play(); break;
                case "レ": c[1].Play(); break;
                case "ミ": c[2].Play(); break;
                case "ファ": c[3].Play(); break;
                case "ソ": c[4].Play(); break;
                case "ラ": c[5].Play(); break;
                case "シ": c[6].Play(); break;
                case "5ド": c[7].Play(); break;
                case "5レ": c[8].Play(); break;
                case "5ミ": c[9].Play(); break;
                case "5ファ": c[10].Play(); break;
                case "5ソ": c[11].Play(); break;
                case "5ラ": c[12].Play(); break;
                case "5シ": c[13].Play(); break;
                case "6ド": c[14].Play(); break;
                default: break;
            }
       }
  



        /*if (collision.gameObject.tag == "ド"&& volume < 900 && soundvolume == 1023) {  c[0].Play();  }
        if (collision.gameObject.tag == "レ") { c[1].Play(); }
        if (collision.gameObject.tag == "ミ") { c[2].Play(); }
        if (collision.gameObject.tag == "ファ") { c[3].Play(); }
        if (collision.gameObject.tag == "ソ") { c[4].Play(); }
        if (collision.gameObject.tag == "ラ") { c[5].Play(); }
        if (collision.gameObject.tag == "シ") { c[6].Play(); }
        if (collision.gameObject.tag == "5ド") { c[7].Play(); }
        if (collision.gameObject.tag == "5レ") { c[8].Play(); }
        if (collision.gameObject.tag == "5ミ") { c[9].Play(); }
        if (collision.gameObject.tag == "5ファ") { c[10].Play(); }
        if (collision.gameObject.tag == "5ソ") { c[11].Play(); }
        if (collision.gameObject.tag == "5ラ") { c[12].Play(); }
        if (collision.gameObject.tag == "5シ") { c[13].Play(); }
        if (collision.gameObject.tag == "6ド") { c[14].Play(); }*/
    }
}
