using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyManager : MonoBehaviour
{
    [SerializeField] BabyMoustachioNPC friendlyBabyConvo;
    [SerializeField] BabyMoustachioLockedOut lockedOutBabyConvo;
    [SerializeField] BabyMoustachioTrickedOut trickedOutBabyConvo;

    // Start is called before the first frame update
    void Start()
    {
        friendlyBabyConvo.enabled = true;
        lockedOutBabyConvo.enabled = false;
        trickedOutBabyConvo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GotLockedOut()
    {
        friendlyBabyConvo.enabled = false;
        lockedOutBabyConvo.enabled = true;
    }

    public void GotTrickedOut()
    {
        friendlyBabyConvo.enabled = false;
        trickedOutBabyConvo.enabled = true;
        // TODO: Add can move here
    }
}
