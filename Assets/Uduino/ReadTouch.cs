using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using UnityEngine.UI;

public class ReadTouch : MonoBehaviour
{
    [SerializeField] AudioSource s1;
    [SerializeField] Slider slider;
    UduinoManager manager;
    static float soundvolume;
    bool on;

    void Start()
    {
        manager = UduinoManager.Instance;
        manager.pinMode(AnalogPin.A0, PinMode.Input);
    }

    // 前回が1023(タッチしてない)なら音が鳴らせる。　　タッチしたら前回が1023になる（離す）まで鳴らさない
    void Update()
    {
        piaduino();
    }

    public void piaduino()
    {
        int volume = manager.analogRead(AnalogPin.A0);　//読み取り
        Debug.Log(volume);

        slider.value = (float)volume / 1024;


        if (volume < 800 && soundvolume > 1020)　//前回タッチされていて　かつ　今回タッチされていない!＝1024　→前回のvolumで音を鳴らす
        {
            s1.volume = 1 - (float)volume / 1024;
            s1.Play();
        }

        soundvolume = volume; //前回の値を保持
    }

}
