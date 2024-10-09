using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 3f;
    public float tiempoVivo = 0f;
    public float tiempoDeVidaMaximo = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position-= new Vector3(velocity * (Time.deltaTime),0,0);  
        tiempoVivo += Time.deltaTime;   
        if(tiempoVivo > tiempoDeVidaMaximo)
        {
            Destroy(gameObject);
        }
    }
}
