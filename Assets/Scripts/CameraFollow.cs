using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform thingToFollow;
    [SerializeField] float hBuffer, vBuffer, followSpeed, tileSize;
    [SerializeField] Transform topLeft, BottomRight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OldWay();
    }

    void NewWay()
    {
        transform.position = new Vector3(thingToFollow.position.x, thingToFollow.position.y, transform.position.z);
    }

    void OldWay()
    {
        if (Mathf.Abs(thingToFollow.position.x - transform.position.x) > hBuffer * tileSize || Mathf.Abs(thingToFollow.position.y - transform.position.y) > vBuffer * tileSize)
        {

            Vector3 newPos = Vector3.MoveTowards(transform.position, thingToFollow.position, followSpeed * tileSize * Time.deltaTime);
            transform.position = new Vector3(Mathf.Clamp(newPos.x, topLeft.position.x + Camera.main.orthographicSize * Camera.main.aspect, BottomRight.position.x - Camera.main.orthographicSize * Camera.main.aspect), Mathf.Clamp(newPos.y, BottomRight.position.y + Camera.main.orthographicSize, topLeft.position.y - Camera.main.orthographicSize), -10);
        }
    }
}
