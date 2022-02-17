using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class LedBuild : MonoBehaviour
{
    
    void Start()
    {
        UduinoManager.Instance.pinMode(13, PinMode.Output);
       // StartCoroutine(LedLoop());
    }

    // Update is called once per frame
    void Update()
    {
        LedSwitch();
    }

    IEnumerator LedLoop()
    {
        while (true)
        {
            UduinoManager.Instance.analogWrite(13,127);
            yield return new WaitForSeconds(3f);
            UduinoManager.Instance.analogWrite(13, 128);
            yield return new WaitForSeconds(3f);
        }
    }

    void LedSwitch()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            UduinoManager.Instance.analogWrite(13, 128);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            UduinoManager.Instance.analogWrite(13, 127);
        }
    }
}
