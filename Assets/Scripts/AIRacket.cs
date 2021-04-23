using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacket : Racket
{
    public Transform ball;
    public float threshold = 2.5f;
    protected override void Move()
    {
        float distance = Mathf.Abs(ball.position.y - transform.position.y);

        if(distance> threshold)
        {
            if(ball.position.y > transform.position.y)
            {
                rb2d.velocity = new Vector2(0, 1) * moveSpeed* 1.5f;
            }
            else
            {
                rb2d.velocity = new Vector2(0, -1) * moveSpeed * 1.5f;
            }
        }
    }

}
