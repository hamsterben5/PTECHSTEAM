using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinFunctino : MonoBehaviour
{

    public int value;
    public float rotateSpeed;

    void Update()
    {
        gameObject.transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed);
    }

    void OnTriggerEnter()
    {

        GameManager.instance.Collect(value, gameObject);
        
        AudioSource source = GetComponent<AudioSource>();

        source.Play();
    }
}