using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabList;
    [SerializeField] private GameObject spawnCube;
    private int randomPrefab;
    public float spawnRadius = 100;
    public float spawnCollisionCheckRadius;
    // Start is called before the first frame update
    void Start()
    {
        this.spawnCube.SetActive(false);
        for (int i = 0; i < 20; i++)
        {
            Vector3 spawnPoint = transform.position + Random.insideUnitSphere * spawnRadius;
            if (!Physics.CheckSphere(spawnPoint, spawnCollisionCheckRadius))
            {
                randomPrefab = Random.Range(0, prefabList.Count);
                GameObject obj = GameObject.Instantiate(prefabList[randomPrefab], spawnPoint, Random.rotation);
                obj.gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
