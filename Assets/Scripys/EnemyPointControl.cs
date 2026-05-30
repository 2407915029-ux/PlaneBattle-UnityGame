using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPointControl : MonoBehaviour
{
    public GameObject EnemyPre;
    float timer = 0f;
    float CD = 1f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > CD)
        {
            timer = 0;
            CD = Random.Range(0.3f,3f);
            Vector3 pos = transform.position + Vector3.left * Random.Range(-10f, 10f)
                        + Vector3.up * Random.Range(-10f, 10f);
            Instantiate(EnemyPre, pos, transform.rotation);
        }

    }
}
