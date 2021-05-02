using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PassengerManager : MonoBehaviour
{
    [SerializeField] Transform followPoint;
    [SerializeField] BoatController boatRef;
    [SerializeField] Camera cam1, cam2;
    [SerializeField] Transform victim, victimEndPoint;
    [SerializeField] TextMeshPro victimName;
    [SerializeField] Transform player;
    [SerializeField] float endFallSpeed;
    [SerializeField] NVIDIA.Flex.FlexSourceActor flex;
    public Transform currentPassenger;
    ExampleNPC currentPassengerScript;
    Collider2D currentPassengerCol;
    WalkFromPointToPoint currentPassengerWalkin;
    bool endCutscenePlaying = false;
    // Start is called before the first frame update
    public void Start()
    {
        CameraFade.StartAlphaFade(Color.black, true, 7f);
        cam1.GetComponent<CameraFollow>().enabled = false;
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
        if (currentPassengerScript && !endCutscenePlaying)
        {
            currentPassenger.position = new Vector3(followPoint.position.x, followPoint.position.y, currentPassenger.transform.position.z);
        }

        if (endCutscenePlaying)
        {
            victim.position = Vector3.MoveTowards(victim.position, victimEndPoint.position, endFallSpeed * Time.deltaTime);
        }

        if (Input.GetButtonUp("Restart"))
        {
            flex.isActive = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetButtonUp("Cancel")) {
            print("quitting");
            flex.isActive = false;
            SceneManager.LoadScene("FrontPage", LoadSceneMode.Single);
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
        flex.isActive = true;
        CameraFade.StartAlphaFade(Color.black, false, 7f);
        victimName.text = currentPassengerScript.NPCName;
        currentPassenger.parent = victim;
        currentPassenger.localPosition = Vector3.zero;
        currentPassenger.localEulerAngles = Vector3.zero;
        endCutscenePlaying = true;
        followPoint.GetComponent<ParticleSystem>().Play();
        Invoke("ShowMeTheMoney", 3f);
    }

    public void EndTheGameWithPlayer()
    {

        boatRef.enabled = false;
        CameraFade.StartAlphaFade(Color.black, false, 7f);
        victimName.text = "You, The Soup Goblin";
        player.parent = victim;
        player.localEulerAngles = Vector3.zero;
        player.localPosition = Vector3.zero;
        endCutscenePlaying = true;
        boatRef.GetComponent<ParticleSystem>().Play();
        cam1.GetComponent<CameraFollow>().enabled = false;
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
        cam1.GetComponent<CameraFollow>().enabled = true;
    }
}
