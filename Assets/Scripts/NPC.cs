using Slothsoft.UnityExtensions;
using UnityEngine;
using UnityEngine.UI;

public sealed class NPC : MonoBehaviour {
    [SerializeField]
    public RectTransform rectTransform;
    [SerializeField]
    Image body;
    [SerializeField]
    GameObject card;
    [SerializeField]
    float transparentAlpha = 0.5f;

    public float speed { get; set; } = 20;

    public float rotation { get; set; } = 0;

    public Color color {
        get => body.color;
        set => body.color = value;
    }

    public bool isHappy {
        get => card.activeSelf;
        set => card.SetActive(value);
    }

    void Update() {
        rectTransform.anchoredPosition += speed * Time.deltaTime * Rotate(Vector2.right, rotation);
    }

    public void BecomeTransparent() {
        color = color.WithAlpha(transparentAlpha);
    }

    static Vector2 Rotate(Vector2 v, float degrees) {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }
}
