using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�������� NPS
        int health = 6;
        //������� NPS
        int level = 1;
        //�������� NPS
        float speed = 1.2f;
        //���������� �������� � ������� 
        health += level;
        //������� �������� ��������
        print("�������� NPS �� ������ ������ - " + health );
    }
    // Update is called once per frame
    void Update()
    {
        float speed = 1.2f;
        //������ ���������� Vector3
        Vector3 newPosition;
        //����������� ����������
        newPosition = transform.position;
        //������ �������
        newPosition.z += speed * Time.deltaTime;
        //����������� ���������� ��������
        transform.position = newPosition;
    }
}
