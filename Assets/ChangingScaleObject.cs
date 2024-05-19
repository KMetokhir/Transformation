using UnityEngine;

public class ChangingScaleObject : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Grow();
    }

    private void Grow()
    {
        float step = 2;
        Vector3 targetScale = transform.localScale * 2;

        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * _speed);
    }
}
