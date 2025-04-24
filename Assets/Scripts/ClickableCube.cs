using UnityEngine;

public class ClickableCube : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}