using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Burrel;
    private Quaternion BulletRot;
    void Update()
    {
        BulletRot = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, Burrel.position, BulletRot);
        }
        
    }
}
