using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// a thing for an npc to be walkin around, with optional animating
/// </summary>
public class WalkFromPointToPoint : MonoBehaviour
{
    [SerializeField] float walkSpeed, waitTime;
    [SerializeField] Transform[] walkPoints;
    [SerializeField] bool loop = true; //if not looping, ping ponging
    float waitTimer = 0;
    int i = 0;
    Vector3 deltaMovement;
    int movementDirection = 1; //movement direction through the list of points
    Animator animComp;
    // Start is called before the first frame update
    void Start()
    {
        waitTimer = waitTime;
        animComp = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTimer <= 0)
        {
            if (Vector2.Distance(transform.position, walkPoints[i].position) < .01f)
            {
                i+=movementDirection;
                if (i >= walkPoints.Length)
                {
                    if (loop)
                    {
                        i = 0;
                    }
                    else
                    {
                        movementDirection = -movementDirection;
                    }
                }
                waitTimer = waitTime;
            }
            else
            {
                Vector3 newPos=Vector2.MoveTowards(transform.position, walkPoints[i].position, walkSpeed * Time.deltaTime);
                deltaMovement = newPos - transform.position;
                transform.position = newPos;
            }
        }
        else
        {
            deltaMovement = Vector3.zero;
            waitTimer -= Time.deltaTime;
        }

        if (animComp)
        {
            DetermineAnimationState();
        }
    }
    void DetermineAnimationState()
    {
        if (deltaMovement.magnitude == 0)
        {
            if (animComp.GetCurrentAnimatorStateInfo(0).IsName("Up"))
            {
                animComp.Play("Up Idle");
            }
            else if (animComp.GetCurrentAnimatorStateInfo(0).IsName("Down"))
            {
                animComp.Play("Down Idle");
            }
            else if (animComp.GetCurrentAnimatorStateInfo(0).IsName("Left"))
            {
                animComp.Play("Left Idle");
            }
            else if (animComp.GetCurrentAnimatorStateInfo(0).IsName("Right"))
            {
                animComp.Play("Right Idle");
            }
        }
        else
        {
            if(deltaMovement.y>0 && animComp.HasState(0,Animator.StringToHash("Up")))
            {
                animComp.Play("Up");
            }else if(deltaMovement.y < 0 && animComp.HasState(0, Animator.StringToHash("Down")))
            {
                animComp.Play("Down");
            }
            else if (deltaMovement.x < 0 && animComp.HasState(0, Animator.StringToHash("Left")))
            {
                animComp.Play("Left");
            }
            else if (deltaMovement.x > 0 && animComp.HasState(0, Animator.StringToHash("Right")))
            {
                animComp.Play("Right");
            }
        }
    }
}
