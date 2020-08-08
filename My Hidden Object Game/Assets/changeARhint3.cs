using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to hint3", "changing to AR scene")]

public class changeARhint3 : Command
{

    public override void OnEnter(){
        Application.LoadLevel ("ARhint3");
    }
}
