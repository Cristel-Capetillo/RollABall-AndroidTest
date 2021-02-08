using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private Rigidbody _rigidbody;
    private int _count;
    private float _movementX;
    private float _movementY;
    
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    { 
        Vector2 movementVector = movementValue.Get<Vector2>();
        _movementX = movementVector.x;
        _movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Collected: " + _count.ToString();
        if (_count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(_movementX, 0.0f, _movementY);
        _rigidbody.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 1;
            SetCountText();
        }
    }
}

//Check every frame for player input and apply that input to move player
//We would apply the movement -physics- go to FixedUpdate
//Notify when movement happens OnMove
//namespace are data in the project -needed- using is namespace
//Vector3 store data of three axis
//Needs to detect collision -OnTriggerEnter-