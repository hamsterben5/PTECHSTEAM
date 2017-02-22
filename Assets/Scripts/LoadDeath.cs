using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDeath : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            Application.LoadLevel("DeadScene");
    }
}