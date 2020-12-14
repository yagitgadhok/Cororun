using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standinganim : MonoBehaviour
{
    public Animator stand;
    int wavinghash;
    // Start is called before the first frame update
    void Start()
    {
        stand = GetComponent<Animator>();
        wavinghash = Animator.StringToHash("standingperson");
    }

    // Update is called once per frame
    void Update()
    {
        //bool running = stand.GetBool("standingperson");

        stand.SetBool(wavinghash, true);
    }
}
