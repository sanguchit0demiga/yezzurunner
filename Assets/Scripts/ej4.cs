using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objective;
    public Vector3 scale;
    void Start()
    {
        StartCoroutine(ChangeScale());
    }

    IEnumerator ChangeScale()
    {
        while (true)
        {
            objective.transform.localScale += scale;
            yield return new WaitForSeconds(1);
            objective.transform.localScale -= scale;
            yield return new WaitForSeconds(1);
        }
    }
    }