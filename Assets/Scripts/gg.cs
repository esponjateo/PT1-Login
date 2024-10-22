using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gg : MonoBehaviour
{

/*
    private string Goodgame = "Hello";

     void OnGUI()
     {
        Goodgame = GUI.TextField(new Rect(500,500,500,500), Goodgame);
     }*/


    private bool Any = true;

    void OnGUI()
    {
        Any = GUI.Toggle(new Rect(500, 500, 500, 500), Any, "AAA");
        if (Any)
        Debug.Log("Togglebool is true");
        else
        Debug.Log("Togglebool is false");

        

    }

}
