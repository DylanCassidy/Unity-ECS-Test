using UnityEngine;

using Unity.Entities;

public class RotatorECS : MonoBehaviour
{
    public float speed;
}

class RotatorSystem : ComponentSystem
{
    struct Components
    {
        public RotatorECS rotator;
        public Transform transform;
    }

    protected override void OnUpdate()
    {
        foreach (var e in GetEntities<Components>())
        {
            e.transform.Rotate(0f, e.rotator.speed * Time.deltaTime, 0f);
        }
    }
}