using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed =8f;
    public CharacterController CharController;
    public GameObject Player;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        CharController = Player.GetComponent<CharacterController>();
        
        cam = Camera.main;
        cam=  this.GetComponent<Camera>();

        if (CharController == null)
            Debug.Log("There is no character attached");

        //if there was not any attched character

        
    }

    // Update is called once per frame
    void Update()
    {


        //get movement input

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //move the character based on the input

        Vector3 movement = Vector3.forward * vertical + Vector3.right * horizontal;
        CharController.Move(movement*Time.deltaTime*speed);
        //mouse input

        //movement based on mouse input
    }
}
