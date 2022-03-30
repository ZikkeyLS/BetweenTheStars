using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Singleton;

    private void Awake()
    {
        Singleton = this;

        AssignInputs();
    }

    private void AssignInputs()
    {

    }
}
