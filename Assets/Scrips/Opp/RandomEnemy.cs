using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : Enemy
{
    private Vector2 dir;
    private float timeToSpin;
    private float currentTime;
    private bool confused;

    public RandomEnemy(Rigidbody2D rb, Vector2 dir, float timeToSpin) : base(10f, rb, null)
    {
        this.dir = dir;
        this.timeToSpin = timeToSpin;
        this.currentTime = 0f;
        this.confused = false;
    }

    public override void Move()
    {
        if (confused)
        {
            rb.velocity = -dir * speed;
        }
        else
        {
            rb.velocity = dir * speed;
        }
    }

    public override void Hit()
    {
        confused = true;
        rb.transform.Rotate(Vector3.forward * 360f);
        Invoke("EndConfusion", timeToSpin);
    }

    private void EndConfusion()
    {
        confused = false;
    }
}