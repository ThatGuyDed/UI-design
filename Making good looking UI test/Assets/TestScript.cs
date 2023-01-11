using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            PlayerUI.SetP1Health(100);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            PlayerUI.SetP1Exp(100);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            PlayerUI.SetP2Health(100);
        }
        if(Input.GetKeyDown(KeyCode.R)){
            PlayerUI.SetP2Exp(100);
        }
        if(Input.GetKeyDown(KeyCode.T)){
            PlayerUI.ChangeP1Health(-10);
        }
        if(Input.GetKeyDown(KeyCode.Y)){
            PlayerUI.ChangeP1Exp(-10);
        }
        if(Input.GetKeyDown(KeyCode.U)){
            PlayerUI.ChangeP2Health(-10);
        }
        if(Input.GetKeyDown(KeyCode.I)){
            PlayerUI.ChangeP2Exp(-10);
        }
    }
}
