using TMPro;
using UnityEngine;

public class EnemyUI : MonoBehaviour
{

    private TextMeshProUGUI _text;
    
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = $"Remaining Enemies: {EnemyManager.Instance.Count}";
    }
}
