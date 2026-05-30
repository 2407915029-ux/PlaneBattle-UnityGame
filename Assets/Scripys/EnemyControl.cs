using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.forward * 100f * Time.deltaTime;
        if (transform.position.z < -20)
            Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other .tag=="Bullet")
        {
            Destroy(gameObject);
        }
    }
}
