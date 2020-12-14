using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public managerhandler manage;
    public void OnTriggerEnter(Collider other)
    {
        manage.complete();
    }
}
