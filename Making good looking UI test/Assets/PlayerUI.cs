using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public static GameObject p1Healths;
    public static GameObject p1Exps;
    public static GameObject p2Healths;
    public static GameObject p2Exps;
    public GameObject p1Health;
    public GameObject p1Exp;
    public GameObject p2Health;
    public GameObject p2Exp;


    void Awake(){
        p1Healths = p1Health;
        p1Exps = p1Exp;
        p2Healths = p2Health;
        p2Exps = p2Exp;
    }

    public static void SetP1Health(int valueToSet){
        PlayerUI.p1Healths.GetComponent<Slider>().value = valueToSet;
    }
    public static void SetP1Exp(int valueToSet){
        PlayerUI.p1Exps.GetComponent<Slider>().value = valueToSet;
    }
    public static void SetP2Health(int valueToSet){
        PlayerUI.p2Healths.GetComponent<Slider>().value = valueToSet;
    }
    public static void SetP2Exp(int valueToSet){
        PlayerUI.p2Exps.GetComponent<Slider>().value = valueToSet;
    }


    public static void ChangeP1Health(int change){
        PlayerUI.p1Healths.GetComponent<Slider>().value += change;
    }
    public static void ChangeP1Exp(int change){
        PlayerUI.p1Exps.GetComponent<Slider>().value += change;
    }
    public static void ChangeP2Health(int change){
        PlayerUI.p2Healths.GetComponent<Slider>().value += change;
    }
    public static void ChangeP2Exp(int change){
        PlayerUI.p2Exps.GetComponent<Slider>().value += change;
    }



}
