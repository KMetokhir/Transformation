using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private float _speed;   

    private void Update()
    {
        Vector3 direction  = GetDirection();
        Move(direction, _speed);
    }

    protected virtual Vector3 GetDirection()
    {
        return Vector3.forward;
    }

    private void Move(Vector3 direction, float speed)
    {
        float step = speed * Time.deltaTime;
        Vector3 target = transform.position + direction;

        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
