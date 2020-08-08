
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to LadyHint", "changing to AR scene")]

public class LadyHint : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("ARhint_Lady");
    }
}
