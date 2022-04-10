using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationPlatform : MonoBehaviour
{
    [SerializeField] private Platform[] platformsPrefabs;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float globalY;
    [SerializeField] private float deltaY;

    void Start()
    {
        SpawnPlatforms(15);
    }

    private void Update()
    {
        if (transform.childCount < 15)
        {
            SpawnPlatforms(1);
        }
    }

    public void SpawnPlatforms(int countPlatform)
    {
        Vector3 spawnerPosition = new Vector3();

        for (int i = 0; i < countPlatform; i++)
        {
            spawnerPosition.x = Random.Range(minX, maxX);
            spawnerPosition.y = Random.Range(globalY, globalY + deltaY);
            int index = Random.Range(0, 5);

            if (index == 1)
            {
                GameObject instance = Instantiate(platformsPrefabs[3].gameObject, spawnerPosition, Quaternion.identity);
                instance.transform.SetParent(this.transform);
                globalY += instance.GetComponent<Platform>().minSpawnPositionY;
            }
            else
            {
                GameObject instance = Instantiate(platformsPrefabs[Random.Range(0, platformsPrefabs.Length-1)].gameObject, spawnerPosition, Quaternion.identity);
                instance.transform.SetParent(this.transform);
                globalY += instance.GetComponent<Platform>().minSpawnPositionY;
            }            
        }
    }
}
