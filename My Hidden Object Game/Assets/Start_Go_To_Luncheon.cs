using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "Start->Luncheon", "changing scene")]

public class Start_Go_to_Luncheon : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("Luncheon");
    }
}





