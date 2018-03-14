﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Attack_Dodge : MonoBehaviour
{
    bool Pend = false;          //Keeps track to when the pendulum is moving right and left.

    public bool isMoving = true;       //Keeps track to when the pendulum is moving and when it stopped.

    public bool Hit;
    public bool Dodge;
    public GameObject AttackRef;

    void Start()
    {
        Hit = false;
        Dodge = false;
    }

    void FixedUpdate()
    {
        StopPendulum();

        if (isMoving == true)           //Keeps the pendulum moving until you tap to stop it.
        {
            if (Pend == false)
            {

                if (transform.eulerAngles.z <= 46 || transform.eulerAngles.z > 315)
                {
                    transform.Rotate(0, 0, -1);                      //When the pendulum rotation is between those values it moves to the left.
                                                                     //Until it reaches -45 degrees.
                }
                else if (transform.eulerAngles.z == 315)
                {
                    Pend = true;

                }

            }
            else if (Pend == true)
            {
                if (transform.eulerAngles.z < 45 || transform.eulerAngles.z >= 315)
                {                                                                   //Here is moving to the right until it reaches 46 degrees.
                    transform.Rotate(0, 0, 1);                                      //Then will start moving to the left again.

                }
                else if (transform.eulerAngles.z == 46)
                {
                    Pend = false;

                }

            }
        } else if (isMoving == false)
        {
            Destroy(GameObject.FindWithTag("WORK"), 1);
        }
    }

   public void StopPendulum()

    //When you click you trigger the bool that keeps tracking the movement, and then it calculates the angle of the pendulum
    // to know if it's an attack dodge or miss.
    //We can add more attacks and dodges at different angles or even change the shape and the movement angles of the pendulum.
    {
        if (Input.GetKeyDown("mouse 0"))
        {
            AttackRef = GameObject.Find("Attack/dodge");
            Attack something = AttackRef.GetComponent<Attack>();
            isMoving = false;
            if (transform.eulerAngles.z <= 40 && transform.eulerAngles.z >= 22)
            {
                if (something.is1Clicked == true)
                {
                    something.Attack1Success = true;
                    something.Dodge1Success = false;
                }

                if (something.is2Clicked == true)
                {
                    something.Attack2Success = true;
                    something.Dodge2Success = false;
                }

            }
            else if (transform.eulerAngles.z <= 351 && transform.eulerAngles.z >= 330)
            {
                
                if (something.is1dClicked == true)
                {
                    something.Attack1Success = false;
                    something.Dodge1Success = true;
                } 
                if (something.is2dClicked == true)
                {
                   something.Attack2Success = false;
                   something.Dodge2Success = true;
                }  
           } 
       }
    }
}
