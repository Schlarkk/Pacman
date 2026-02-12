using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeInteraction : MonoBehaviour
{

    public GameObject Player;
    PlayerMovement playerMovement;

    public GameObject Pacman;
    Animator pacAnim;

    public GameObject PacmanPlayer;
    PacmanMovement pacmanMovement;

    bool isInteracting = false;

    void Start()
    {
        pacAnim = Pacman.GetComponent<Animator>();
        playerMovement = Player.GetComponent<PlayerMovement>();
        pacmanMovement = PacmanPlayer.GetComponent<PacmanMovement>();
    }

    void Update()
    {
        //check for player in range of 1.5 units
        if(Vector3.Distance(transform.position, Player.transform.position) < 1.5f)
        {
            Interact();
        }
    }

    void Interact()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            pacAnim.SetBool("PRESSED", !isInteracting);
            isInteracting = !isInteracting;
            playerMovement.enabled = !isInteracting;
            pacmanMovement.enabled = isInteracting;
        }
        
    }
}
