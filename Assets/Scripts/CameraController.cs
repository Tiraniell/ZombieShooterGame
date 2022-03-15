
using UnityEngine;

public class CameraController : MonoBehaviour
{
 
     [SerializeField] float mouseSensitivity = 100f;


    public Transform _Player;

    private void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
        
    }

    private void Update()
    {
     
        _Player.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * Time.fixedDeltaTime * mouseSensitivity, 0));

        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * Time.fixedDeltaTime * mouseSensitivity, 0, 0));
        
    }
}
