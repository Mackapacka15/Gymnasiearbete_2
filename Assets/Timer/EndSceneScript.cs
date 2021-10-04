using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneScript : MonoBehaviour
{
    public EndScript endScript;
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        endScript.FromEndSceneTrigger();
    }
}
