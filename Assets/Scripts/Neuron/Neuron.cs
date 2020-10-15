using System;
using UnityEngine;

public abstract class Neuron: MonoBehaviour
{
    private string itemName = string.Empty;
    private GameObject icon;

    public virtual void SetUp(string name, GameObject icon)
    {
        this.itemName = name;
        this.icon = icon;
    }

    public string GetName()
    {
        return itemName;
    }

    public GameObject GetIcon()
    {
        return icon;
    }

    public virtual void Add(Neuron component) { }

    public virtual void Remove(Neuron component) { }

    public virtual bool IsComposite()
    {
        return false;
    }

    public virtual void Hide(Neuron component) { }

    public abstract void Delete();

    public abstract string GetInfo();



}
