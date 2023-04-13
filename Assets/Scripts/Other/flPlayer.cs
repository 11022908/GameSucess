using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float smoothTime = 0.25f;
    public Vector3 velocity = Vector3.zero;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public void Update()
    {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
