using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //����

    //��������
    public int health = 10;
    public int maxHealth = 10;
    //������
    public int coins = 0;

    //������ �������� ����
    public GameObject fireballPrefab;

    //����� ������ ������� ��� �����������
    public Transform attackPoint;



    private void Update()
    {
        //������� ������� �� ���
        if (Input.GetMouseButtonDown(0))
        {
            //�������� �����(������,��� ���������,�������)
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //����� ��������� �����
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Health:" + health);
    }

    //����� ���������� �����
    public void CollectCoins()
    {
        coins += 1;
        print("coins" + coins);
    }
}
