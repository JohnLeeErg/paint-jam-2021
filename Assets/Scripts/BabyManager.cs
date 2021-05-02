using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyManager : MonoBehaviour
{
    [SerializeField] BabyMoustachioNPC friendlyBabyConvo;
    [SerializeField] BabyMoustachioLockedOut lockedOutBabyConvo;
    bool lockedOut;

    // Start is called before the first frame update
    void Start()
    {
        lockedOut = false;
        friendlyBabyConvo.enabled = true;
        lockedOutBabyConvo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lockedOut == true)
        {
            friendlyBabyConvo.enabled = false;
            lockedOutBabyConvo.enabled = true;
        }

    }

    public void GotLockedOut()
    {
        lockedOut = true;
    }
}
