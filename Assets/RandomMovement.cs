using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] float chargeTime = 5.0f;
    private float timeCount;

    [SerializeField] float speed;
    [SerializeField] GameObject particle1;
    [SerializeField] GameObject particle2;
    [SerializeField] GameObject particle3;

    Vector3 course1;
    Vector3 course2;
    Vector3 course3;

    void Update()
    {
       timeCount += Time.deltaTime;

        // 自動前進
        /* particle1.transform.position += transform.forward * Time.deltaTime * speed;
         particle2.transform.position += transform.forward * Time.deltaTime * speed;
         particle3.transform.position += transform.forward * Time.deltaTime * speed;*/


        //指定時間の経過（条件）
        if (timeCount > chargeTime)
        {
            // 進路をランダムに変更する
            course1 = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-10, 100));
            course2 = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-10, 100));
            course3 = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-10, 100));
            //particle1.transform.localRotation = Quaternion.Euler(course);
            //particle2.transform.localRotation = Quaternion.Euler(course1);
            //particle3.transform.localRotation = Quaternion.Euler(course2);

            // タイムカウントを０に戻す
            timeCount = 0;
        }

        particle1.transform.position = course1;
        particle2.transform.position = course2;
        particle3.transform.position = course3;
    }
}

    