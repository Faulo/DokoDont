using UnityEngine;

public sealed class NPCSpawner : MonoBehaviour {
    [SerializeField]
    NPC npcPrefab;

    [SerializeField]
    float spawnsPerHour = 1;

    [SerializeField]
    float speedVariation = 2;

    [SerializeField]
    float startingSpawns = 10;

    float spawnTimer;

    void OnEnable() {
        spawnTimer = startingSpawns;
    }
    void Update() {
        spawnTimer += spawnsPerHour * GameClock.deltaTime;
        while (spawnTimer > 1) {
            spawnTimer--;
            Spawn();
        }
    }
    public void Spawn() {
        var npc = Instantiate(npcPrefab, transform);

        var position = CreateRandomPosition();

        npc.rectTransform.anchorMin = position;
        npc.rectTransform.anchorMax = position;
        npc.rectTransform.anchoredPosition = Vector2.zero;

        Color.RGBToHSV(npc.color, out _, out float s, out float v);
        npc.color = Color.HSVToRGB(Random.value, s, v);

        npc.speed *= Random.Range(1 / speedVariation, speedVariation);

        npc.rotation = Random.Range(0f, 360f);
    }

    Vector2 CreateRandomPosition() {
        return (object)Random.Range(0, 4) switch {
            0 => new Vector2(-0.1f, Random.value),
            1 => new Vector2(1.1f, Random.value),
            2 => new Vector2(Random.value, -0.1f),
            3 => new Vector2(Random.value, 1.1f),
            _ => throw new System.NotImplementedException(),
        };
    }
}
