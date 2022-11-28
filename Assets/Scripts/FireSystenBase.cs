
using UnityEngine;
namespace bearfall
{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈欲製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        //生成子彈
        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundSystem.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}