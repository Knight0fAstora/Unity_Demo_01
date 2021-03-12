using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        var motor = GetComponent<CharacterMotor>();
        if (motor == null)
            return;

        if (Input.GetKey(KeyCode.W))
        {
            motor.InputMovement(0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            motor.InputMovement(0, -1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            motor.InputMovement(-1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            motor.InputMovement(1, 0);
        }
        else
            motor.IsWalking = false;

    }
}
