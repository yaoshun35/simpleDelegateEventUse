using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateUseB : MonoBehaviour {


    //拿到脚本A
    public delegateDemoA da;



    //装载，卸载脚本A上的事件。
    //在这里定义具体的办法。
    private void OnEnable()
    {
        da.UserMouseLeftDown += left;
        da.UserMouseRightDown += Right;
    }


    private void OnDisable()
    {
        da.UserMouseLeftDown -= left;
        da.UserMouseRightDown -= Right;
    }



    public void left() {

        Debug.Log("left!");
    }

    public void Right()
    {

        Debug.Log("Right!");
    }

}
