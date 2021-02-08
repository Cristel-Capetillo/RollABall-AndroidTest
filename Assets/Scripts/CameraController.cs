using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset;
    
    void Start()
    {
        _offset = transform.position - player.transform.position;
    }
    
    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
    
}

//Camera needs to be calculated ASAP but only once -use Start-
//Camera pos, wont be set until player has moved -use lateUpdate-