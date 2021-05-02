using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyJiggle : MonoBehaviour
{

    public float waitInterval, jiggleSpeed;
    public float startX, startY, startZ;
    public float endX, endY, endZ;

    Vector3 startRotation;
    Vector3 endRotation;
    Vector3 oppositeEndRotation;

    float waitTimer, jiggleTimer;

    // Start is called before the first frame update
    // Start the wait timer, 
    void Start()
    {
        startRotation = new Vector3(startX, startY, startZ);
        endRotation = new Vector3(endX, endY, endZ);
        oppositeEndRotation = new Vector3(-endX, -endY, -endZ);

        jiggleTimer = 0;

        waitTimer = waitInterval;

        /*
        waitTimer = waitInterval;
        jiggling = false;
        startRotation = new Vector3(startX, startY, startZ);
        endRotation = new Vector3(endX, endY, endZ);
        */
    }

    // Update is called once per frame
    void Update()
    {
        startRotation = new Vector3(startX, startY, startZ);
        endRotation = new Vector3(endX, endY, endZ);
        oppositeEndRotation = new Vector3(-endX, -endY, -endZ);

        if (waitTimer <= 0)
        {
            // get a double version of the timer cuz why not
            double jiggleTimerDubs = Convert.ToDouble(jiggleTimer);

            // Use THE SIN
            float percentRotated = Convert.ToSingle(Math.Sin(2 * Math.PI * jiggleTimerDubs));

            // First half of rotation cycle
            if (percentRotated >= 0)
            {
                // Go to the positive side of the jiggle
                transform.rotation = rotateToPercent(startRotation, endRotation, percentRotated);
            }
            // Second half of rotation cycle
            else
            {
                // Go to negative side of the jiggle
                transform.rotation = rotateToPercent(startRotation, oppositeEndRotation, -percentRotated);
            }


            // Increment jiggle timer
            jiggleTimer += 0.001f * jiggleSpeed;

            // If done the jiggle, start wait timer again
            if (jiggleTimer >= 1)
            {
                waitTimer = waitInterval;
                jiggleTimer = 0;
            }
        } 
        else
        {
            waitTimer -= Time.deltaTime;
        }
        /*
        // Set initial rotation, set jiggling flag, reset wait timer, start jiggle timer 
        if (waitTimer <= 0)
        {
            rotation = new Vector3(startX, startY, startZ);
            transform.Rotate(rotation);

            jiggling = true;
            waitTimer = waitInterval;
            jiggleTimer = 0;
        }
        else
        {
            waitTimer--;
        }

        // While jiggling
        if (jiggling)
        {
            
        }
        */
        
    }

    Quaternion rotateToPercent(Vector3 from, Vector3 to, float percent)
    {
        Quaternion fromQ = Quaternion.Euler(from.x, from.y, from.z);
        Quaternion toQ = Quaternion.Euler(to.x, to.y, to.z);
        return Quaternion.Lerp(fromQ, toQ, percent);
    }
}
