using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Scene", "chnage to BucketHint", "changing to AR scene")]

public class BucketHint : Command
{

    public override void OnEnter(){
        Application.LoadLevel ("ARhint_Bucket");
    }
}
