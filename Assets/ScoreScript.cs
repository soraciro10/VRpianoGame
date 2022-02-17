using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] Text Text;
    int score_L;
    int score;
    void Start()
    {
        score_L = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score = score_L + RightScore.score_r;
        Text.text = score.ToString()+"/297";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "score" && collision.gameObject.transform.position.z < 1.6 && collision.gameObject.transform.position.z > 1.3)
        {
            score_L++;
        }
    }
}
