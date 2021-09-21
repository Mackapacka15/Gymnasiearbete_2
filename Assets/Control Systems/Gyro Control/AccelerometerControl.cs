using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerControl : MonoBehaviour
{
    private float dirX;
    public float moveSpeed = 20f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        player.transform.position = new Vector2(transform.position.x + dirX, transform.position.y);
    }
}
