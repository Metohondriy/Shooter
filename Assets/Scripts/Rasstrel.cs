using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rasstrel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bear1") || other.gameObject.CompareTag("Bear2") || other.gameObject.CompareTag("Bear3") || other.gameObject.CompareTag("Bear4") || other.gameObject.CompareTag("Wolf"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log(other.gameObject);
            Debug.Log(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bear1") || collision.gameObject.CompareTag("Bear2") || collision.gameObject.CompareTag("Bear3") || collision.gameObject.CompareTag("Bear4") || collision.gameObject.CompareTag("Wolf"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
