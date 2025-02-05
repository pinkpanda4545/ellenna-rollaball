using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    private int count = 0;
    public AudioSource winSound; 

    public void AddCount()
    {
        count = count + 1;

        if (count >= 8)
        {
            winSound.gameObject.SetActive(true);
            winSound.Play();
            while (GameObject.FindGameObjectWithTag("Enemy") != null) {
                GameObject.FindGameObjectWithTag("Enemy").gameObject.SetActive(false);
            }
        }
    }
}
