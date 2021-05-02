using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerManager : MonoBehaviour
{
    [SerializeField] Transform followPoint;
    [SerializeField] BoatController boatRef;
    [SerializeField] Camera cam1, cam2;
    public Transform currentPassenger;
    ExampleNPC currentPassengerScript;
    Collider2D currentPassengerCol;
    WalkFromPointToPoint currentPassengerWalkin;
    // Start is called before the first frame update
    public void Start()
    {
        CameraFade.StartAlphaFade(Color.black, true, 7f);
    }
    public void FastenNPC(Transform newPassenger)
    {
        if (currentPassenger!= null)
        {
            ReturnNPC();    
        }
        currentPassenger = newPassenger;
        currentPassengerScript = newPassenger.GetComponentInChildren<ExampleNPC>();
        currentPassengerCol = newPassenger.GetComponent<Collider2D>();
        currentPassengerCol.enabled = false;
        currentPassengerWalkin = newPassenger.GetComponent<WalkFromPointToPoint>();
        if (currentPassengerWalkin)
        {
            currentPassengerWalkin.enabled = false;
        }
        currentPassengerScript.enabled = false;
        
        newPassenger.position = new Vector3(followPoint.position.x, followPoint.position.y, newPassenger.position.z);
    }
    private void Update()
    {
        if (currentPassengerScript)
        {
            currentPassenger.position = new Vector3(followPoint.position.x, followPoint.position.y, currentPassenger.transform.position.z);
        }
    }
    public void ReturnNPC()
    {
        currentPassenger.position = currentPassengerScript.startPosition;
        currentPassengerScript.enabled = true;
        currentPassengerCol.enabled = true;
        if (currentPassengerWalkin)
        {
            currentPassengerWalkin.enabled = true;
        }
        currentPassengerScript = null;
    }

    public void EndTheGameWithCurrentPassenger()
    {
        
        CameraFade.StartAlphaFade(Color.black, false, 7f);

        Invoke("ShowMeTheMoney", 3f);
    }

    public void EndTheGameWithPlayer()
    {

        CameraFade.StartAlphaFade(Color.black, false, 7f);
        Invoke("ShowMeTheMoney", 3f);
    }
    void ShowMeTheMoney()
    {
        CameraFade.SetScreenOverlayColor(Color.black);
        if (cam1 && cam2)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        CameraFade.StartAlphaFade(Color.black, true, 4f);
    }

    public void DisaleBoatInput()
    {
        if (boatRef)
        {
            boatRef.enabled = false;
        }
    }

    public void EnableBoatInput()
    {
        if(boatRef)
            boatRef.enabled = true;
    }
}
