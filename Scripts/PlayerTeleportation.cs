using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Transform))]

public class PlayerTeleportation : MonoBehaviour
{
    [SerializeField] private InputActionReference  TeleportLeftActionReference;
    [SerializeField] private InputActionReference  TeleportCenterActionReference;
    [SerializeField] private InputActionReference  TeleportRightActionReference;
    [SerializeField] private InputActionReference  TeleportTopActionReference;

    [SerializeField] private Transform teleportLeft_Position;
    [SerializeField] private Transform teleportCenter_Position;
    [SerializeField] private Transform teleportRight_Position;
    [SerializeField] private Transform teleportTop_Position;
    [SerializeField] private GameObject teleportationEffect;

    [SerializeField] private Transform effectSpawnLeft,effectSpawnRight,effectSpawnCenter,effectSpawnTop;

   
    


      private Transform body_position;
    // Start is called before the first frame update
    void Start()
    {
        body_position = GetComponent<Transform>();
        TeleportLeftActionReference.action.performed += OnTeleportLeft;
        TeleportCenterActionReference.action.performed += OnTeleportCenter;
        TeleportRightActionReference.action.performed += OnTeleportRight;
        TeleportTopActionReference.action.performed += OnTeleportTop;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTeleportLeft(InputAction.CallbackContext obj)
    {   GameObject var = Instantiate(teleportationEffect,effectSpawnLeft.position,effectSpawnLeft.rotation);
            var.GetComponent<ParticleSystem>().Play();
            StartCoroutine(TeleportDelay());
        body_position.position = teleportLeft_Position.position;    
        body_position.rotation = teleportLeft_Position.rotation;
       
    }

    private void OnTeleportCenter(InputAction.CallbackContext obj)
    {    GameObject var = Instantiate(teleportationEffect,effectSpawnCenter.position,effectSpawnCenter.rotation);
            var.GetComponent<ParticleSystem>().Play();
            StartCoroutine(TeleportDelay());
           body_position.position = teleportCenter_Position.position;
        body_position.rotation = teleportCenter_Position.rotation;
        
    }
    private void OnTeleportRight(InputAction.CallbackContext obj)
    {   GameObject var = Instantiate(teleportationEffect,effectSpawnRight.position,effectSpawnRight.rotation);
            var.GetComponent<ParticleSystem>().Play();
            StartCoroutine(TeleportDelay());
         body_position.position = teleportRight_Position.position;
        body_position.rotation = teleportRight_Position.rotation; 
        
    }
    private void OnTeleportTop(InputAction.CallbackContext obj)
    {   GameObject var = Instantiate(teleportationEffect,effectSpawnTop.position,effectSpawnTop.rotation);
            var.GetComponent<ParticleSystem>().Play();
            StartCoroutine(TeleportDelay());
          body_position.position = teleportTop_Position.position;
        body_position.rotation = teleportTop_Position.rotation;
       
    }
    // for adding a delay in the teleportation after the effect has been played
    IEnumerator TeleportDelay()
    {
        yield   return new WaitForSeconds(2);
    }

   

    

}
