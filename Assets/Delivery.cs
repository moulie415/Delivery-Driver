using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hello world");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hello world trigger");
    }
}