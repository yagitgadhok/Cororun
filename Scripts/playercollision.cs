using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollision : MonoBehaviour
{
    public playercontrol movement;
    private void OnCollisionEnter(Collision collide)
    {
        if(collide.collider.tag == "obstacle")
        {
            movement.enabled = false;
            Debug.Log(collide.collider);
            FindObjectOfType<managerhandler>().darkscene();
        }
    }

}
