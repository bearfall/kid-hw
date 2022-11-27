using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bearfall
{
    /// <summary>
    /// �R������
    /// </summary>

    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameObject ���}�����C������
            //�R��(����A�R���ɶ�)
            Destroy(gameObject, destroyTime);
        }
    }
}
