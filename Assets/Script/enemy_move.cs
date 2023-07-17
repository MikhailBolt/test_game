using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public float speed;
    public float t;
    public float amp = 1.5f;
    public float f = 1;
    public Vector2 startPosition;
    public float offset;

    private void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        t = t + Time.deltaTime;
        transform.position = startPosition + new Vector2(-speed * t, amp * Mathf.Sin(t * f)); // движение врага по горизонтале и движение вверх-вниз, благодаря функции sin
    }
}
