using System;
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
        public Grade dokomi;
        public Grade gameJam;
        public Grade sleep;
        public string name;
    }

    List<Result> results;

    public bool TryLookupResult(out string name) {
        Initialize();

        foreach (var result in results) {
            if (result.dokomi <= dokomi.valueAsGrade
             && result.gameJam <= gameJam.valueAsGrade
             && result.sleep <= sleep.valueAsGrade) {
                name = result.name;
                return true;
            }
        }

        name = default;
        return false;
    }

    void Initialize() {
        if (results is null) {
            results = new();

            var rows = data.text.Split('\n').Skip(1);
            foreach (string row in rows) {
                string[] fields = row.Split(',');
                var result = new Result {
                    dokomi = Enum.Parse<Grade>(fields[0]),
                    gameJam = Enum.Parse<Grade>(fields[1]),
                    sleep = Enum.Parse<Grade>(fields[2]),
                    name = fields[3],
                };
                results.Add(result);
            }
        }
    }
}
