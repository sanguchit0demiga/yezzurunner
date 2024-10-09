using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnobstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaculo;
    public Vector2 spawnpos;
    public float delay = 2f;
    public float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("Spawnobstacle",delay, repeatRate);
    }

    // Update is called once per frame
    void Spawnobstacle()
    {
        Instantiate(obstaculo, spawnpos, obstaculo.transform.rotation);
    }
}
