using UnityEngine;

enum BatmanState
{
    Normal,
    Stealth,
    Alert
}

public class State_Manager : MonoBehaviour
{
    private BatmanState _currentState;
    private Batman_Movement batman_Movement;

    void Start()
    {
        _currentState = BatmanState.Normal;
        batman_Movement = GameObject.Find("Batman").GetComponent<Batman_Movement>();
    }

    void Update()
    {
        // Change State
        if (Input.GetKeyDown(KeyCode.N))
            ChangeState(BatmanState.Normal);

        if (Input.GetKeyDown(KeyCode.C))
            ChangeState(BatmanState.Stealth);

        if (Input.GetKeyDown(KeyCode.Space))
            ChangeState(BatmanState.Alert);
    }

    private void ChangeState(BatmanState newState)
    {
        _currentState = newState;

        if (_currentState == BatmanState.Normal)
        {
            batman_Movement.SetNormalSpeed();
            //sceneLight.intensity = 1f;

            //if (alertSound.isPlaying)
            //    alertSound.Stop();
        }
        else if (_currentState == BatmanState.Stealth)
        {
            batman_Movement.SetSlowSpeed();
            //sceneLight.intensity = 0.3f;

            //if (alertSound.isPlaying)
            //    alertSound.Stop();
        }
        else if (_currentState == BatmanState.Alert)
        {
            batman_Movement.SetNormalSpeed();
            //sceneLight.intensity = 1.5f;

            //if (!alertSound.isPlaying)
            //    alertSound.Play();
        }
    }
}
