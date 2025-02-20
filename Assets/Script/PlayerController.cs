using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 30f;
    private Vector2 playerPosition;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform bulletSpawnPoint;

    [SerializeField] TextMeshProUGUI playerScoreText;
    [SerializeField] private SpriteRenderer muskSprite;
    private int playerScore = 0;

    public AudioSource ElonContent;
    public AudioSource ElonShootContent;

    public AudioSource LesGAZ;
    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        ShootProjectile();
        DisplayScore();
        if (!ElonContent.isPlaying)
        {
            muskSprite.sortingOrder = -1000;
        }
    }

    private void DisplayScore()
    {
        playerScoreText.text = "Score: " + playerScore;
    }

    public void UpdatePlayerScore()
    {
        playerScore += 10;
        if (playerScore == 50)
        {
            ElonContent.Play();
            muskSprite.sortingOrder = 5;
        }
    }

    private void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ElonShootContent.Play();
            Instantiate(projectilePrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
        }
    }

    void HandleMovement()
    {
        playerPosition = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            LesGAZ.Play();
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
