using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camhandler : MonoBehaviour
{
    public float speed = 10f;
    public Transform player;
    public Vector3 offset; 
    void FixedUpdate()
    {
        Vector3 desire = player.position + offset;
        Vector3 smooth = Vector3.Lerp(transform.position, desire, speed * Time.deltaTime);
        transform.position = smooth;
        transform.LookAt(player);
    }
}
