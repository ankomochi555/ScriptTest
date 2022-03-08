using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    private int mp = 53;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }


    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        //残りhpを減らす
        this.hp -= damage;
    }

    public void Magic(int mpuse)
    {
        
            if (mp >= 5)
            {
                this.mp -= mpuse;

                Debug.Log("魔法攻撃をした。残りのMPは" + mp + "。");
            }
            else
            {
                this.mp = mpuse;
                Debug.Log("MPが足りないため、魔法が使えない。");
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


        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();


        //攻撃用の関数を呼び出す
        lastboss.Attack();

        //防御用の関数を呼び出す
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
