using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : AnimalManage
{
    //该部分内容用于动物行为的编写
    CharacterState characterState;//调用数据
    #region 动物基础行为
    void AnimalMove(CharacterState characterState)//控制动物移动
    {

    }
    void AnmialFly()//控制动物飞行，飞行类动物调用该方法
    {

    }
    void AnimalRun(CharacterState characterState)//控制动物快速移动
    {

    }
    void AnimalJump()//控制动物跳跃
    {

    }
    void AnimalSwim()//控制动物游泳，水族类生物调用
    {
        
    }
    void AnimalSound()//控制动物叫声
    {

    }
    void AnimalEat()//控制动物进食
    {

    }
    void AnimalSleep()//控制动物睡眠
    {

    }
    void AnimalPlayWithPlayer()//控制动物与玩家的互动
    {

    }
    void AnimalReproduction()//控制动物繁殖
    {

    }

    #endregion
    #region 动物在天气天下的行为
    void AnimalFear()//动物害怕，行为行为静止，该状态可应用于雷雨天气
    {
        
    }
    void AnimalGather() //动物聚集，可应用于下雪天
    {
        
    }
    void AnimalSpecialSound()//动物特殊叫声，在雨天或者其他天气时调用
    {
        
    }
    void AnimalFight()//动物打架
    {
        
    }
    void AnimalTest()
    {
        Debug.Log("Test");
    }


    #endregion
    

}
