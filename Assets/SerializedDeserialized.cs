using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class SerializedDeserialized : MonoBehaviour
{
    // Start is called before the first frame update
    string filePath;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            SaveData();
        }
    }

    private void LoadData()
    {
        filePath = Application.persistentDataPath + "/MyFile.shivani";
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        BinaryReader binaryReader = new BinaryReader(fileStream);
        Debug.Log(binaryReader.ReadString());
        Debug.Log(binaryReader.ReadString());
        Debug.Log(binaryReader.ReadString());
        Debug.Log(binaryReader.ReadInt32());
       binaryReader.Close();
       fileStream.Close();
    }

    private void SaveData()
    {
        filePath = Application.persistentDataPath + "/MyFile.shivani";
        FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryWriter binaryWriter = new BinaryWriter(fileStream);
        binaryWriter.Write("Hello! My Name is Shivani");
        binaryWriter.Write("I am working on unity");
        binaryWriter.Write("Designing 2d and 3d games");
        binaryWriter.Write(5);
        binaryWriter.Close();
        fileStream.Close();
     }
}
/* Creating a Nested Class
 * Define variables
 * create class to serialize
 * to create instance of class
 * save the data
 */
