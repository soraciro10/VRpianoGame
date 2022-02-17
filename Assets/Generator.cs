using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject CubePrefab;
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Generate();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Generate();
        }
    }

    public void Generate()
    {

        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(Random.Range(-1.5f, -0.5f), Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
    public void Generate1()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-2.6f, Random.Range(-0.3f,0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }

    public void Generate2()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-2.4f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
    public void Generate3()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-2.2f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
    public void Generate4()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-2f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
    public void Generate5()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-1.8f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
    public void Generate6()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-1.6f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }

    public void Generate7()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-1.4f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
    public void Generate8()
    {
        GameObject Cube = GameObject.Instantiate(CubePrefab, new Vector3(-1.2f, Random.Range(-0.3f, 0.3f), 5), Quaternion.Euler(0, 180f, 0));
        Cube.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
        Destroy(Cube.gameObject, 10);
    }
}
