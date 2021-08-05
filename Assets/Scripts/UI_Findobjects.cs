using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Findobjects : MonoBehaviour
{

    [SerializeField] private List<GameObject> storyObjects;
    //[SerializeField] private GameObject phone;
    //[SerializeField] private GameObject paper;
    private int curStoryObject = 0;

    // Start is called before the first frame update
    void Start()
    {
        EventBroadcaster.current.onChangeUI += OnStoryEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStoryEvent()
    {
        storyObjects[curStoryObject].gameObject.SetActive(false);
        this.curStoryObject++;
        storyObjects[curStoryObject].gameObject.SetActive(true);

    }
}
