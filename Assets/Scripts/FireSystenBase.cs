
using UnityEngine;
namespace bearfall
{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u���s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;
        [SerializeField, Header("�o�g����")]
        private AudioClip soundFire;

        //�ͦ��l�u
        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundSystem.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}