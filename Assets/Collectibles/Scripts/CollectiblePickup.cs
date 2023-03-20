using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectiblePickup : MonoBehaviour
{
    //I am going to broadcast an event when I am picked up - I am an awesome Influencer

    public static event Action<int, string, string> OnCollectiblePickedUp;

    [SerializeField] private int collectibleValue;

    private void OnTriggerEnter(Collider other)
    {
        //Test if the triggering object is Player

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered collider: " + name);

            OnCollectiblePickedUp?.Invoke(collectibleValue, name, other.name);

            Destroy(gameObject);

        }


    }
}
