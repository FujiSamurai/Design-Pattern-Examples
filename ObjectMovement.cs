using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(1, 1, 1), rotationSpeed * Time.deltaTime, Space.Self);
    }
}
