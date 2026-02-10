using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject Player;



    public void StartFollow(int direction)
    {
        new WaitForSeconds(0.5f);

        transform.position = Player.transform.position + new Vector3(0, 0, -6);        
    }



}
