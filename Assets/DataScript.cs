using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name="Shivani";
    public int age = 20;

    public string fileName = @"C:\Users\Shivani.Mandoddi\Desktop\GameDesignDocuments\SampleFile.txt";
    void Start()
    {
        /*if(File.Exists(fileName))
         {
             Debug.Log("File Exists");
             using FileStream fileStream = File.Open(fileName, FileMode.Create);
             using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
             binaryWriter.Write(1);
         }*/
        /*StreamWriter streamWriter = new StreamWriter(fileName);
        //using BinaryWriter binaryWriter = new BinaryWriter(streamWriter.BaseStream);
        streamWriter.WriteLine(age);
        streamWriter.WriteLine(Name);
        streamWriter.Close();
        CreateText();
        ReadText();
        
        StreamReader streamReader = new StreamReader(fileName);
        Debug.Log(streamReader.ReadToEnd());
        streamReader.Close();*/
        
    }

   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            CreateText();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReadText();
        }
    }
    public void CreateText()                           //Encrypting the message
    {
        FileStream fileStream = new FileStream(fileName, FileMode.Open);
        using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
        binaryWriter.Write(age);
        binaryWriter.Write(Name);
       // binaryWriter.Write(2.8f);
        //binaryWriter.Write('s');
        fileStream.Close();
    }
    private void ReadText()         // Reading by Decrypting message
    {
        FileStream fileStream = new FileStream(fileName, FileMode.Open);
        using BinaryReader binaryReader = new BinaryReader(fileStream);
        Debug.Log(binaryReader.Read());
       // Debug.Log(binaryReader.ReadString());
        //binaryReader.Read(Name);
        fileStream.Close();
    }

}
