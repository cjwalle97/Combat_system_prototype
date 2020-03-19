using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : ScriptableObject
{
    public string name;
    public int value;
    
    public int SetModifier (int a)
    {
        int x = -5;
        int y = 1;
        while (y != a)
        {
            if (y < a)
            {
                y = y + 2;
                x = x + 1;
            }
            if (y > a)
            {
                y = y - 1;
            }
        }
        return x;
    }
}
