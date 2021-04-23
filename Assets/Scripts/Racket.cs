using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Racket : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    int score;
    public Text scoreText;

    public Rigidbody2D rb2d { get { return GetComponent<Rigidbody2D>(); } }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Debug.Log(moveAxis);

    }

    protected abstract void Move();
  

    public void MakeScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
