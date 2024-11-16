using TMPro;
using UnityEngine;


public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _lapCounter;
    [SerializeField] private int _currentLap;
    private void Awake()
    {
        _currentLap = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            _currentLap++;
            _lapCounter.text = "LAP: " + _currentLap;
            
        }
    }

}

