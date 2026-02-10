using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject Camera;
    CameraFollowPlayer cam;


    void Start()
    {
        cam = Camera.GetComponent<CameraFollowPlayer>();
    }


    void Update()
    {
        PlayerInput();
    }


    void PlayerInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
            cam.StartFollow(0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
            cam.StartFollow(0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
            cam.StartFollow(0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
            cam.StartFollow(0);
        }
    }



}
