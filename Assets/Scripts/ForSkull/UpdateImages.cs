using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateImages : MonoBehaviour
{
    [SerializeField] private Frontal _frontal;
    [SerializeField] private Axial _axial;
    [SerializeField] private Sagital _sagital;
    [SerializeField] private Transform origin;
    [SerializeField] private RawImage _frontalImage;
    [SerializeField] private RawImage _axialImage;
    [SerializeField] private RawImage _sagitalImage;

    public bool canChange = false;
    private float len_frontal = 0;
    private float len_sagital = 0;
    private float len_axial = 0;


    // Start is called before the first frame update
    void Start()
    {
        len_frontal = _frontal.textures.Count;
        len_axial = _axial.textures.Count;
        len_sagital = _sagital.textures.Count;
    }

    // Update is called once per frame
    void Update()
    {

        if (canChange == true)
        {

            UpdateAxial();
            UpdateFrontal();
            UpdateSagital();
        }
    }

    private void UpdateFrontal()
    {
        float divi = (1.644694f/ 10f) / len_frontal;
        float dist = Math.Abs(origin.position.z - transform.position.z);
        for (int i = 0; i < len_frontal; i++)
        {
            if (i*divi > dist)
            {
                _frontalImage.texture = _frontal.textures[i];
                //Debug.Log("Frontal:" + i + "de" + len_frontal);
                break;
            }
            //Debug.Log(i*divi);
        }
        //Debug.Log("dist" + dist);
        //Debug.Log("divi" + divi);
    }

    private void UpdateSagital()
    {
        float divi = (1.33089f / 10f) / len_sagital;
        float dist = Math.Abs(origin.position.x - transform.position.x);
        for (int i = 0; i < len_sagital; i++)
        {
            if (i * divi > dist)
            {
                _sagitalImage.texture = _sagital.textures[i];
                Debug.Log("distancia: " + dist);
                Debug.Log(dist + "*" + i + "=" + (i * dist));
                Debug.Log("Sagital:"+i + "de" + len_sagital);
                break;
            }
        }
    }

    private void UpdateAxial()
    {
        float divi = (1.376369f / 10f) / len_axial;
        float dist = Math.Abs(origin.position.y - transform.position.y);
        for (int i = 0; i < len_axial; i++)
        {
            if (i * divi > dist)
            {
                _axialImage.texture = _axial.textures[i];
               
                //Debug.Log("Axial:" + i + "de" + len_axial);
                break;
            }
        }
    }
}
