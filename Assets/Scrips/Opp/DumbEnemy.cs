using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbEnemy : Enemy
{
    private Vector2 dir;

    public DumbEnemy(Rigidbody2D rb) : base(30f, rb, null)
    {
        dir = Random.insideUnitCircle.normalized;
    }

    public override void Move()
    {
        rb.velocity = dir * speed;
    }

    public override void Hit()
    {
        Destroy(rb.gameObject); // Muere
    }
}
