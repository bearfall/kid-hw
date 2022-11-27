using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bearfall
{
    /// <summary>
    /// 刪除物件
    /// </summary>

    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameObject 此腳本的遊戲物件
            //刪除(物件，刪除時間)
            Destroy(gameObject, destroyTime);
        }
    }
}
