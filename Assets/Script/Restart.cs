using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject RestartButton;

    //������������ ������
    public void RestartLevel()
    {
        RestartButton.SetActive(false); //������� ������
        Time.timeScale = 1; // ��������� ���������� �����

    }
}
