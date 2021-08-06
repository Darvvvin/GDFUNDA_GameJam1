using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetController : MonoBehaviour
{
    public GameObject[] randomPosition;
    public GameObject item;
    public AudioSource m_MyAudioSource, prev_AudioSource;

    public int id;

    void Start()
    {
        EventBroadcaster.current.onItemGet += ContinueStory;
    }

    public void ContinueStory(int id) {
        if (id == this.id) {
            int n = Random.Range(0, randomPosition.Length);
            item.transform.position = randomPosition[n].transform.position;
            Object.Destroy(this.gameObject);
            prev_AudioSource.Stop();
            m_MyAudioSource.Play();
        }
    }
}
