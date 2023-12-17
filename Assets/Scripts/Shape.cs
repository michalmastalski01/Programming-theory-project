using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    private string m_name;
    public string shapeName
    {
        get
        {
            return m_name;
        }
        set
        {
            if(name.Length < 15)
            {
                m_name = value;
            }
            else
            {
                {
                    Debug.LogError("Too long name.");
                }
            }
        }

    }

    [SerializeField]private Material[] shapeColor;

    // ABSTRACTION
    public void ChangeColor()
    {
        int colorIndex = Random.Range(0, shapeColor.Length);
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        if (shapeColor[colorIndex] == meshRenderer.material)
        {
            ChangeColor();
        }
        meshRenderer.material = shapeColor[colorIndex];
    }
    // POLYMORPHISM
    public void Move(Vector3 position)
    {
        transform.position = position;
    }
    public void Move(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }
    public abstract string DisplayText();

    private void OnMouseDown()
    {
        ChangeColor();
        UIHandler.Instance.UpdateText(m_name);
        Debug.Log($"I clicked on {m_name}");
    }


}
