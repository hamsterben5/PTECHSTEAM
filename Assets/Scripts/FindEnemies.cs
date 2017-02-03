using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class FindEnemies : MonoBehaviour {


        GameObject[] enemies;
    


        void Start()
        {
            SearchForEnemies();

        }

        void Update()
        {
        }

        void SearchForEnemies()
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy");

            if(enemies.Length > 0)
            {
                foreach(GameObject go in enemies)
                {
                    Debug.Log(go.name + "Enemy Spotted!");
                }
            }
        }
    }
}