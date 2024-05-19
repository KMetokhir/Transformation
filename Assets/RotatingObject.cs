using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}
