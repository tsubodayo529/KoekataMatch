using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float DeathTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DeathTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
