using UnityEngine;

public class InputReader : MonoBehaviour
{
    public float DirectionX { get; private set; }

    private bool _isJump;

    public bool GetIsJump() => GetBoolAsTrigger(ref _isJump);

    private void Update()
    {
        DirectionX = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
            _isJump = true;
    }
    private bool GetBoolAsTrigger(ref bool value)
    {
        bool localValue = value;
        value = false;
        return localValue;
    }
}
