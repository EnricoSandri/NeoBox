using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    [Header("Target Prefab")]
    public GameObject objPrefabs;

    [Header("Spawn Points")]
    public GameObject[] SpawnPoints;
    private int spawnIndex;
    Vector3 spawnTransform;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine("SpawnTargets");
    }

    private IEnumerator SpawnTargets()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);

            spawnIndex = Random.Range(0, SpawnPoints.Length);
            spawnTransform = SpawnPoints[spawnIndex].transform.position;

            // Instantiate()
            GameObject target = Instantiate(objPrefabs, spawnTransform, Quaternion.Euler(0, 0, Random.Range(0, 2) * 90));
            target.transform.position += Time.deltaTime * transform.forward * 2;

        }

    }


}
