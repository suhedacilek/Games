using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Range(10,30)]
    public float moveSpeed = 15;

    public AudioSource audioSource {get {return GetComponent<AudioSource>(); } }

    public Racket leftRacket, rightRacket;
    public Rigidbody2D rb2d { get { return GetComponent<Rigidbody2D>(); } }
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = new Vector2(1, 0)*moveSpeed;    
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
       var tagManager = collision.gameObject.GetComponent<TagManager>();
        audioSource.Play();
        
        if(tagManager != null)
        {
            var tag = tagManager.myTag;
            if (tag.Equals(Tag.LEFT_WALL))
            {
                rightRacket.MakeScore();

            }
            if (tag.Equals(Tag.RIGHT_WALL))
            {
                leftRacket.MakeScore();

            }
            if (tag.Equals(Tag.LEFT_RACKET))
            {
                ComputeReturnVelocity(collision, 1);

            }
            if (tag.Equals(Tag.RIGHT_RACKET))
            {
                ComputeReturnVelocity(collision, -1);

            }
        }
    }

    private void ComputeReturnVelocity(Collision2D collision, float x)
    {
        float a = transform.position.y - collision.transform.position.y;
        float b = collision.collider.bounds.size.y;
        float y = a / b;

        rb2d.velocity = new Vector2(x, y)*moveSpeed;
    }
}
