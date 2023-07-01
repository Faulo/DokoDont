using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public sealed class ResultsAsset : ScriptableObject {
    [SerializeField]
    TextAsset data;
    [SerializeField]
    ModalityBase dokomi;
    [SerializeField]
    ModalityBase gameJam;
    [SerializeField]
    ModalityBase sleep;

    record Result {
        public int dokomi;
        public int gameJam;
        public int sleep;
        public string name;
    }

    List<Result> results;

    public bool TryLookupResult(out string result) {
        Initialize();
        result = results.First().name;
        return true;
    }

    void Initialize() {
        if (results is null) {
            results = new();

            var rows = data.text.Split('\n').Skip(1);
            foreach (string row in rows) {
                string[] fields = row.Split(',');
                var result = new Result {
                    dokomi = int.Parse(fields[0]),
                    gameJam = int.Parse(fields[1]),
                    sleep = int.Parse(fields[2]),
                    name = fields[3],
                };
                results.Add(result);
            }
        }
    }
}
