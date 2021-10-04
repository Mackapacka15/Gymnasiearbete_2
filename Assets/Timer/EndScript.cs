using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public movementScript playerMoveController;
    public Animator playerAnimator;
    public CharacterController2D playerController;
    public GameObject player;
    public TimerScript timer;
    public Camera mainCam;
    public Camera endCam;
    bool isAcitve = false;
    
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if(isAcitve == false)
        {
            playerMoveController.enabled = false;
            playerAnimator.SetBool("Climb", true);
            isAcitve = true;
            timer.StopTimerRecordTime();
        }
    }
    private void FixedUpdate() 
    {
        if(isAcitve == true)
        {
            ActiveLoop();
        }
    }
    private void ActiveLoop()
    {
        playerController.Move(50 * Time.fixedDeltaTime, false, false);
        player.transform.position += new Vector3(0, 0.1f, 0);
        
    }
    public void FromEndSceneTrigger()
    {
        if(isAcitve == true)
        {
            isAcitve = false;
            playerMoveController.enabled = true;
            playerAnimator.SetBool("Climb", false);
            mainCam.enabled = false;
            endCam.enabled = true;
        }
    }
}