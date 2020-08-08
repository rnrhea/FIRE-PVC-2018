
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "Start->BlueRoom", "changing scene")]

public class Start_BlueRoom : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("BlueRoom");
    }
}