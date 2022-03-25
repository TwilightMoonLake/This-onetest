using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//判断天气类型，得到天气类型的bool值
// 判断动物类型→判断动物年龄阶段→判断动物行为
/* 动物行为的行为分为正常天气Clear的行为以及非Clear下的行为
 * 非clear天气下判断具体天气类型，然后编写具体行为
 * 动物行为分为共同行为和特异行为
 */
public enum AnimalStates //动物的行为
{
    NORMAL,         //正常行为状态
    INWEATHER,      //天气影响下的行为状态
    DEAD            //死亡
}
public enum AnimalAge //动物的年龄状态
{
    YOUNG,          //幼年期
    ADULT,          //成熟期
    OLD             //老年
}
public enum AnimalType
{
    //后续添加
    
}
public class AnimalManage : MonoBehaviour
{
    private AnimalBehavior animalBehavior;
    private CharacterState characterState;
    private AnimalStates animalStates;
    private AnimalAge animalAge;
    private AnimalType animalType;
    [Header("State and animal behavior")]
    private bool isNORMAL;
    private bool isINWEATHER;
    private bool isDEAD;
    [Header("State and animal age")]
    private bool isYOUNG;
    private bool isADULT;
    private bool isOLD;

    private void Awake()
    {
    }

    void SwitchAnimalType()
    {
        
        switch (animalType)
        {
            
            case AnimalType:
                JudgeAnimalAge();
                break;
            
        }
    }
    void JudgeAnimalAge()
    {
        switch (animalAge)
        {
            case AnimalAge.YOUNG:
                
                
                break;
            case AnimalAge.ADULT:
                SwitchAnimalStates();
                break;
            case AnimalAge.OLD:
                break;
        }
    }
    void SwitchAnimalStates()
    {
        switch (animalStates)
        {
            case AnimalStates.NORMAL:
                break;
            case AnimalStates.INWEATHER:
                break;
            case AnimalStates.DEAD:
                break;
        }
    }
    void AnimalNormal()
    {

        //以上共同行为
        switch (animalType)
        {
            case AnimalType:
                break;       
        }
        //以上为特异行为
        
    }
    void AnimalInWeather()
    {
        #region 共通各种天气行为
        if (characterState.isCloudy)
        {

        }
        else if (characterState.isFoggy)
        {
            
        }
        else if (characterState.isRain)
        {

        }
        else if (characterState.isHeavyRain)
        {

        }
        else if (characterState.isSnow)
        {

        }
        else if (characterState.isRedAroras)
        {

        }
        else if (characterState.isBlueAroras)
        {

        }
        #endregion
        #region 某种动物在特殊天气下的特殊行为
        switch (animalType)
        {
            case AnimalType:
                if (characterState.isFoggy) //比如某种动物在大雾下的行为
                {
                    //调用方法
                    
                }
                break;
        }
        #endregion
    }
    void AnimalDead()
    {
        
    }
}
