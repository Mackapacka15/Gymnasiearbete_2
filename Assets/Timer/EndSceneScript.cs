using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneScript : MonoBehaviour
{
    public EndScript endScript;
    public GameObject afterWall;
    
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        endScript.FromEndSceneTrigger();
        afterWall.SetActive(true);
    }
}
