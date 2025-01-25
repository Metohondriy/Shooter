using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControler : MonoBehaviour
{
    public float horisontal;
    public float vertical;
    public float sens;

    // Update is called once per frame
    void Update()
    {
        horisontal = Input.GetAxis("Mouse X") * sens;

        transform.Rotate(0, horisontal, 0);

        vertical = Input.GetAxis("Mouse Y") * sens;

        transform.Rotate(0, 0, vertical);
    }
}
