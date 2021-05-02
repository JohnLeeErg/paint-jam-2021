using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyManager : MonoBehaviour
{
    [SerializeField] BabyMoustachioNPC friendlyBabyConvo;
    [SerializeField] BabyMoustachioLockedOut lockedOutBabyConvo;
    [SerializeField] BabyMoustachioTrickedOut trickedOutBabyConvo;
    [SerializeField] MoustacheKidNPC sadKidConvo;
    [SerializeField] MoustacheKidHappy happyKidConvo;
    MeshRenderer babyCanRenderer;
    MeshRenderer kidCanRenderer;


    // Start is called before the first frame update
    void Start()
    {
        // Set starter convos
        friendlyBabyConvo.enabled = true;
        lockedOutBabyConvo.enabled = false;
        trickedOutBabyConvo.enabled = false;

        sadKidConvo.enabled = true;
        happyKidConvo.enabled = false;

        // Show baby can, hide kid can
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
        // Switch convos up
        friendlyBabyConvo.enabled = false;
        trickedOutBabyConvo.enabled = true;

        sadKidConvo.enabled = false;
        happyKidConvo.enabled = true;

        
        // Hide baby can
        
        babyCanRenderer.enabled = false;

        // Show kid can
        
        kidCanRenderer.enabled = true;
    }
}
