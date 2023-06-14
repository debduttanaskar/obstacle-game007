using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed =10;
    //these variables change our movemen speed
     
    

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");


    }

    void MovePlayer()
    {
        float zvalue =Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xvalue =Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue,0,zvalue);

    }
}
