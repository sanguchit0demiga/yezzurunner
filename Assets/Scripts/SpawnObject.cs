using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] Obstacles;
    public Vector2 position;
    public float timetospawn;
    public float repeat;

    private void Start()
    {
        InvokeRepeating("SpawnObstacles", timetospawn, repeat);
    }
    void SpawnObstacles()
    {
        int randoms = Random.Range(0, Obstacles.Length);
        GameObject RandomObstacles = Obstacles[randoms];
        Instantiate(RandomObstacles, position, RandomObstacles.transform.rotation);
    }
}