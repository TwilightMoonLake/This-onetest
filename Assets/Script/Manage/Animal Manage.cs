using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//�ж��������ͣ��õ��������͵�boolֵ
// �ж϶������͡��ж϶�������׶Ρ��ж϶�����Ϊ
/* ������Ϊ����Ϊ��Ϊ��������Clear����Ϊ�Լ���Clear�µ���Ϊ
 * ��clear�������жϾ����������ͣ�Ȼ���д������Ϊ
 * ������Ϊ��Ϊ��ͬ��Ϊ��������Ϊ
 */
public enum AnimalStates //�������Ϊ
{
    NORMAL,         //������Ϊ״̬
    INWEATHER,      //����Ӱ���µ���Ϊ״̬
    DEAD            //����
}
public enum AnimalAge //���������״̬
{
    YOUNG,          //������
    ADULT,          //������
    OLD             //����
}
public enum AnimalType
{
    //�������
    
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

        //���Ϲ�ͬ��Ϊ
        switch (animalType)
        {
            case AnimalType:
                break;       
        }
        //����Ϊ������Ϊ
        
    }
    void AnimalInWeather()
    {
        #region ��ͨ����������Ϊ
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
        #region ĳ�ֶ��������������µ�������Ϊ
        switch (animalType)
        {
            case AnimalType:
                if (characterState.isFoggy) //����ĳ�ֶ����ڴ����µ���Ϊ
                {
                    //���÷���
                    
                }
                break;
        }
        #endregion
    }
    void AnimalDead()
    {
        
    }
}
