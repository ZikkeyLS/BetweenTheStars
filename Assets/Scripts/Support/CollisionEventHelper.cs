using System;
using UnityEngine;

public class CollisionEventHelper : MonoBehaviour
{
    public event Action CollisionEnter;
    public event Action CollisionExit;
    public event Action TriggerEnter;
    public event Action TriggerExit;
    
    public event Action<Collision> CollisionEnterOther;
    public event Action<Collision> CollisionExitOther;
    public event Action<Collider> TriggerEnterOther;
    public event Action<Collider> TriggerExitOther;
    
    private void OnCollisionEnter(Collision other)
    {
        CollisionEnter?.Invoke();
        CollisionEnterOther?.Invoke(other);
    }
    private void OnCollisionExit(Collision other)
    {
        CollisionExit?.Invoke();
        CollisionExitOther?.Invoke(other);
    }
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnter?.Invoke();
        TriggerEnterOther?.Invoke(other);
    }
    private void OnTriggerExit(Collider other)
    {
        TriggerExit?.Invoke();
        TriggerExitOther?.Invoke(other);
    }

    public void Dispose()
    {
        CollisionEnter = null;
        CollisionExit = null;
        TriggerEnter = null;
        TriggerExit = null;
        
        CollisionEnterOther = null;
        CollisionExitOther = null;
        TriggerEnterOther = null;
        TriggerExitOther = null;
    }
}
