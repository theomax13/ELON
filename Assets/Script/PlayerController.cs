using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 30f;
    private Vector2 playerPosition;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform bulletSpawnPoint;

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        ShootProjectile();
    }

    private void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
        }
    }

    void HandleMovement()
    {
        playerPosition = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            playerPosition.y += playerSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.S))
        {
            playerPosition.y -= playerSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.D))
        {
            playerPosition.x += playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerPosition.x -= playerSpeed * Time.deltaTime;
        }
        
        transform.position = playerPosition;
    }
}
