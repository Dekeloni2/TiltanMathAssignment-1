using UnityEngine;

public class FollowCircle : MonoBehaviour
{
    public Transform target;      // Object to follow
    public Vector3 offset;        // Camera offset from target
    public float smoothSpeed = 5f;

    void Update()
    {
        if (target == null)
            return;

        // Desired camera position
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        transform.position = smoothedPosition;
    }
}
