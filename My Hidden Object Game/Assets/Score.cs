

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Fungus;

[CommandInfo("Scripting", "set score", "Plus 1")]

public class Scoring : Command
{


    public override void OnEnter()
    {
        ScoreScript.scoreValue += 1;

    }


}
