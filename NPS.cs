using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Здоровье NPS
        int health = 6;
        //Уровень NPS
        int level = 1;
        //Скорость NPS
        float speed = 1.2f;
        //складывает здоровье и уровень 
        health += level;
        //выводит нынешнее здоровье
        print("Здоровье NPS на данный момент - " + health );
    }
    // Update is called once per frame
    void Update()
    {
        float speed = 1.2f;
        //Создаём переменную Vector3
        Vector3 newPosition;
        //присваеваем переменную
        newPosition = transform.position;
        //меняем позицию
        newPosition.z += speed * Time.deltaTime;
        //присваеваем обновлённое значение
        transform.position = newPosition;
    }
}
