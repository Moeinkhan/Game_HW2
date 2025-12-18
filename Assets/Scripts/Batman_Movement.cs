using UnityEngine;

public class Batman_Movement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 10f;
    [SerializeField]
    private float _turnSpeed = 2.5f;
    private float _gravity = -9.8f;
    private float _currentSpeed;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        _currentSpeed = _moveSpeed;
    }

    void Update()
    {
        // Sprint with holding LeftShift
        if (Input.GetKeyDown(KeyCode.LeftShift))
            _currentSpeed *= 2;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            _currentSpeed /= 2;

        // Input
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // Calculate Movement and Rotation
        transform.Rotate(Vector3.up, h * _turnSpeed); // Rotate left of right (A or D key)
        controller.Move(transform.forward * v * _currentSpeed * Time.deltaTime); // Moving forward or backward (W or S key)

        // Gravity
        controller.Move(Vector3.up * _gravity * Time.deltaTime);
    }

    public void SetNormalSpeed()
    {
        _currentSpeed = _moveSpeed;
    }
    public void SetSlowSpeed()
    {
        _currentSpeed = _moveSpeed / 2;
    }
}
