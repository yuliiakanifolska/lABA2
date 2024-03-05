using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

Dictionary<string, double> dict = new Dictionary<string, double>();
Dictionary<string, double> result_dict = new Dictionary<string, double>();

dict.Add("item1", 45.5);
dict.Add("item2", 35);
dict.Add("item3", 41.3);
dict.Add("item4", 55);
dict.Add("item5", 24);

for (int i = 0; i < 3; i++)
{
    string temp = "";
    double maxValue = double.MinValue;

    foreach (var key in dict.Keys)
    {
        if (dict[key] > maxValue)
        {
            maxValue = dict[key];
            temp = key;

        }
    }

    Console.WriteLine($"{temp} {dict[temp]}");
    result_dict.Add(temp, dict[temp]);
    dict.Remove(temp);

}

string json = JsonSerializer.Serialize(result_dict);
string filePath = "./file.json";
File.WriteAllText(filePath, json);


string jsonData = File.ReadAllText(filePath);

Console.WriteLine("\nJSON data read from file:");
Console.WriteLine(jsonData);
Console.ReadKey();