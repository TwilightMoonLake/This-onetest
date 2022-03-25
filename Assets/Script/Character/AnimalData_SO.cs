using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data", menuName = "Animal Stats/Data")]
public class AnimalData_SO : ScriptableObject
{
    public float speed;     //������ƶ��ٶ�
    public float flySpeed; //����ķ����ٶ�
    public float swimSpeed; //������Ӿ�ٶ�
    public float runSpeed; //������ܲ��ٶ�
    public float jumpSpeed; //�������Ծ�ٶ�
    
    public int maxFavorability; //�øж�
    public int currentFavorability;//��ǰ�øж�
    public int maxHealth;      //����ֵ
    public int currentHealth;   //��ǰ����ֵ
    public int maxStarvationValue; //����ֵ
    public int currentStarvationValue; //��ǰ����ֵ
    public int maxThirstValue; //�ڿ�ֵ
    public int currentThirstValue;//��ǰ�ڿ�ֵ
    public int maxGrowthValue;  //�ɳ�ֵ
    public int currentGrowthValue; //��ǰ�ɳ�ֵ
    public int maxWeatherInfluence; //����Ӱ��ֵ
    public int currentWeatherInfluence;//��ǰӰ��ֵ
    public int maxLoveValue;           //����ֵ
    public int currentLoveValue;        //��ǰ����ֵ
}
