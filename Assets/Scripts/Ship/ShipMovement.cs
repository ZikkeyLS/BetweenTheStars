using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private float _baseSpeed = 10f;

    private Transform _shipTransform;
    public void SetShipTransform(Transform shipTransform) => _shipTransform = shipTransform;

    private float _speedModificator = 1f;
    public void SetSpeedModificator(float value) => _speedModificator = value;


}
