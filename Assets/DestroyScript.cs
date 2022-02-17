using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyScript : MonoBehaviour
{
    public GameObject good;
    public GameObject bubble;
    public GameObject bad;
    public static int score;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        //Destroy(this.gameObject);
        Instantiate(particleObject, this.transform.position, Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180)));
        Destroy(this.gameObject);
    }*/

    private void OnCollisionEnter(Collision other)
    {
        if(this.transform.position.z< 1.6 && this.transform.position.z >= 1.3)
        {
            Instantiate(good, this.transform.position, Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180)));
            Instantiate(bubble, new Vector3(Random.Range(-6, 3), 1, Random.Range(0, 3)), Quaternion.Euler(Random.Range(-100, 100), 0,0));
            Destroy(this.gameObject);
        }

        else
        {
            Instantiate(bad, this.transform.position, Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180)));
            Destroy(this.gameObject);
        }
 
       
    }
}
