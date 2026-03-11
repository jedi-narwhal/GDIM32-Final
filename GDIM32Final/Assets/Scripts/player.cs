using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private Transform _cameraTrans;
    private float _rotationX;
    private float _rotationY;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _mouseSensitivity;

    public bool _hasKey = false;
    public bool _hasBattery = false;



    //--------------------------------------- Singleton ---------------------------------------

        public static player Instance { get; private set; }


    private void Awake() {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;

        }
        Instance = this;
    }

    public delegate void Onclick();
    public event Onclick Click;

    public delegate void Done();
    public event Done EndGame;

    //------------------------------------------------------------------------------------------
    
    // Start is called before the first frame update
    void Start()
    {
        _cameraTrans = Camera.main.transform;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
   
        float mouseY = Input.GetAxis("Mouse Y");
        _rotationY += mouseY * _mouseSensitivity;
        _rotationY = Mathf.Clamp(_rotationY, -60.0f, 60.0f);

        float mouseX = Input.GetAxis("Mouse X");
        _rotationX += mouseX * _mouseSensitivity;

        _cameraTrans.localEulerAngles = new Vector3(-_rotationY, 0, 0);
        transform.localEulerAngles = new Vector3(0, _rotationX, 0);

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(
            ((vertical * Vector3.forward) + (horizontal * Vector3.right))
            * _moveSpeed * Time.deltaTime
        );
    }
  public void InvokeClick()
    {
        Click?.Invoke();
    }

  public void InvokeEndGame()
    {
        EndGame?.Invoke();
    }



}
