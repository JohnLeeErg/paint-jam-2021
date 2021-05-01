using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera cam;

    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] AudioSource leftStep, rightStep;

    [SerializeField] private float soundSpeed = 0.3f;
    [SerializeField] private float rotAdjust = 90f;

    private bool isLeftStep = true;
    private float lastStep = 0;
    private Vector2 movement;
    //private Vector2 mousePos;

    private Animator anim;
    private Rigidbody2D rb2d;
    [SerializeField] LayerMask boatLayers;
    private bool inConv = false;
    [SerializeField] private Conversation convText;

    void Start()
    {
        //grabbing all the components and objects
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        convText = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Conversation>();
        convText.startConv.AddListener(StartConv);
        convText.endConv.AddListener(EndConv);
    }

    void Update()
    {
        if (!inConv)
        {
            Controls();
            Footsteps();
            AnimBoolSet();
        }
    }

    void FixedUpdate()
    {
        if (!inConv)
        {
            Movement();
        }
    }

    private void Controls()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Movement()
    {
        //move player in the direction of the movement coords
        Vector2 newPosition = rb2d.position + movement * moveSpeed * Time.fixedDeltaTime;
        if (Physics2D.OverlapPoint(newPosition, boatLayers)) //only move to a position if it would still be overlapping a boat layer collider (aka boat or islands)
        {

            rb2d.MovePosition(newPosition);
        }

        //both the pos of the firepoint and player are made, they are being switched between to debug player rotation bug
        //Vector2 fpPos = new Vector2(firePoint.position.x, firePoint.position.y);
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.y);

        //figure out what direction the mouse is from the player
        //Vector2 direction = mousePos - playerPos;

        //determine the angle of rotation (-90 because aTan() starts from the right, and our sprite faces up)
        //also convert to radians because of how Z works
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - rotAdjust;

        //rotate the player the amount calculated above
        //rb2d.SetRotation(angle);
    }
    private void AnimBoolSet()
    {
        if (movement.x > 0)
        {
            anim.SetInteger("xint", 1);
        }
        else if (movement.x < 0)
        {
            anim.SetInteger("xint", -1);
        }
        else
        {
            anim.SetInteger("xint", 0);
        }

        if (movement.y > 0)
        {
            anim.SetInteger("yint", 1);
        }
        else if (movement.y < 0)
        {
            anim.SetInteger("yint", -1);
        }
        else
        {
            anim.SetInteger("yint", 0);
        }
    }

    private void Footsteps()
    {
        //check if moving
        if (movement.magnitude > 0)
        {
            if (Time.fixedTime - lastStep > soundSpeed)
            {
                if (isLeftStep)
                    leftStep.Play();
                else
                    rightStep.Play();

                lastStep = Time.fixedTime;
                isLeftStep = !isLeftStep;
            }

        }
        else
        {
            leftStep.Stop();
            rightStep.Stop();
        }
    }

    public void StartConv()
    {
        inConv = true;
        print("start");
    }
    public void EndConv()
    {
        print("end");

        inConv = false;
    }

}
