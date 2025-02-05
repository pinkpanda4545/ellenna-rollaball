using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public int health = 5;
    private NavMeshAgent navMeshAgent;
    public Transform healthbarRect; 
    private float initHealthX;

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

            //width
            Vector3 newSize = healthbarRect.localScale;
            newSize.x = health * 0.04f;
            healthbarRect.localScale = newSize;

            //position x
            Vector3 newPosition = healthbarRect.localPosition;
            newPosition.x = newPosition.x + 0.2f;
            healthbarRect.localPosition = newPosition;

            print("hit!");

            if (health == 0)
            {
                //change color
                this.gameObject.SetActive(false);
            }
        }
    }
}
