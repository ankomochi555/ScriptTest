using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100; //�̗�
    private int power = 25; //�U����
    private int mp = 53;

    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }


    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        //�c��hp�����炷
        this.hp -= damage;
    }

    public void Magic(int mpuse)
    {
        
            if (mp >= 5)
            {
                this.mp -= mpuse;

                Debug.Log("���@�U���������B�c���MP��" + mp + "�B");
            }
            else
            {
                this.mp = mpuse;
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }


    }
}


public class Test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        

        int[] arrey = { 10, 20, 30, 40, 50};


        for (int a = 0; a < 5; a++)
        {
            Debug.Log(arrey[a]);
        }

        for (int b = 4; b >= 0; b--)
        {
            Debug.Log(arrey[b]);
        }


        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();


        //�U���p�̊֐����Ăяo��
        lastboss.Attack();

        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);

        lastboss.Magic(5);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
