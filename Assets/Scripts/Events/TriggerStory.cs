using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStory : MonoBehaviour
{
    public GameObject tempParent;
    public bool isHolding;
    public int id;

    float distance;
    void Update() {
        distance = Vector3.Distance(this.transform.position, tempParent.transform.position);
        if(distance >= 3f) {
            isHolding = false;
        }

        if(isHolding == true) {
            EventBroadcaster.current.ItemGet(id);
            isHolding = false;
        }

    }

    void OnMouseDown() {
        if(distance <= 3f) {
            isHolding = true;
        }
    }
}
