using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuronsManager : MonoBehaviour
{
    [Header("Neuron Prefab")]
    [SerializeField]
    private GameObject neuronPrefab;
    private GameObject neuronGO;

    private List<Neuron> neurons;
    // Start is called before the first frame update
    void Start()
    {
        neurons = new List<Neuron>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create()
    {
        neuronGO = GameObject.Instantiate(neuronPrefab, transform.position + transform.forward * 0.7f, transform.rotation);
        var neuron = neuronGO.AddComponent<NeuronLeaf>();
        neurons.Add(neuron);
    }
}
