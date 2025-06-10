using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageEnemy : Enemy
{
    private GameObject target;

    public AverageEnemy(Rigidbody2D rb, GameObject target) : base(15f, rb, null)
    {
        this.target = target;
    }

    public override void Move()
    {
        if (target != null)
        {
            Vector2 direction = (target.transform.position - rb.transform.position).normalized;
            rb.velocity = direction * speed;
        }
    }

    public override void Hit()
    {
        // No hace nada
    }
}
