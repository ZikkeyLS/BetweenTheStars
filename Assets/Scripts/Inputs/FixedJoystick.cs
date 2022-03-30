using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FixedJoystick : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] private Transform _stick;
    [SerializeField] private float _maxRadius;
    [Space] [SerializeField] private Vector2 _range;
    
    public float Horizontal => _range.x;
    public float Vertical => _range.y;
    private float NormalizedStickMagnitude => _stick.localPosition.magnitude / _maxRadius;

    public void OnDrag(PointerEventData eventData)
    {
        _stick.position = Mouse.current.position.ReadValue();
        _stick.localPosition = Vector3.ClampMagnitude(_stick.localPosition, _maxRadius);
        
        _range = _stick.transform.localPosition.normalized * NormalizedStickMagnitude;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _stick.position = transform.position;
        _range = Vector2.zero;
    }
}
