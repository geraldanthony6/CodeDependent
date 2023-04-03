using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class VRPlayerController : MonoBehaviour
{
    [SerializeField]private GameObject playerVisual;
    private PhotonView view;
    [SerializeField]private GameObject cameraOffset;
    [SerializeField]private LocomotionSystem LocomotionSystem;
    [SerializeField]private ActionBasedContinuousMoveProvider ActionBasedContinuousMoveProvider;
    [SerializeField]private ActionBasedContinuousTurnProvider ActionBasedContinuousTurnProvider;
    [SerializeField]private CharacterControllerDriver CharacterControllerDriver;
    [SerializeField]private CharacterController CharacterController;
    [SerializeField] private XRRayInteractor rightHand;
    [SerializeField] private XRRayInteractor leftHand;
    public GameObject xrOrigin;
    

    private void Awake() {
        view = GetComponent<PhotonView>();
    } 
    // Start is called before the first frame update
    void Start()
    {   
        if(view.IsMine){  
            cameraOffset.SetActive(true);
            LocomotionSystem.enabled = true;
            ActionBasedContinuousMoveProvider.enabled = true;
            ActionBasedContinuousTurnProvider.enabled = true;
            CharacterControllerDriver.enabled = true;
            rightHand.interactionManager = GameObject.FindObjectOfType<XRInteractionManager>();
            leftHand.interactionManager = GameObject.FindObjectOfType<XRInteractionManager>();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
