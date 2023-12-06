using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    GameObject _target;
    private void Awake()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        if (_target == null)
        {
            Debug.Log("ターゲットを取得できていない");
        }
        else
        {
            Debug.Log("ターゲットを取得");
        }
    }

    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
}
