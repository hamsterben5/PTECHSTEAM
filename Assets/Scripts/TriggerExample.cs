using UnityEngine;
using System.Collections;

public class TriggerExample : MonoBehaviour
{

    void OnTriggerEnter(Collider Test)
    {
        Debug.Log(Test.name + "Entered!");
    }


    void OnTriggerExit(Collider Test)
    {
        Debug.Log(Test.name + "Exited");
    }

    void OnTriggerStay(Collider Test)
    {
        Debug.Log(Test.name + "In Trigger!");
    }
}


