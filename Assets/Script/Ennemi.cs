 using System;
 using UnityEngine;

public class Ennemi : MonoBehaviour
{
    private float ennemiSpeed = 3f;
    private Vector2 ennemiPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ennemiPosition = transform.position;
        ennemiPosition.y -= ennemiSpeed * Time.deltaTime;
        transform.position = ennemiPosition; 
    }

    private void DestroyEnnemi()
    {
        if (ennemiPosition.y <= -8)
        {
            Destroy(gameObject);
        }
    }
}
