using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _color;

    public void SetColor()
    {
        _image.color = _color;
    }
}
