using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatroller : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPoint;

    public float moveSpeed, waitAtPoints;
    private float waitCounter;

    public float jumpForce;

    public Rigidbody2D theRB;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        waitCounter = waitAtPoints;

        foreach(Transform pPoint in patrolPoints)
        {
            pPoint.SetParent(null);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x - patrolPoints[currentPoint].position.x) > .2f)
        {
            if(transform.position.x < patrolPoints[currentPoint].position.x)
            {
                theRB.linearVelocity = new Vector2(moveSpeed, theRB.linearVelocity.y);
                transform.localScale = new Vector3(-1f, 1f, 1f);
            } else
            {
                theRB.linearVelocity = new Vector2(-moveSpeed, theRB.linearVelocity.y);
                transform.localScale = Vector3.one;
            }

            if(transform.position.y < patrolPoints[currentPoint].position.y -.5f && theRB.linearVelocity.y < .1f )
            {
                theRB.linearVelocity = new Vector2(theRB.linearVelocity.x, jumpForce);
            }
        } else
        {
            theRB.linearVelocity = new Vector2(0f, theRB.linearVelocity.y);

            waitCounter -= Time.deltaTime;
            if(waitCounter <= 0)
            {
                waitCounter = waitAtPoints;

                currentPoint++;

                if(currentPoint >= patrolPoints.Length)
                {
                    currentPoint = 0;
                }
            }
        }

        anim.SetFloat("speed", Mathf.Abs(theRB.linearVelocity.x));
    }
}
