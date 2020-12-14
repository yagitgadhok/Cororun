using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public Animator anim;
    int runninghash;
    private CharacterController controller;
    public float speed = 5.0f;
    private Vector3 movevector;
    private float verticalvelo = 0.0f;
    private float gravity = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        runninghash = Animator.StringToHash("running");
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        //anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if(controller.isGrounded)
        {
            verticalvelo = -0.5f;
        }
        else
        {
            verticalvelo -= gravity * Time.deltaTime;
        }

        movevector = Vector3.zero;

        bool running = anim.GetBool("running");

        anim.SetBool(runninghash, true);

        movevector.x = Input.GetAxisRaw("Horizontal") * speed;
        movevector.y = verticalvelo;
        movevector.z = speed;

        controller.Move((movevector) * Time.deltaTime);
        if(movevector.y < -1f)
        {
            FindObjectOfType<managerhandler>().Endgame();
        }
    }
}
