﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target; // ターゲットへの参照
    private Vector3 offset; // 相対座標
    void Start()
    {
        //自分自身と target との相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
    }
    void Update()
    {
        // 自分自身の座標に、target の座標に相対座標を足した値を設定する
    GetComponent<Transform>().position =
target.position + offset;
    }
}
