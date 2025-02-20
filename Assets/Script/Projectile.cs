using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float projectileSpeed = 40f;
    private Vector2 projectilePosition;
    private Vector2 collisionPoint;

    // Update is called once per frame
    void Update()
    {
        projectilePosition = transform.position;
        projectilePosition.y += projectileSpeed * Time.deltaTime;
        transform.position = projectilePosition;
        DestroyProjectile();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemi"))
        {
            collisionPoint = transform.position;
            Destroy(gameObject);
            Destroy(collision.gameObject);

            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().UpdatePlayerScore();
        }
    }

    private void DestroyProjectile()
    {
        if (projectilePosition.y > 20)
        {
            Destroy(gameObject);   
        }
    }
}
