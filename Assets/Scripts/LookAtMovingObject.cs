using UnityEngine;

public class LookAtMovingObject : MovingObject
{
    protected override Vector3 GetDirection()
    {
        return transform.forward;
    }
}
