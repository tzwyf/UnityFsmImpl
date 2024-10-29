using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FsmController : MonoBehaviour
{
    private FsmMachine fsmMachine = new FsmMachine();

    public static FsmController Instance = null;

    public void Init()
    {
        DontDestroyOnLoad(this.gameObject);

        FsmController.Instance = this;

        // 添加节点
        fsmMachine.AddNode("Init", new NodeInit());
        fsmMachine.AddNode("Login", new NodeLogin());
        fsmMachine.AddNode("Fight", new NodeFight());
        // end
    }

    public void Run(string name)
    {
        this.fsmMachine.RunNode(name);
    }

    private void Update()
    {
        fsmMachine.OnUpdate();
    }

    private void FixedUpdate()
    {
        fsmMachine.OnFixUpdate();
    }
}
