using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject money;
    
    void Start()
    {
        StartCoroutine(Spawner()); // ������� ������ � �����
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2); // ������ ������ 2 �������
            float rand1 = Random.Range(-3f, 3f); // ��������� ��������� �� -3 �� 3
            float rand2 = Random.Range(-3f, 3f);
            GameObject newEnemy = Instantiate(enemy, new Vector2(15, rand1), Quaternion.identity); // ������� ������ � ����
            GameObject newMoney = Instantiate(money, new Vector2(15, rand2), Quaternion.identity);
            Destroy(newEnemy, 10); // ���������� ����� 10 ������
            Destroy(newMoney, 10);
        }
    }
}

