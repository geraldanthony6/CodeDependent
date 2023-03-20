using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    [SerializeField]private GameObject[] spawnpoints;

    private void Awake() {
        Instance = this;
    }

    public Transform GetSpawnPoint(int spawnIndex)
    {
        return spawnpoints[spawnIndex].transform;
    }
}
