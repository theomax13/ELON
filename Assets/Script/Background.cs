using UnityEngine;

public class Background : MonoBehaviour
{
    private float backgroundSpeed = 0.5f;
    private Vector2 backgroundPosition;
    void Update()
    {
        backgroundPosition = transform.position;
        backgroundPosition.y -= backgroundSpeed * Time.deltaTime;
        transform.position = backgroundPosition;
    }
}
