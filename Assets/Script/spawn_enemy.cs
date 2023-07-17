using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject money;
    
    void Start()
    {
        StartCoroutine(Spawner()); // спавнер врагов и очков
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2); // создаём каждые 2 секунды
            float rand1 = Random.Range(-3f, 3f); // случайный диапазоне от -3 до 3
            float rand2 = Random.Range(-3f, 3f);
            GameObject newEnemy = Instantiate(enemy, new Vector2(15, rand1), Quaternion.identity); // создаем врагов и очки
            GameObject newMoney = Instantiate(money, new Vector2(15, rand2), Quaternion.identity);
            Destroy(newEnemy, 10); // уничтожаем через 10 секунд
            Destroy(newMoney, 10);
        }
    }
}

