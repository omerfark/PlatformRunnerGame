using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    [SerializeField] private float moveDistance = 3f; // mesafe
    [SerializeField] private float moveSpeed = 2f; 

    private Vector3 initialPosition;
    private bool movingRight = true; // Başlangıçta sağa doğru hareket eder

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Hareket mesafesini platform boyutuna göre ayarlayın
        float movement = moveDistance * Time.deltaTime * moveSpeed;

        if (movingRight)
        {
            transform.Translate(Vector3.forward * movement);
        }
        else
        {
            transform.Translate(Vector3.back * movement);
        }

        // Platform belirli bir mesafe boyunca hareket ettikten sonra yönü tersine çevir
        if (Mathf.Abs(transform.position.z - initialPosition.z) >= moveDistance)
        {
            movingRight = !movingRight;
        }
    }
}
