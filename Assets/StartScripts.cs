using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           SceneManager.LoadScene("SoundGame");
        }

        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("SoundGame1");
        }
    }
}
