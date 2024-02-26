using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraScript : MonoBehaviour
{
    [SerializeField] private Transform target; // Kameranın takip edeceği hedef (örneğin, oyuncu karakteri)
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -5f); // Hedefe göre kamera konumu ofseti
    [SerializeField] private float smoothSpeed = 5f; // Kameranın yumuşak takip hızı

    private void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Hedef belirtilmedi!");
            return;
        }

        // Hedefin konumunu takip etmek için yeni bir hedef konumu hesapla
        Vector3 desiredPosition = target.position + offset;

        // Yumuşak bir takip hareketi elde etmek için kamera konumunu yumuşak bir şekilde güncelle
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Hedefi izlemek için kamerayı daima hedefe doğru çevir
        transform.LookAt(target);
    }
}
