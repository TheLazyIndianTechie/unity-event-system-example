using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectiblesNotificationCanvasManager : MonoBehaviour
{
    private Canvas collectiblesNotificationCanvas;

    private TMP_Text collectiblesNotificationText;

    private void Awake()
    {
        collectiblesNotificationCanvas = GetComponent<Canvas>();
        collectiblesNotificationText = GetComponentInChildren<TMP_Text>();
    }

    private void OnEnable()
    {
        CollectiblesPickupManager.OnCollectiblePickupReceived += DisplayCollectiblesNotification;   
    }


    private void OnDisable()
    {
        CollectiblesPickupManager.OnCollectiblePickupReceived -= DisplayCollectiblesNotification;
    }

    public void DisplayCollectiblesNotification(string notificationMessage)
    {
        DisplayCollectiblesNotificationCanvas();

        collectiblesNotificationText.SetText(notificationMessage);

        Debug.Log(notificationMessage);
    }

    public void DisplayCollectiblesNotificationCanvas()
    {
        collectiblesNotificationCanvas.enabled = true;
    }

}
