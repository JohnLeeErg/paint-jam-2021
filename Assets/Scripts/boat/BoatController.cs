using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private bool rowingLeft;
    [SerializeField] private bool rowingRight;

    public bool containsPlayer = false;
    private bool playerInTrigger = false;

    [SerializeField] private float strokeForceMulti = 7000; 
    [SerializeField] private float strokeTorqueMulti = 1000;
    [SerializeField] private float strokeSeconds = 1;
    [SerializeField] private float strokeResetFraction = 2;
    private float strokeResetTime;
    [SerializeField] private float maxSpeed = 10000;
    [SerializeField] private float minOarAngle = 25;
    [SerializeField] private float maxOarAngle = 155;


    [SerializeField] private float strokeTimerLeft =0;
    [SerializeField] private float strokeResetTimerLeft = 0;


    [SerializeField] private float strokeTimerRight = 0;
    [SerializeField] private float strokeResetTimerRight = 0;

    [SerializeField] private bool strokeResetLeft = false;
    [SerializeField] private bool strokeResetRight = false;

    public GameObject player;
    [SerializeField] bool startOnBoat;
    bool touchingLand;
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        strokeResetTime = (strokeSeconds / strokeResetFraction);

        if (startOnBoat)
        {
            print("now on boat:" + !containsPlayer);
            player.GetComponent<PlayerMovement>().enabled = containsPlayer;
            containsPlayer = !containsPlayer;
        }
    }

    void Update()
    {
        if (playerInTrigger || containsPlayer)
        {
            if (Input.GetButtonDown("Talk"))
            {
                if (touchingLand)
                {
                    print("now on boat:" + !containsPlayer);
                    player.GetComponent<PlayerMovement>().enabled = containsPlayer;
                    
                    containsPlayer = !containsPlayer;
                    if (containsPlayer)
                    {
                        player.GetComponent<Animator>().Play("Down"); //be in normal stand on the boat please
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (containsPlayer)
        {
            RightOar();
            LeftOar();
            player.transform.position = transform.position-Vector3.forward;
            
        }

    }

    void RightOar() {
        if (!strokeResetRight)
        {
            if (Input.GetAxis("RowRight") >0 && !rowingRight)
            {
                rowingRight = true;
                strokeTimerRight = 0;
            }
            else if (rowingRight && !(Input.GetAxis("RowRight") > 0))
            {
                rowingRight = false;
                strokeResetRight = true;
                strokeResetTimerRight = (1-(strokeTimerRight / strokeSeconds)) * strokeResetTime;
                transform.GetChild(2).localRotation = rotateOar(-maxOarAngle, -minOarAngle, strokeResetTimerRight / strokeResetTime);
                strokeTimerRight = 0;
            }
        }

        //returns oars and stops user from rowing
        else
        {
            strokeResetTimerRight = strokeResetTimerRight + Time.fixedDeltaTime;
           transform.GetChild(2).localRotation = rotateOar(-maxOarAngle, -minOarAngle, strokeResetTimerRight / strokeResetTime);

            if (strokeResetTimerRight > strokeResetTime)
            {
                strokeResetRight = false;
                strokeTimerRight = 0;
            }
        }

        if (rowingRight)
        {
            moveBoatRight();
            strokeTimerRight += Time.fixedDeltaTime;

            transform.GetChild(2).localRotation = rotateOar(-minOarAngle, -maxOarAngle, strokeTimerRight / strokeSeconds);

            if (strokeTimerRight > strokeSeconds)
            {
                strokeResetRight = true;
                rowingRight = false;
                strokeResetTimerRight = 0;
            }
        }
    }

    void LeftOar()
    {
        if (!strokeResetLeft)
        {
            if (Input.GetAxis("RowLeft") > 0 && !rowingLeft)
            {
                rowingLeft = true;
                strokeTimerLeft = 0;
            }
            else if (rowingLeft && !(Input.GetAxis("RowLeft") > 0))
            {
                rowingLeft = false;
                strokeResetLeft = true;
                strokeResetTimerLeft = (1 - (strokeTimerLeft / strokeSeconds)) * strokeResetTime;
                transform.GetChild(1).localRotation = rotateOar(maxOarAngle, minOarAngle, strokeResetTimerLeft / strokeResetTime);
                strokeTimerRight = 0;
                print("off1");
            }
        }

        //returns oars and stops user from rowing
        else
        {
            strokeResetTimerLeft = strokeResetTimerLeft + Time.fixedDeltaTime;
            transform.GetChild(1).localRotation =  rotateOar(maxOarAngle, minOarAngle, strokeResetTimerLeft / strokeResetTime);

            if (strokeResetTimerLeft > strokeResetTime)
            {
                print("resetted");
                strokeResetLeft = false;
                strokeTimerLeft = 0;
            }
        }

        if (rowingLeft)
        {
            moveBoatLeft();
            print("rowing");
            strokeTimerLeft += Time.fixedDeltaTime;


            transform.GetChild(1).localRotation = rotateOar(minOarAngle, maxOarAngle, strokeTimerLeft / strokeSeconds);


            if (strokeTimerLeft > strokeSeconds)
            {
                print("resetted");
                strokeResetLeft = true;
                rowingLeft = false;
                strokeResetTimerLeft = 0;
            }
        }
    }

    Quaternion rotateOar(float zfrom, float zTo, float percent) {
        Quaternion from = Quaternion.Euler(0, 0, zfrom);
        Quaternion to = Quaternion.Euler(0, 0, zTo);
        return Quaternion.Lerp(from, to, percent);
    }

    void clampMaxSpeed() {
        if (body.velocity.magnitude > maxSpeed)
        {
            body.velocity = body.velocity.normalized * maxSpeed;
        }
    }

    void moveBoatLeft() {
        body.AddForce(transform.up.normalized * strokeForceMulti, ForceMode2D.Force);
        body.AddTorque(-1 * strokeTorqueMulti);
    }

    void moveBoatRight() {
        body.AddForce(transform.up.normalized * strokeForceMulti, ForceMode2D.Force);
        body.AddTorque(1 * strokeTorqueMulti);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print("in");
            playerInTrigger = true;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Boat"))
        {
            touchingLand = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print("out");
            playerInTrigger = false;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Boat"))
        {
            touchingLand = false;
        }
    }
}

