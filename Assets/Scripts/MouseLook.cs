using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    //player parent Transform
    [SerializeField] private Transform playerParent;
    //mouse sensivity, stick sensivity
    [SerializeField] private float mouseSens, stickSens;
    //low res render texture, high res render texture
    [SerializeField] private RenderTexture RTLow, RTHigh;
    //raw image
    [SerializeField] private RawImage RI;
    //x axis rotation
    private float xRotation;

    //controls
    private Controls controls;
    private void Awake()
    {
        controls = new Controls();
        controls.Player.ChangeResolution.performed += context => ChangeRes();
    }
    private void OnEnable()
    { controls.Enable(); }
    private void OnDisable()
    { controls.Disable(); }

    void Start()
    {
        //hiding the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //reading rotation values
        float mouseX = controls.Player.MouseX.ReadValue<float>() * mouseSens;
        float mouseY = controls.Player.MouseY.ReadValue<float>() * mouseSens;
        float stickX = controls.Player.StickX.ReadValue<float>() * stickSens;
        float stickY = controls.Player.StickY.ReadValue<float>() * stickSens;
        //rotating
        Rotate(mouseX, mouseY);
        Rotate(stickX, stickY);
    }
    private void Rotate(float X, float Y)
    {
        //rotating
        xRotation -= Y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerParent.Rotate(Vector3.up * X);
    }
    private void ChangeRes()
    {
        if (RI.texture == RTLow)
        {
            //set high resolution
            RI.texture = RTHigh;
            GetComponent<Camera>().targetTexture = RTHigh;
        }
        else
        {
            //set low resolution
            RI.texture = RTLow;
            GetComponent<Camera>().targetTexture = RTLow;
        }
    }
}
