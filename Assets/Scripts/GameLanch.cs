using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanch : MonoBehaviour
{

    private void Awake()
    {
        // 初始化框架代码
        // end

        this.gameObject.AddComponent<FsmController>().Init();
    }
    void Start()
    {
        // 初始化状态机
        // end

        FsmController.Instance.Run("Init");
    }

}
