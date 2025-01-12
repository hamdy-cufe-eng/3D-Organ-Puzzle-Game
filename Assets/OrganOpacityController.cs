using UnityEngine;

public class OrganOpacityController : MonoBehaviour
{
    public float transparency = 0.5f; // Set between 0 (fully transparent) and 1 (fully opaque)

    private void Start()
    {
        SetTransparency(transparency);
    }

    public void SetTransparency(float alpha)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            Color color = renderer.material.color;
            color.a = alpha;
            renderer.material.color = color;
        }
    }
}
