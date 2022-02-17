using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text count;
    [SerializeField] PlayableDirector playable;
    void Start()
    {
        StartCoroutine(MainStart());
    }

   IEnumerator MainStart()
    {
        yield return new WaitForSeconds(1);
        count.text = "3";
        yield return new WaitForSeconds(1);
        count.text = "2";
        yield return new WaitForSeconds(1);
        count.text = "1";
        yield return new WaitForSeconds(1);
        count.text = "Start!";
        yield return new WaitForSeconds(1);
        count.text = "";
        playable.Play();
    }

    public void SoundEnd()
    {
        count.text = "Finish!";
    }
    
}
