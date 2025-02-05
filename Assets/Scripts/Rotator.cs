using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            GameObject.Find("WinningScript").GetComponent<Winning>().AddCount();
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
