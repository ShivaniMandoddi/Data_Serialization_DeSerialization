using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;

public class NestedData : MonoBehaviour
{
    // Start is called before the first frame update
    string filePath;
    string names = "Shivani";
    private int score = 40;
    private int maxScore = 100;
    private int health = 3;
    private int maxHealth = 5;
    [System.Serializable]
    public class ToSerializeData
    {
        public string names;
        public int score;
        public int health;
        public int maxScore;

    }
    void Start()
    {
        ToSaveTheData();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            LoadTheData();
        }    
    }
    public void ToSaveTheData()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        
        filePath = Application.persistentDataPath + "/SerializedData.shivani";
        //FileStream fileStream = File.Open(filePath,FileMode.OpenOrCreate);
        FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        //BinaryWriter binaryWriter = new BinaryWriter(fileStream);
        
        ToSerializeData Instance=new ToSerializeData();
        Instance.names = names;
        Instance.score = score;
        Instance.health = health;
        Instance.maxScore = 100;
        binaryFormatter.Serialize(fileStream, Instance);
        fileStream.Close();
    }
    public void LoadTheData()
    {
        filePath = Application.persistentDataPath + "/SerializedData.shivani";
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = File.Open(filePath, FileMode.Open);
        ToSerializeData Instance = binaryFormatter.Deserialize(fileStream) as ToSerializeData;
       // string myData = Instance.ToString();
        Debug.Log(Instance.names);
        Debug.Log(Instance.score);
        Debug.Log(Instance.health);
        Debug.Log(Instance.maxScore);
        //Debug.Log(myData);
        fileStream.Close();
    }
}
//FileStream,BinaryReader,BinaryWriter,BinaryFormatter functionality.

