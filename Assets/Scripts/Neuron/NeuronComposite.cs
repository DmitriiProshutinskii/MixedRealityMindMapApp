using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuronComposite : Neuron
{
    protected List<Neuron> _children = new List<Neuron>();
    public override string GetInfo()
    {
        throw new System.NotImplementedException();
    }

    public override void Add(Neuron component)
    {
        this._children.Add(component);
        component.gameObject.transform.SetParent(transform);
    }

    public override void Remove(Neuron component)
    {
        this._children.Remove(component);
        //Что делать, если у него есть ещё кто-то

        Destroy(component);
    }

    public override void Hide(Neuron component) 
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override bool IsComposite()
    {
        return true;
    }

    public override void Delete()
    {
        
    }
}
