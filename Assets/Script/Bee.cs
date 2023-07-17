using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bee : MonoBehaviour
{


    public float force;
    Rigidbody2D BeeRigid;
    public GameObject RestartButton;
    public GameObject Money;

    void Start()
    {
        Time.timeScale = 0;
        BeeRigid = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            BeeRigid.velocity = Vector2.up * force; // �������� ������
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {                                      // ��� ������� ������� � ����� Enemy, ���������� ������, ������������� ����� � ������������� �����
            Destroy(gameObject);
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
