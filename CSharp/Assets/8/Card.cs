﻿using UnityEngine;
using UnityEngine.EventSystems;  //引用 事件 API － 拖拉介面


// 實作介面後也要實作介面所有成員
public class Card : MonoBehaviour, IBeginDragHandler , IDragHandler ,IEndDragHandler ,ISkill
{

    private Vector3 pos;
    public void OnBeginDrag(PointerEventData eventData)
    {

        print("開始拖拉");
        pos = transform.position;


    }

    public void OnDrag(PointerEventData eventData)
    {
        print("拖拉");
        transform.position = eventData.position; //座標  =拖拉事件.座標

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("拖拉結束");
        transform.position = pos;
    }

    public void SkillEffect()
    {
        

    }
       
}
