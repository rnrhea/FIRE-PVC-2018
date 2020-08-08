using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "->Start", "changing scene")]

public class GoToStart : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("StartScreen");
    }
}