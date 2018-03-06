using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack_p1_buttonCTRL : MonoBehaviour {

    GameObject Ref_to_attack;
    public Button player1_Attack;
    public Button player2_Attack;
    public void Update()
    {

        Ref_to_attack = GameObject.Find("Attack/dodge");
        Attack something = Ref_to_attack.GetComponent<Attack>();
        if (something.currentPlayer == 1)
        {
            Debug.Log("lalala");
            
        }
           
    }

    
}
