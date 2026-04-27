using UnityEngine;

public class MoveInAngle : MonoBehaviour
{
    public float speed = 5.0f;
    public float angle = 0f;

    // Update is called once per frame
    void Update()
    {
        float radians = angle * Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians));
        
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }
}
