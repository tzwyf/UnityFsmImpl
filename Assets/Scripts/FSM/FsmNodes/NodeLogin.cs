using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeLogin : IFsmNode
{
    public void OnEnter()
    {
        Debug.Log("NodeLogin OnEnter");

        SceneManager.LoadScene("Login");
    }

    public void OnExit()
    {
        Debug.Log("NodeLogin OnExit");
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
