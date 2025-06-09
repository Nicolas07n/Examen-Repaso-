using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 dir;
    public float speed = 10f, returnTime, destroyTime = 5f;
    private float currentTime;
    private Rigidbody2D _rb;
    private Transform returnTransform;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  
        Destroy(gameObject,destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= returnTime) 
        {
            Vector2 directionToReturn = returnTransform.position - transform.position;
            _rb.velocity = directionToReturn.normalized * speed;
        
        }
        else
        {
            _rb.velocity = dir * speed;


        }
    
    }
    public void SetDir(Vector2 nDir)
    {
        dir = nDir; 
    }
    public void SetReturnTransform(Transform t)
    { 
        
        returnTransform = t;
    
    
    }


}
