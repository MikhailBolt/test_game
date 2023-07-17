using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; // переменная текста

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString(); // присваиваем значене очков
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score") // при столкноение с объектом который даёт очки, объек уничтожается и прибавляется очко
        {
            score++;
            Destroy(collision.gameObject);
        }
    }
}
