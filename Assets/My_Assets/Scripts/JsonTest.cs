using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class JsonTest : MonoBehaviour {

    [ContextMenu("Save")]
    void Save()
    {
        Item item = new Item();
        item.ID = 1;
        item.time = 0.1f;
        item.hoge = "hogehoge";

        item.BaseID = 100;
        item.BaseTime = 100.0f;

        string itemJson = JsonUtility.ToJson(item);
        Debug.Log(itemJson);

        string path = Application.streamingAssetsPath;

        var writer = new StreamWriter(path + "\\hoge.json", false);
        writer.WriteLine(itemJson);
        writer.Flush();
        writer.Close();

    }
}

[Serializable]
public class Item : ItemBase
{
    public int ID;
    public float time;
    public string hoge;
}

[Serializable]
public class ItemBase
{
    public int BaseID;
    public float BaseTime;
}
