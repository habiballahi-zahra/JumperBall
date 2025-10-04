using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public LogicController Logic;
    [SerializeField] private Rigidbody2D myRigidbody;

    [SerializeField] private float JumpSpeed;

     public bool ActiveBall=true; 
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && ActiveBall == true)
        {
            Jumping();
        }

        if (transform.position.y > 2 || transform.position.y < -2)
        { 
             Logic.GameOver();
        }
    }

    void Jumping()
    {
        myRigidbody.velocity = Vector2.up * JumpSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.GameOver();
       
    }
}
