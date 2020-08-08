using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to hint1", "changing to AR scene")]

public class changeARhint1 : Command
{

    public override void OnEnter(){
        Application.LoadLevel ("ARhint1");
    }
}
