using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs
{
    // Start is called before the first frame update
    private static NewControls _actions;
    private static ScriptTesting _owner;
    
    public static void BindNewPlayer(ScriptTesting player)
    {
        _owner = player;
    }
    public static void Init(ScriptTesting player) {
        _actions = new NewControls();
        _actions.Player.Look.performed += ctx => _owner.setLook(ctx.ReadValue<Vector2 > ());
        _actions.Player.WalkForward.performed += ctx => _owner.MoveTo(ctx.ReadValue<Vector2 > ());
    }
}