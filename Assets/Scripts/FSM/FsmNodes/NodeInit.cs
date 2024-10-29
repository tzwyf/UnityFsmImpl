using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeInit : IFsmNode
{
    public void OnEnter()
    {
        Debug.Log("NodeInit OnEnter");

        FsmController.Instance.Run("Login");
    }

    public void OnExit()
    {
        Debug.Log("NodeInit OnExit");
    }

    public void OnFixUpdate()
    {
        // throw new System.NotImplementedException();
    }

    public void OnHandleMsg()
    {
        // throw new System.NotImplementedException();
    }

    public void OnUpdate()
    {
        // throw new System.NotImplementedException();
    }
}
