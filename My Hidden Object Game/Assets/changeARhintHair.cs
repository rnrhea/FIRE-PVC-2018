

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to Hair Hint", "changing to AR scene")]

public class changeARhintHair : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("ARhintHair");
    }
}
