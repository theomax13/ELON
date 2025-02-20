using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float projectileSpeed = 40f;
    private Vector2 projectilePosition;
    

    // Update is called once per frame
    void Update()
    {
        projectilePosition = transform.position;
        projectilePosition.y += projectileSpeed * Time.deltaTime;
        transform.position = projectilePosition;
        DestroyProjectile();
    }

    private void DestroyProjectile()
    {
        if (projectilePosition.y > 20)
        {
            Destroy(gameObject);   
        }
    }
}
