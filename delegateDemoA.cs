using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateDemoA : MonoBehaviour {


    //声明委托类型，以及对应的事件
    public delegate void DoSomething();
    public event DoSomething UserMouseLeftDown;
    public event DoSomething UserMouseRightDown;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //左右鼠标按下，触发这个事件，但具体做什么，由脚本B为事件添加具体功能。


        if (Input.GetMouseButton(0)) {


            UserMouseLeftDown();

        }

        if (Input.GetMouseButton(1)) {


            UserMouseRightDown();
        }



	}




}
