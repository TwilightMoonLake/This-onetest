using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalInfectiousDiseases : MonoBehaviour
{
    //���ʵ�ֵ�һֻ�����������ض������¼ӳ�ʼ����������
    //���ʵ������������������
    //��Ⱦ��ģ�飬���ﴥ����Ⱦ��
    //�������õ��˴�Ⱦ������ô�ᴫȾ����ͬ�ද����ϵ͸��ʴ�Ⱦ��ͬ�ද��
    private AnimalBehaviors animalBehaviors;
    public bool animalIsIll;

    void isDiseases()
    {
        animalBehaviors.AnimalFallIll();
    }



}
