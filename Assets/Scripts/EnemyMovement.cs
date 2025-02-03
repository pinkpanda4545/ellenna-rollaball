using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public int health = 5; 
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (health > 0)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            Destroy(other.gameObject);

            //adjust healthbar
            health -= 1;
            print("hit!");

            if (health == 0)
            {
                //change color
                print("Enemy dead");
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            Destroy(other.gameObject);

            //adjust healthbar
            health -= 1;
            print("hit!");

            if (health == 0)
            {
                //change color
                print("Enemy dead");
            }
        }
    }
}
