using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score_r;
    void Start()
    {
        score_r = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "score" && collision.gameObject.transform.position.z < 1.6&& collision.gameObject.transform.position.z>1.3)
        {
            score_r++;
        }
    }
}
