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
        float scaleFactor = 2;
        Vector3 targetScale = transform.localScale * scaleFactor;

        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * _speed);
    }
}
