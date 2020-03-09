using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    private CharacterController characterController;

        float vMovement = 0f;
        float hMovement = 0f;
        
        Vector3 movement = Vector3.zero;

        public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (true/*characterController.isGrounded*/){

            vMovement = Input.GetAxis("Vertical");
            hMovement = Input.GetAxis("Horizontal");

            movement = new Vector3(hMovement * speed, 0f, vMovement * speed);

        }

        characterController.Move(movement * Time.deltaTime);

    }
}
