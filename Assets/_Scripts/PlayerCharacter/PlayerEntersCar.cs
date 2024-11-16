using Ashsvp;
using UnityEngine;


public class PlayerEntersCar : MonoBehaviour
{
    private SimcadeVehicleController _simcadeVehicleController;
    private Recorder _recorder;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("EnterCarTrigger") && Input.GetKeyDown(KeyCode.F))
        {
            //Если игрок находится в зоне посадки в машину, отключаем игрока и передаем управление машине, включив запись вейпоинтов
            
            _simcadeVehicleController = GameObject.Find("PlayerCar").GetComponent<SimcadeVehicleController>();
            _simcadeVehicleController.enabled = true;
            
            _recorder = GameObject.Find("PlayerCar").GetComponent<Recorder>();
            _recorder.enabled = true;
            
            Debug.Log("Player Enters The Car");
            gameObject.SetActive(false);
        }
    }

    
}
