using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 posfinal = new Vector3(10, 0, 0);
    private Vector3 posinicial;

    void Start()
    {
        posinicial = transform.position;
        StartCoroutine(Moveobject());
    }

    IEnumerator Moveobject()
    {
        while (true)
        {
            
            transform.position = Vector3.MoveTowards(transform.position, posfinal, 2 * Time.deltaTime);

           
            if (transform.position == posfinal)
            {
                yield return new WaitForSeconds(2); 

               
                while (transform.position != posinicial)
                {
                    transform.position = Vector3.MoveTowards(transform.position, posinicial, 2 * Time.deltaTime);
                    yield return null;
                }
            }

            yield return null;
        }
    }
}