using UnityEngine;

public class RoundMovement : MonoBehaviour
{
    [SerializeField] private float Radius;
    [SerializeField] private float Speed;
    [SerializeField] private float StartAngleInRads;

    private float angle;
    private float x, y;
    private Vector3 pos;

    void Start()
    {
        angle = StartAngleInRads;
        x = transform.position.x;
        y = transform.position.y;
        pos = new Vector3(x, y, transform.position.z);
    }

    void Update()
    {
        angle += Time.deltaTime * Speed;
        pos.x = Mathf.Cos(angle) * Radius + x;
        pos.y = Mathf.Sin(angle) * Radius + y;
        transform.position = pos;
    }
}