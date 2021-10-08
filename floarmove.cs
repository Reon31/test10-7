using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floarmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");  //左右のスティックを押し続けているかを判定する値を変数に代入
        if (h == -1)//-1(左に傾けたら）
        {
            transform.Rotate(new Vector3(0, 0, -1));//左に傾く
        }
    }
}
