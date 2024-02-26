using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f; // Dönme hızı

    private void Update()
    {
        // Sağa doğru döndürmek için
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        // veya
        // transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime); // Sağa doğru dönme
        // transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime); // Sola doğru dönme
    }
}
