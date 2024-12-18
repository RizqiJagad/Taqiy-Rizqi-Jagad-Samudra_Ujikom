using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    // public GameObject bulletPrefab;
    // private Transform shootPoint;

    // public float bulletSpeed = 20f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 Movement = new Vector3(horizontal, 0f, 0f);

        transform.Translate(Movement * moveSpeed * Time.deltaTime);

        //  if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        // {
        //     shootPoint();
        // }
    }

    // void Shoot()
    // {
    //     GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);

    //     Rigidbody rb = bullet.GetComponent<Rigidbody>();
    //     if (rb != null)
    //     {
    //         rb.velocity = shootPoint.forward * bulletSpeed;
    //     }

    //     Destroy(bullet, 3f);
    // }
}
