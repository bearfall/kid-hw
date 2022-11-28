
using UnityEngine;
namespace bearfall
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸欲製物")]
        private GameObject prefabExplosion;
        [Header("受傷與爆炸音效")]
        [SerializeField] 
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞:" + collision.gameObject);

            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);


                SoundSystem.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundSystem.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));
                Destroy(gameObject);
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }

    }
}