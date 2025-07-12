using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class collectible : MonoBehaviour
{
    public UnityEvent onCollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected.Invoke();
            Destroy(gameObject); 
        }
    }
}