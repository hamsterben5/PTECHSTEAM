 using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class ThrowGrenade : MonoBehaviour
    {

        public GameObject grenadePrefab;
        private Transform grenadetransform;
        public float PropulsionForce;   

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnGrenade();
            }
        }

        void SetInitialReferences()
        {
            grenadetransform = transform;
        }

        void SpawnGrenade()
        {
            GameObject go = (GameObject) Instantiate(grenadePrefab, grenadetransform.TransformPoint(0, 0, 0.5f), grenadetransform.rotation);
            go.GetComponent<Rigidbody>().AddForce(grenadetransform.forward * PropulsionForce, ForceMode.Impulse);
            Destroy(go, 3);
        }

    }
}


