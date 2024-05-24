using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dicom.Imaging;
using UnityEngine.UI;
using System.IO;
using System.Linq;

using System;

public class Frontal : MonoBehaviour
{
    [SerializeField] private RawImage _Image;
    [SerializeField] public int n = 0;
    [SerializeField] public List<Texture> textures = new List<Texture>();
    private int a = 11;

    //private string _folderPath = "D:/Neuronavegador/Tomos2/3D bone brain/Frontal/frontal_dcm/1.2.392.200036.9116.2.6.1.41014.3158035852.1712823319.147596/SE00001";
    private string _folderPath = "D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN";
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        for (int i = 0; i < 512; i++)
        {
            SetImages();
        }
        
    }

    private void SetImages()
    {
        int b = a;
        foreach (string file in Directory.EnumerateFiles(_folderPath))
        {
            
            Debug.Log(file);
            Debug.Log("Is tracking: " + @"D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN\I" + a.ToString() + "00000");
            if (file != @"D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN\VERSION")
            {
                //Debug.Log("FILE:" + file);
                 //Debug.Log(file == @"D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN\I" + a.ToString() + "00000");
                 if (a<100)
                 {
                     //Debug.Log("D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN/I" + a.ToString() + "00000");

                     if (file == @"D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN\I" + a.ToString() + "00000")
                     {
                         //Debug.Log(">100");
                         AddToList(file);
                         break;
                     }
                 }
                 if (textures.Count>=88)
                 {
                     if (a < 100)
                     {
                         a = 101;
                     }
                     //Debug.Log("D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN/I" + a.ToString() + "0000");
                     if (file == @"D:/Neuronavegador/Plano_Frontal/ISCUWPEP/DBROIMRN\I" + a.ToString() + "0000")
                     {
                         //Debug.Log(a);
                         AddToList(file);
                         break;
                     }
                 }
                
             }
             
                //AddToList(file
        }
        if (b == a) a++;
    }

    private void AddToList(string file)
    {
        //Debug.Log(file);
        var image = new DicomImage(file);
        var texture = image.RenderImage().AsTexture2D();
        textures.Add(texture);
        a++;
    }
}