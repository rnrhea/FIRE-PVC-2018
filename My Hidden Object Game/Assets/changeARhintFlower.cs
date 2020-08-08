
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to Flower Hint", "changing to AR scene")]

public class changeARhintFlower : Command
{

    public override void OnEnter()
    {
        Application.LoadLevel("ARhintFlower");
    }
}
