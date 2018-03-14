using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPendulum : MonoBehaviour {
    public GameObject pendulum;

    public void Spawn()
    {
        Vector3 Position = new Vector3(0, 0.89f, -8.66f);
        
        pendulum =Instantiate(Resources.Load("Pendulum"), Position, Quaternion.identity) as GameObject;
        pendulum.name = "Pendulum1";
    }
  
 }

