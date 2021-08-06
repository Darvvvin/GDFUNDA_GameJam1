using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBroadcaster : MonoBehaviour
{
    public static EventBroadcaster current;

    public GameObject phone;
    public GameObject[] randomPosition;

    void Awake() {
        current = this;

        int n = UnityEngine.Random.Range(0, randomPosition.Length);
        phone.transform.position = randomPosition[n].transform.position;
    }

    public event Action<int> onItemGet;
    public event Action onChangeUI;

    public void ItemGet(int id) {
        if(onItemGet != null) {
            onItemGet(id);
        }
    }

    public void UiChange()
    {
        if (onChangeUI != null)
        {
            onChangeUI();
        }
    }
}
