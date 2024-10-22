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
    private string LabelText = ("Name: \nAge: \nPhysical Damage: \n\rArmor: \nLuck: \n\rIntelligence: \n\rSpeed: ");
    private GUIStyle FontSize;

    public Player1 Player1;
    public Player2 Player2;
    public Player3 Player3;


    private void OnGUI()
    {

        

        Player1 = new Player1();
        Player2 = new Player2();
        Player3 = new Player3();


        FontSize = new GUIStyle(GUI.skin.label);
        FontSize.fontSize = 30;



        #region gg
        GUI.Box(new Rect(Proposition, Size), "");

        GUI.Box(new Rect(58, 35, 1339, 662), "");

        if (GUI.Button(new Rect(110, 71, 236, 158), "Player 1"))
        {
            LabelText = ("Name: " + Player1.Name + "\nAge: " + Player1.age + "\nPhysical Damage: " + Player1.damage + "\n\rArmor: " + Player1.armor + "\nLuck: " + Player1.luck + "\n\rIntelligence: " + Player1.intelligence + "\n\rSpeed: " + Player1.speed);
        }

        if (GUI.Button(new Rect(110, 300, 236, 158), "Player 2"))
        {
            LabelText = ("Name: " + Player2.Name + "\nAge: " + Player2.age + "\nPhysical Damage: " + Player2.damage + "\n\rArmor: " + Player2.armor + "\nLuck: " + Player2.luck + "\n\rIntelligence: " + Player2.intelligence + "\n\rSpeed: " + Player2.speed);
        }


        if (GUI.Button(new Rect(110, 501, 236, 158), "Player 3"))
        {
            LabelText = ("Name: " + Player3.Name + "\nAge: " + Player3.age + "\nPhysical Damage: " + Player3.damage + "\n\rArmor: " + Player3.armor + "\nLuck: " + Player3.luck + "\n\rIntelligence: " + Player3.intelligence + "\n\rSpeed: " + Player3.speed);
        }
        #endregion

        GUI.Label(new Rect(800, 200, 500, 500), LabelText, FontSize);

    }

}
