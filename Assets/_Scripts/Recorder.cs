using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    [SerializeField] private List<Vector3> _wayPoints;
    [SerializeField] private GameObject _ghost;

    private float _durationBetweenRecordingWaypoints = 2f;
    private GhostFollower _ghostFollower;
    
    private void Update()
    {
        //Считаем время между вейпоинтами
        _durationBetweenRecordingWaypoints -= Time.deltaTime;
        
        if (_durationBetweenRecordingWaypoints <= 0.0f)
        {
            BuildPath();
        }
    }

    private void BuildPath()
    {
        //Сохраняем вейпоинт один за одним в лист, сбрасывая таймер
        _wayPoints.Add(transform.position);
        _durationBetweenRecordingWaypoints = 2f;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("Player Crossed Finish Line");
            
            
            //Включаем призрака и передаем ему наши вейпоинты
            _ghost.SetActive(true);
            _ghostFollower = GameObject.Find("Ghost").GetComponent<GhostFollower>();

            _ghostFollower.FollowPlayer(_wayPoints.ToArray());
        }
    }
}
