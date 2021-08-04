using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBroadcaster : MonoBehaviour
{
    public static EventBroadcaster current;
    void Awake() {
        current = this;
    }

    public event Action<int> onItemGet;
    public void ItemGet(int id) {
        if(onItemGet != null) {
            onItemGet(id);
        }
    }
}
