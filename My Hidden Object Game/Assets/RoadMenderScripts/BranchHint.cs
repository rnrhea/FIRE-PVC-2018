using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to BranchHint", "changing to AR scene")]

public class BranchHint : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("ARhint_Branch");
    }
}
