using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeFight : IFsmNode
{
    public void OnEnter()
    {
        Debug.Log("NodeFight OnEnter");

        SceneManager.LoadScene("Town");
    }

    public void OnExit()
    {
        Debug.Log("NodeFight OnExit");
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
