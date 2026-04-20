using System;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (transform.position.y < -10f) Destroy(gameObject);
    }
}
