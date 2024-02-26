using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStick : MonoBehaviour
{
    public Transform movingBar1;
    public Transform movingBar2;
    public float movementRange = 2f;
    public float movementSpeed = 2f;
    public float delayBetweenMovements = 1f;

    private Vector3 initialPosition1;
    private Vector3 initialPosition2;
    private float timeSinceLastMovement;

    void Start()
    {
        initialPosition1 = movingBar1.position;
        initialPosition2 = movingBar2.position;
        timeSinceLastMovement = 0f;
    }

    void Update()
    {
        timeSinceLastMovement += Time.deltaTime;

        // Belirli bir gecikme süresinden sonra hareketi gerçekleştir
        if (timeSinceLastMovement >= delayBetweenMovements)
        {
            // Hareketli çubukların sağa-sola hareketi
            float moveAmount = Mathf.Sin(Time.time * movementSpeed) * movementRange;
            movingBar1.position = initialPosition1 + new Vector3(0f, 0f, moveAmount);
            movingBar2.position = initialPosition2 - new Vector3(0f, 0f, moveAmount);

            // Zamanlayıcıyı sıfırla
            timeSinceLastMovement = 0f;
        }
    }
}
