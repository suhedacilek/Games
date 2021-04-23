using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanRacket : Racket
{
    // Start is called before the first frame update
    public string moveAxisName;

    protected override void Move()
    {
        float moveAxis = Input.GetAxis(moveAxisName);
        rb2d.velocity = new Vector2(0, moveAxis) * moveSpeed;
    }
}
