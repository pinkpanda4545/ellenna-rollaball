using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDeleteArrows : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
