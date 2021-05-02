using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyManager : MonoBehaviour
{
    [SerializeField] BabyMoustachioNPC friendlyBabyConvo;
    [SerializeField] BabyMoustachioLockedOut lockedOutBabyConvo;
    [SerializeField] BabyMoustachioTrickedOut trickedOutBabyConvo;
    MeshRenderer babyCanRenderer;
    MeshRenderer kidCanRenderer;


    // Start is called before the first frame update
    void Start()
    {
        friendlyBabyConvo.enabled = true;
        lockedOutBabyConvo.enabled = false;
        trickedOutBabyConvo.enabled = false;

        babyCanRenderer = GameObject.FindGameObjectWithTag("BabyCan").GetComponentInChildren<MeshRenderer>();
        babyCanRenderer.enabled = true;

        kidCanRenderer = GameObject.FindGameObjectWithTag("KidCan").GetComponentInChildren<MeshRenderer>();
        kidCanRenderer.enabled = false;
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
        
        // Disabled baby can
        
        babyCanRenderer.enabled = false;

        // Enable kid can
        
        kidCanRenderer.enabled = true;
    }
}
