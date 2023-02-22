using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Script!")]
    [Tooltip("Horizontal Axis")]
    public float hor;
    public float horizontalSpeed = 1;
    public float verticalSpeed = 0.5f;

    [Tooltip("RG")]
    public Rigidbody2D rg;

    void Start()
    {
        rg = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        hor =  Input.GetAxis("Horizontal");
        if (hor > 0) {
            
            rg.AddForce(new Vector2(hor * (horizontalSpeed / 10), verticalSpeed));
            
        }
        else if (hor < 0)
        {
            rg.AddForce(new Vector2(hor * (horizontalSpeed / 10), verticalSpeed));
        }
    }
}
