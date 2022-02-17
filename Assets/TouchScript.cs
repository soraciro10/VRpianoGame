using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchScript : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("3.-Clouds Sunset (Normal)");
    }

    public void StartButton()
    {
        Invoke("Next", 1f);
    }

    void Next()
    {
        SceneManager.LoadScene("3.-Clouds Sunset (Normal)");
    }



}


