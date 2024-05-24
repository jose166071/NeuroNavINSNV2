using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTrue : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out UpdateImages update))
        {
            Debug.Log("Set to true");
            update.canChange = true;

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out UpdateImages update))
        {
            Debug.Log("Set to Falses");
            update.canChange = false;
        }
    }
}
