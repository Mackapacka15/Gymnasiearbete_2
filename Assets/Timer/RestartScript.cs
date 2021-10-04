using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Manager.Load(Manager.Scene.Menu);
    }
}
