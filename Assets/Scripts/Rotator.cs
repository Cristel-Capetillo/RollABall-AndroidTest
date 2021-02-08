using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

//It needs to make the pick up spin
//The values need to change so cube spins
//Affect the transform of the GObj -rotate or transform-, we can choose Vector3
