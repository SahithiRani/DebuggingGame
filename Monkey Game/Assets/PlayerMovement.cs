using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public bool jump = false;
    Vector3 End_pos;
    Vector3 Start_pos;
    // Update is called once per frame
    public void Jump()
    {
        jump = true;
        controller.Move(Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void moveForward(){
        Start_pos = transform.position;
        End_pos = transform.position + new Vector3(700,0,0);
        transform.position = Vector3.Lerp(Start_pos, End_pos, 0.01f);
    }
}
