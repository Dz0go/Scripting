using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Поля

    //Здоровье
    public int health = 10;
    public int maxHealth = 10;
    //Монеты
    public int coins = 0;

    //Префаб огненого шара
    public GameObject fireballPrefab;

    //Место откуда огненый шар появляеться
    public Transform attackPoint;



    private void Update()
    {
        //Условие нажатие на лкм
        if (Input.GetMouseButtonDown(0))
        {
            //Создание копии(префаб,где появиться,поворот)
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //Метод получения урона
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Health:" + health);
    }

    //Метод увелечения монет
    public void CollectCoins()
    {
        coins += 1;
        print("coins" + coins);
    }
}
