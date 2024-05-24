using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showcube : MonoBehaviour
{
    [SerializeField] private Vector3 _size;
    [SerializeField] private Vector3 _position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position +_position, _size/ 1);
    }
}
