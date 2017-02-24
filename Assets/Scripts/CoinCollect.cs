using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Picked Up!" + hit.gameObject.name);
    }
}
