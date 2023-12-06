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
            Debug.Log("�^�[�Q�b�g���擾�ł��Ă��Ȃ�");
        }
        else
        {
            Debug.Log("�^�[�Q�b�g���擾");
        }
    }

    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
}
