using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        shapeName = "Lucia";
    }
    public override string DisplayText()
    {
        return $"This is a sphere, it's name is {shapeName}";
    }
}
