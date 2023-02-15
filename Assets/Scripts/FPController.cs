/*
    Test the game mechanics using a non-vr based first person controller
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{
    [SerializeField]private Camera _playerCamera;
    [SerializeField]private float _walkingSpeed = 7f;
   
    //
    [SerializeField]private float _lookSpeed = 2f;
    [SerializeField]private float _lookXLimit = 45f;

    private CharacterController _characterController;
    private Vector3 _moveDirection = Vector3.zero;
    private float _rotationX = 0;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float curSpeedX = _walkingSpeed * Input.GetAxisRaw("Vertical");
        float curSpeedY = _walkingSpeed * Input.GetAxisRaw("Horizontal");
        _moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        _characterController.Move(_moveDirection * Time.deltaTime);

        _rotationX += -Input.GetAxis("Mouse Y") * _lookSpeed;
        _rotationX = Mathf.Clamp(_rotationX, -_lookXLimit, _lookXLimit);
        _playerCamera.transform.localRotation = Quaternion.Euler(_rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * _lookSpeed, 0);
    }
}
