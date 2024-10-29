using System.Collections;
using System.Collections.Generic;

public class FsmMachine
{
    // 定义一个数据结构来存放节点
    private Dictionary<string, IFsmNode> stateNodes = new Dictionary<string, IFsmNode>();

    private IFsmNode curNode = null;

    /// <summary>
    /// 向状态机中添加状态节点
    /// </summary>
    /// <param name="name"></param>
    /// <param name="node"></param>
    /// <returns></returns>
    public bool AddNode(string name, IFsmNode node)
    {
        if (this.stateNodes.ContainsKey(name))
        {
            return false;
        }

        this.stateNodes.Add(name, node);

        return true;
    }

    /// <summary>
    /// 运行状态机中的状态节点
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public bool RunNode(string name)
    {
        if (!this.stateNodes.ContainsKey(name))
        {
            return false;
        }

        if(this.curNode != null)
        {
            this.curNode.OnExit();
        }

        this.curNode = this.stateNodes[name];
        this.curNode.OnEnter();

        return true;
    }

    /// <summary>
    /// 迭代所有节点的Update
    /// </summary>
    public void OnUpdate()
    {
        if(this.curNode != null)
        {
            this.curNode.OnUpdate();
        }
    }
    public void OnFixUpdate()
    {
        if (this.curNode != null)
        {
            this.curNode.OnFixUpdate();
        }
    }
    public void OnHandleMsg()
    {
        if (this.curNode != null)
        {
            this.curNode.OnHandleMsg();
        }
    }
}
