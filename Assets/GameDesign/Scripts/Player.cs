using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRigid;
    private float move;

    [SerializeField]
    private float moveSpeed = 10f;
    [SerializeField]
    private float jumpHeight = 5f;


    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>(); // gets the component Rigidbody2D for rb
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal") * moveSpeed;


        //move = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;


        
       

      

    }

    private void FixedUpdate()
    {
        playerRigid.velocity=new Vector2(move, playerRigid.velocity.y);

    }



}
