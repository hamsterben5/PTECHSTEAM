using UnityEngine;
using System.Collections;

public class GrenadeExplosion : MonoBehaviour
{
    private Collider[] hitcolliders;
    public float blastradius;
    public float explosionPower;
    public LayerMask explosionLayer;
    private float destroyTime = 8;



    void OnCollisionEnter (Collision col)
    {
        //Debug.Log(col.contacts[0].point.ToString());
        ExplosionWork(col.contacts[0].point);
        Destroy(gameObject);        
    }


    void ExplosionWork(Vector3 explosionPoint)
    {
        hitcolliders = Physics.OverlapSphere(explosionPoint, blastradius, explosionLayer);

        foreach(Collider hitCol in hitcolliders)
        {

            if(hitCol.GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
            {
                hitCol.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            }

            if (hitCol.GetComponent<Rigidbody>() != null)
            {
                hitCol.GetComponent<Rigidbody>().isKinematic = false;
                hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower, explosionPoint, blastradius, 1, ForceMode.Impulse);
            }

            if(hitCol.CompareTag("Enemy"))
            {
                Destroy(hitCol.gameObject, destroyTime);
            }
            
        }
    }
}