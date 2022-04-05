using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviors : MonoBehaviour
{
    private float timeDownInfected = 10;
    private float random;
    public GameObject otherAnimal;
    private float timeDownFill = 20;
    private float illRadius = 10;//�����Ĵ�Ⱦ��Χ
    //�ò����������ڶ�����Ϊ�ı�д
    CharacterState characterState;//���ö�����������
    private AnimalManagers animalManagers;
    public Animator anim;//��ȡ�������
    /*��������������������ݴ�cr֮������*/
    [Header("Animation bool")]//����boolֵ��״̬�������ж�,�˴���ʱ��Ϊboolֵ��������Ŀ�������float����������״̬�������ж�
    bool isWalk;
    bool isRun;
    bool isJump;
    bool isSleep;
    bool isFly;
    bool isSwim;
    bool isEat;
    bool isReproduction;
    bool isPlayWithPlayer;
    bool isAnimalFear;
    bool isAnimalGather;
    bool isAnimalFight;
    bool isIll;
    private void Start()
    {
        
    }

    public void SwitchAnimalAnimation()
    {
        anim.SetBool("", isWalk);
        anim.SetBool("", isRun);
        anim.SetBool("", isJump);
        anim.SetBool("", isSleep);
        anim.SetBool("", isFly);
        anim.SetBool("", isSwim);
        anim.SetBool("", isEat);
        anim.SetBool("", isReproduction);
        anim.SetBool("", isPlayWithPlayer);
        anim.SetBool("", isAnimalFear);
        anim.SetBool("", isAnimalGather);
        anim.SetBool("", isAnimalFight);

    }
    //������Ϊ�ľ�������д��cr֮��Update
    #region ���������Ϊzhi
    public void AnimalMove(CharacterState characterState)//���ƶ����ƶ�
    {
        Debug.Log("finish test");
        //Update״̬����ֵ
        //��ȡĿ���ƶ���Χ�뾶
        //��������뾶�ڵ�X��Zֵ
        //���ü�ʱ����������
        //ѭ���ù���
    }
    public void AnmialFly()//���ƶ�����У������ද����ø÷���
    {

    }
    public void AnimalRun(CharacterState characterState)//���ƶ�������ƶ�
    {

    }
    public void AnimalJump()//���ƶ�����Ծ
    {
        Debug.Log("enterOther");

    }
    public void AnimalSwim()//���ƶ�����Ӿ��ˮ�����������
    {

    }
    public void AnimalSound()//���ƶ������
    {
        //���ü�ʱ��������һ���޶�ʱ���ڵ������ֵ
        //��ֵ����󲥷�BGM

    }
    public void AnimalEat()//���ƶ����ʳ
    {

    }
    public void AnimalSleep()//���ƶ���˯��
    {
        //��ȡ��Ϸ����ҹʱ��
        //Update״̬�����ж�������

    }
    public void AnimalPlayWithPlayer()//���ƶ�������ҵĻ���
    {

    }
    public void AnimalReproduction()//���ƶ��ﷱֳ
    {
        //�����޶�����
        //����Data����
        //��currentData == maxDataʱ Update״̬��
        //
    }

    #endregion
    #region �������������µ���Ϊ
    public void AnimalFear()//���ﺦ�£���Ϊ��Ϊ��ֹ����״̬��Ӧ������������
    {

    }
    public void AnimalGather() //����ۼ�����Ӧ������ѩ��
    {

    }
    public void AnimalSpecialSound()//������������������������������ʱ����
    {

    }
    public void AnimalFight()//������
    {

    }
    public void AnimalTest()
    {
        Debug.Log("Test");
    }
    public void AnimalFallIll()
    {

        isIll = true;
        //����ж������Ⱦ������
        Debug.Log("�����Ⱦ�˴�Ⱦ��");
        Debug.Log(isIll);
        //������Ϊ������չ
        //��������������1���ٶȼ���
        //characterState.templateAnimalData.speed = characterState.templateAnimalData.speed * 0.5f;
        //characterState.templateAnimalData.flySpeed = characterState.templateAnimalData.flySpeed * 0.5f;
        //characterState.templateAnimalData.swimSpeed = characterState.templateAnimalData.swimSpeed * 0.5f;
        //characterState.templateAnimalData.runSpeed = characterState.templateAnimalData.runSpeed*0.5f;
        //characterState.templateAnimalData.jumpSpeed = characterState.templateAnimalData.jumpSpeed * 0.5f;
        //timeDownFill = timeDownFill - Time.deltaTime;
        //��������������2����ֵ����
        //characterState.lifeDownInill();//�����˺����㷽��
        //if (timeDownFill <= 0)
        //{
        //    characterState.templateAnimalData.currentHealth = characterState.templateAnimalData.currentHealth - 1;
        //    timeDownFill = 20;
        //}//ÿ20�����һ����ֵ
        //����һЩ��Ϊȡ��

        FoundOtherAnimal();
    }

    bool FoundOtherAnimal()
    {
        Debug.Log("������OverlapSphere���");
        var colliders = Physics.OverlapSphere(transform.position,illRadius);//��ⷶΧ�ڵ�����
        foreach (var animal in colliders) //��colliders��ѭ������Ŀ��
        {
            //if (otherAnimal.tag == "Animal")
            //{
            //    Debug.Log("Found Animal!");
            //    return true;
                
                
            //}
        }
        return false;
    }
    private void OnTriggerStay(Collider other)
    {

        if (isIll)
        {
            Debug.Log("ִ���˼��");
            timeDownFill = timeDownFill - Time.deltaTime;
            if (timeDownFill <= 0)
            {
                random = Random.Range(0, 99);
                timeDownFill = 10;
            }
            if (other.tag == gameObject.tag)//���tag��ͬ
            {

                // random = Random.Range(0, 99);
                if (random < 30)
                {
                    other.gameObject.GetComponent<GameObject>();
                    Destroy(other.gameObject); ;
                    //�˴�������Ŀ������Ϊ�����ȾЧ��

                }
            }
            else if (other.tag != gameObject.tag)
            {
                if (random < 15)
                {
                    other.gameObject.GetComponent<GameObject>();
                    Destroy(other.gameObject); ;
                    // AnimalFallIll();
                    //�˴�������Ŀ�����������ȾЧ��
                }
            }
            //    Debug.Log("timeDownFill"+timeDownFill);
            Debug.Log("Random=" + random);
        }
        else //��Ⱦ������
        {
            
        }
      
    }
    #endregion
}