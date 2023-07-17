using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject RestartButton;

    //перезазрузка уровня
    public void RestartLevel()
    {
        RestartButton.SetActive(false); //скрваем кнопку
        Time.timeScale = 1; // запускаем нормальное время

    }
}
