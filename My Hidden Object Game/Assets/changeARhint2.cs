using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to hint2", "changing to AR scene")]

public class changeARhint2 : Command
{

    public override void OnEnter(){
        Application.LoadLevel ("ARhint2");
    }
}
