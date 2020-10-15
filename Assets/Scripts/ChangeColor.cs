using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    bool isLookAt = false;
    MeshRenderer renderer;
    [SerializeField]
    Color lookedColor = new Color(205, 92, 92);
    [SerializeField]
    Color defaultColor = new Color(0,0,255);

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    public void SwitchColor()
    {
        if(isLookAt)
        {
            renderer.material.color = lookedColor;
        }
        else
        {
            renderer.material.color = defaultColor;
        }
        isLookAt = !isLookAt;
    }
}
