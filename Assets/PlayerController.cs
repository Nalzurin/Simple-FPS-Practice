using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    #region Camera Related Variables
    [SerializeField]
    Camera playerCam;
    [SerializeField]
    float horizontalSensitivity = 1f;
    [SerializeField]
    float verticalSensitivity = 1f;
    [SerializeField]
    float minAngleVertical = -88f;
    [SerializeField]
    float maxAngleVertical = 45f;

    private float verticalAngle = 0f;
    #endregion
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    public float acceleration = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        CamControl();
    }
    /// <summary>
    /// Method to control camera rotation
    /// </summary>
    void CamControl()
    {
        float horizontal= Input.GetAxis("Mouse X") * horizontalSensitivity;
        verticalAngle -= Input.GetAxis("Mouse Y");
        verticalAngle = Mathf.Clamp(verticalAngle * verticalSensitivity, minAngleVertical, maxAngleVertical);
        transform.Rotate(0, horizontal, 0);
        playerCam.transform.localEulerAngles = new Vector3(verticalAngle, playerCam.transform.localEulerAngles.y, 0);

    }
}
