using UnityEngine;

public class Coroutine : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        this.renderer = GetComponent<Renderer>();
    }
    private void OnMouseDown()
    {
        Fade();
    }

    void Fade()
    {
        Color c = renderer.material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            renderer.material.color = c;
        }

        c.a = 0f;
        renderer.material.color = c;
    }
}
