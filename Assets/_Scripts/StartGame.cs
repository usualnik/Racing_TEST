using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
   [SerializeField] private Button _startButton;
   [SerializeField] private GameObject _playerChar;

   public void StartGameScript()
   {
      //Передаем управление персонажу игрока в начале игры
      _startButton.gameObject.SetActive(false);
      _playerChar.gameObject.SetActive(true);
   }
}
