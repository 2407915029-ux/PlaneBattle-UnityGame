using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject BulletPre;
    Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        firePoint = transform.Find("Firepoint");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if(horizontal !=0)
        {
            transform.position -= Vector3.left * 10f * Time.deltaTime * horizontal;
            if (transform.position.x < -10 || transform.position.x > 10)
                transform.position += Vector3.left * 10f * Time.deltaTime * horizontal;
        }
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            transform.position += Vector3.up * 10f * Time.deltaTime * vertical;
            if (transform.position.x< -10 || transform.position.x> 10)
                transform.position += Vector3.left * 10f * Time.deltaTime * vertical;
        }

        if (Input.GetKeyDown(KeyCode.Space ))
        {
            Instantiate(BulletPre, firePoint.position, firePoint.rotation);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        print("”Œœ∑Ω· ¯");
        Time.timeScale = 0;
    }
}
