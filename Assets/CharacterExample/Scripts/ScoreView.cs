using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ScoreView : MonoBehaviour
{
    private Score _score;

    [SerializeField] private TMP_Text _value;

    public void Intialize(Score score)
    {
        _score = score;
        _score.Changed += OnValueChanged;
        OnValueChanged(_score.Value);
    }

    private void OnValueChanged(int value) => _value.text = value.ToString();
}
