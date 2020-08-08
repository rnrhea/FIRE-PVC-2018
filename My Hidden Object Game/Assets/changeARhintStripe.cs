using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to stripe Hint", "changing to AR scene")]

public class changeARhintStripe : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("ARhintStripe");
    }
}
