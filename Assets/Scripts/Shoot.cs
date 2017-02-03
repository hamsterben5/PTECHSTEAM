using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class Shoot : MonoBehaviour
    {

        private float fireRate = 0.3f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 300;




        void Start()
        {

        }


        void Update()
        {
            CheckForInput();
        }


        void CheckForInput()
        {
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                Debug.DrawRay(transform.TransformPoint(0, 0, 1), transform.forward, Color.red, 10);
                if (Physics.Raycast(transform.TransformPoint(0, 0, 1), transform.forward, out hit, range))
                {
                    if(hit.transform.CompareTag("Enemy"))
                    {
                        Debug.Log("Enemy" + hit.transform.name);
                    }
                    else
                    {
                        Debug.Log("Not an enemy" + hit.transform.name);
                    }
                
                }

                       
                

                // Debug.Log("Key Pressed");
                nextFire = Time.time + fireRate;
            }
        }
    }
}


