using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
class WorkingWithFile
{
    public bool WriteTexFromFile(string FileName, string _value)
    {
        bool result = false;
        FileStream file = new FileStream(FileName, FileMode.OpenOrCreate);
        using(StreamWriter writer = new StreamWriter(file, Encoding.Unicode))
        {
            writer.WriteLine(_value);
            result = true;
        }
        return result;
    }
    public string ReadTextFromFile(string FileName)
    {
        string result;
        FileStream file = new FileStream(FileName, FileMode.OpenOrCreate);
        using (StreamReader reader = new StreamReader(file, Encoding.Unicode))
        {
            result = reader.ReadToEnd();
        }
        return result;
    }
    public List<T> GetFromFile<T>(string FileName)
    {
        var temp = new List<T>();
        string text = ReadTextFromFile(FileName);
        if(text != null) temp = JsonConvert.DeserializeObject<List<T>>(text);
        return temp;
    }
    public void PushFromFile<T>(string FileName, List<T> _value)
    {
        string text = JsonConvert.SerializeObject(_value);
        WriteTexFromFile(FileName, text);
    }
}