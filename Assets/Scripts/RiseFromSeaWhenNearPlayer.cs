using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseFromSeaWhenNearPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float riseSpeed,rotateSpeed, risenZ,radius;
    Collider2D colRef;
    Quaternion startRotation;
    float startZ;
    // Start is called before the first frame update
    void Start()
    {
        startZ = transform.position.z;
        startRotation = transform.rotation;
        colRef=GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < radius)
        {
            if (transform.position.z != risenZ)
            {
                transform.rotation = startRotation;
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, risenZ), riseSpeed * Time.deltaTime);
            }
            else
            {
                if (!colRef.enabled)
                {
                    colRef.enabled = true;
                }
                transform.Rotate(transform.up, rotateSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (colRef.enabled)
            {
                colRef.enabled = false;
            }
            if (transform.position.z != startZ)
            {

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, startZ), riseSpeed * Time.deltaTime);
            }
            else
            {
                transform.rotation = startRotation;
            }
        }
    }
}
