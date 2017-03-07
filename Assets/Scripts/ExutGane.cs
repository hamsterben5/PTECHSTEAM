using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("Escape"))
            Application.Quit();
    }
}
