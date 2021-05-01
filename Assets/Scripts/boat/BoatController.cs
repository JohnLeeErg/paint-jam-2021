using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private Rigidbody2D body;
    public bool rowing;

    [SerializeField] private float strokeForceMulti = 7000; 
    [SerializeField] private float strokeTorqueMulti = 1000;
    [SerializeField] private float strokeSeconds = 1;
    [SerializeField] private float strokeResetFraction = 2;
    [SerializeField] private float maxSpeed = 10000; 
    [SerializeField] private float maxRotation = .5f;


    [SerializeField] private float strokeTimer =0;
    [SerializeField] private float strokeResetTimer = 0;
    [SerializeField] private bool strokeReset = false;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!strokeReset) {
            if (Input.GetKey("space")&&!rowing) {
                print("here");
                rowing = true;
                strokeTimer = 0;
            } else if (rowing&& !Input.GetKey("space")) {
                rowing = false;
         
                strokeResetTimer = strokeTimer / strokeResetFraction;
                print("off");
            }
        }
        
        //returns oars and stops user from rowing
      else {
            strokeResetTimer = strokeResetTimer + Time.fixedDeltaTime;
            if (strokeResetTimer > strokeSeconds/strokeResetFraction)
            {
                print("resetted");
                strokeReset = false;
                strokeTimer = 0;
            }
        }
    
        if (rowing)
        {
            moveBoatLeft();
            moveBoatRight();
            print("rowing");
            strokeTimer += Time.fixedDeltaTime;
            if (strokeTimer > strokeSeconds) {
                print("resetted");
                strokeReset = true;
                rowing = false;
                strokeResetTimer = 0;
            }
        }

        
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
}

