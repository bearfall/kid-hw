using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace bearfall
{
    /// <summary>
    /// ���޲z��
    /// </summary>

    public class MenuManager : MonoBehaviour
    {
        /// <summary>
        /// �}�l�C��
        /// </summary>
        private Button btnPlay;
        private void Awake()
        {
            btnPlay = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }
        private void StartGame()
        {
            SceneManager.LoadScene("�C������");
        }
    }
}