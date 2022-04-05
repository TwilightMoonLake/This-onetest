using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalInfectiousDiseases : MonoBehaviour
{
    //如何实现第一只动物生病？特定天气下加初始免疫力低下
    //如果实现其余其他动物生病
    //传染病模块，动物触发感染病
    //如果动物得到了传染病，那么会传染其他同类动物，并较低概率传染非同类动物
    private AnimalBehaviors animalBehaviors;
    public bool animalIsIll;

    void isDiseases()
    {
        animalBehaviors.AnimalFallIll();
    }



}
