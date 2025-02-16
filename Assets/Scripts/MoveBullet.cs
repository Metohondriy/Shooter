using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public int speed = 50;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        } 
    }
    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null )
        {
            rb.velocity = bulletSpawn.up * Time.deltaTime * speed;
        }
        else
        {
            Debug.Log("ќ“су“ст¬ует –б");
        }
    }
}
