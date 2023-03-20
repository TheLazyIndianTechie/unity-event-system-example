using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectiblesPickupManager : MonoBehaviour
{
    //I am an awesome subscriber to influencers

    // I am also sending a message out to my friends about this cool influencer

    public static event Action<string> OnCollectiblePickupReceived;

    private void OnEnable()
    {
        //Subscribe to collectible pickup notification
        CollectiblePickup.OnCollectiblePickedUp += HandleOnCollectiblePickedUp;
    }

    private void OnDisable()
    {
        //Unsubscribe to collectible pickup notification
        CollectiblePickup.OnCollectiblePickedUp -= HandleOnCollectiblePickedUp;
    }

    public void HandleOnCollectiblePickedUp(int collectibleValue, string collectibleDetails, string playerName)
    {
        Debug.Log(playerName + " has picked up " + collectibleValue + " " + collectibleDetails +"(s)");

        string message = playerName + " has picked up " + collectibleValue + " " + collectibleDetails + "(s)";

        OnCollectiblePickupReceived?.Invoke(message);
    }
}
