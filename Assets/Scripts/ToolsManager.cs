using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsManager : MonoBehaviour
{
    Dictionary<string, GameObject> Tools;
    bool flag;

    void Start()
    {
        Tools = new Dictionary<string, GameObject>();
    }

    public void AddTools(string key, GameObject tool)
    {
        if (Tools.Count == 0)
        {
            Tools.Add(key, tool);
        }
        else
        {
            foreach (KeyValuePair<string, GameObject> instrument in Tools)
            {
                if (instrument.Key == key)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag == true)
            {
                Tools.Add(key, tool);
            }
        }
    }

    public GameObject GetTool(string key)
    {
        return Tools[key] as GameObject;
    }

    public void SeeTool()
    {

        foreach (var tool in Tools)
        {
            Debug.Log(tool.ToString());
        }
    }

    public bool ToolHas()
    {
        return Tools.Count > 0;
    }
}
