using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	C# 语法:
	
	权限访问修饰符：

	public: 公有
	protected: 保护
	private：私有

	【：】 代表继承

*/

public class CubeCtrl : MonoBehaviour
{

	public GameObject cubeGo; //cube游戏对象

	public float moveSpeed = 2f;

	public float rotateSpeed = 20f;

	//在update之前调用， 且被调用一次， 调用时必须保证游戏对象处于
	//激活状态
    // Start is called before the first frame update
    void Start()
    {
    	// 输出语句
        // Debug.Log("Start Start Start");
    }

    //更新函数， 逐帧调用
    // Update is called once per frame
    void Update()
    {
    	// Debug.Log("Update Update Update");

    	//GetAxis: 获取虚拟轴偏移量

    	float hAixsOffset = Input.GetAxis("Horizontal");//-1 ~ 1
    	// Debug.Log("hAixsOffset:  " + hAixsOffset);

    	float vAixsOffset = Input.GetAxis("Vertical");//-1 ~ 1
    	// Debug.Log("vAixsOffset:  " + vAixsOffset);


    	//实现游戏对象cubeGo平移操作
    	cubeGo.transform.Translate(Vector3.forward * vAixsOffset * moveSpeed
    		* Time.deltaTime, Space.Self);

    	//实现游戏对象cubeGo转向操作
    	cubeGo.transform.Rotate(Vector3.up * hAixsOffset * rotateSpeed
    		* Time.deltaTime, Space.World);
        
    }
}
