using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.forward * 50;
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
