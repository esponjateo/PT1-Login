using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Ui : MonoBehaviour
{
    public Texture2D Image;
    public Vector2 Proposition;
    public Vector2 Size;
    private string LabelText;
    private GUIStyle FontSize;

    public Player1 Player1;


    private void OnGUI()
    {

        Player1 = new Player1();

        FontSize = new GUIStyle(GUI.skin.label);
        FontSize.fontSize = 30;



        #region gg
        GUI.Box(new Rect(Proposition, Size), "");

        GUI.Box(new Rect(58, 35, 1339, 662), "");

        if (GUI.Button(new Rect(110, 71, 236, 158), "Player 1"))
        {
            LabelText = ("Name: " + Player1.Name + "\nAge: " + Player1.age + "\nPhysical Damage: " + Player1.damage + "\n\rArmor: " + Player1.armor + "\n\rIntelligence: " + Player1.intelligence + "\n\rSpeed: " + Player1.speed);
        }

        if (GUI.Button(new Rect(110, 300, 236, 158), "Player 2"))
        {
            LabelText = "Name: Sunny\n\rAge: 15\n\rPhysical Damage: 20\n\rArmor: 20\n\rIntelligence: 20\n\rSpeed: 9";
        }


        if (GUI.Button(new Rect(110, 501, 236, 158), "Player 3"))
        {
            LabelText = "Name: Basil\n\rAge: 14\n\rPhysical Damage: 15\n\rArmor: 20\n\rIntelligence: 45\n\rSpeed: 5";
        }
        #endregion

        GUI.Label(new Rect(800, 200, 500, 500), LabelText, FontSize);
    }

}
