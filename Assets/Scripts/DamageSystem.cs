
using UnityEngine;
namespace bearfall
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z�����s��")]
        private GameObject prefabExplosion;
        [Header("���˻P�z������")]
        [SerializeField] 
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("�I��:" + collision.gameObject);

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