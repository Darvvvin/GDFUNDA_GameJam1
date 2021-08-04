using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetController : MonoBehaviour
{
    public GameObject randomPosition;
    public GameObject item;

    public int id;

    void Start()
    {
        EventBroadcaster.current.onItemGet += ContinueStory;
    }

    public void ContinueStory(int id) {
        if (id == this.id) {
            item.transform.position = randomPosition.transform.position;
            Object.Destroy(this.gameObject);
        }
    }
}
