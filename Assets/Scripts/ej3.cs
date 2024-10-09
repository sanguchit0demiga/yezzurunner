using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            int RandomPosX = Random.Range(0, 3);
            int RandomPosY = Random.Range(0, 6);
            Vector2 RandomPos = new Vector2(RandomPosX, RandomPosY);
            Instantiate(enemy, RandomPos, enemy.transform.rotation);
            yield return new WaitForSeconds(3);
        }
    }
    }