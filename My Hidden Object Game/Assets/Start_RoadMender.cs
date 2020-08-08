using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "Start->RoadMender", "changing scene")]

public class Start_RoadMender : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("RoadMender");
    }
}
