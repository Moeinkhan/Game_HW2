using UnityEngine;
using UnityEngine.InputSystem.XR;

public class BatmanVehicleInteraction : MonoBehaviour
{
    [SerializeField] private BatMobile_Movement batmobile;
    [SerializeField] private Transform carCameraPoint;
    [SerializeField] private Transform batmanCameraPoint;
    [SerializeField] private Camera cam;
    private bool isInCar = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isInCar)
                EnterCar();
            else
                ExitCar();
        }
    }

    void EnterCar()
    {
        isInCar = true;

        CharacterController controller = GetComponent<CharacterController>();
        controller.enabled = false;
        transform.position = new Vector3(0, -50, 0);

        cam.transform.SetParent(carCameraPoint);
        cam.transform.localPosition = Vector3.zero;
        cam.transform.localRotation = Quaternion.identity;

        batmobile.isDriving = true;
    }

    void ExitCar()
    {
        isInCar = false;

        cam.transform.SetParent(batmanCameraPoint);
        cam.transform.localPosition = Vector3.zero;
        cam.transform.localRotation = Quaternion.identity;

        CharacterController controller = GetComponent<CharacterController>();
        transform.position = batmobile.transform.position + new Vector3(0, 0, -3);
        controller.enabled = true;
        batmobile.isDriving = false;
    }
}
