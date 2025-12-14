using UnityEngine;

public class Batman_Movement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private float _turnSpeed = 10f;
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
        Vector3 direction = new Vector3(h, 0, v).normalized;

        // Calculate Movement and Rotation
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, targetAngle, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * _turnSpeed);

            controller.Move(transform.forward * _currentSpeed * Time.deltaTime);
        }

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
