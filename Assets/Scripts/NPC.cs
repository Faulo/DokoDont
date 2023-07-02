using UnityEngine;
using UnityEngine.UI;

public sealed class NPC : MonoBehaviour {
    [SerializeField]
    RectTransform rectTransform;
    [SerializeField]
    Image body;
    [SerializeField]
    GameObject card;

    public float speed { get; set; } = 10;

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
