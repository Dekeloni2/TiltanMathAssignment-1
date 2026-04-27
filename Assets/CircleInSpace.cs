using UnityEngine;

public class CircleInSpace : MonoBehaviour
{
    public Vector3 center = Vector3.zero;
    public float radius = 0f;
    public float startAngle = 0.0f;
    public float speed = 5.0f;
    private float angle;

    void Start()
    {
        angle = startAngle;
    }
    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        
        float rad = angle * Mathf.Deg2Rad;
        
        angle = Mathf.Repeat(angle, 360f);
        
        Debug.Log($"Angle: {angle} degrees | Radians: {rad}");

        float x = center.x + radius * Mathf.Cos(rad) * radius;
        float y = center.y + radius * Mathf.Sin(rad) * radius;
        
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
