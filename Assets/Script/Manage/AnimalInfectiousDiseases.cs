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
        if (animalIsIll)
        {
            animalBehaviors.AnimalFallIll();
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Virus")
        {
            animalIsIll = true;

            if (animalBehaviors.characterState.templateAnimalData.currentImmunity >= 20 &&animalBehaviors.characterState.templateAnimalData.currentImmunity <= 50)
            {
                isDiseases();
            }
            else
            {
                return;
            }
        }
    }



}
