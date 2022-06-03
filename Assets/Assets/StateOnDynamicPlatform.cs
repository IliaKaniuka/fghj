using UnityEngine;

public class StateOnDynamicPlatform : MonoBehaviour
{ public Camera fpsCam;
    public float boatspeed = 1f;
    public Vector2 turn;
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Update()
    {
     
        DetectGround();
    }

    /// <summary>
    /// ������ ������ ������� �� ������
    /// </summary>
    private void DetectGround()
    {
        // ������� �������
        float rayLenght = 1.5f;

        // ��������� ������
        Ray ray = new Ray(transform.position, Vector3.down);

        // ������� ������ � ��� �����
        Debug.DrawRay(ray.origin, ray.direction * rayLenght, Color.red);

        // ������ ��������� �� ����� �������
        if (Physics.Raycast(ray, out RaycastHit hit, rayLenght))
        {
            // ���� �������� �� ��� Dynamic,
            if (hit.transform.gameObject.CompareTag("Dynamic"))
            {
                // �� ������������ ��������� ����������� ��'����� ��� ���������
                
                if (Input.GetKey(KeyCode.LeftShift)) {
                  
                    transform.parent = hit.transform;
                    turn.x += Input.GetAxis("Mouse X");
                   
                    transform.parent.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
                    GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
                    if (Input.GetKey(KeyCode.W))
                    {
                        transform.parent.position += transform.forward * boatspeed;
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        transform.parent.position += transform.forward * -boatspeed;
                    }
                    if (Input.GetKey(KeyCode.A))
                    {
                        transform.parent.position += transform.right * -boatspeed;
                    }

                    if (Input.GetKey(KeyCode.D))
                    {
                        transform.parent.position += transform.right * boatspeed;
                    }
                }
                
            }
        }
             
            else
            {
                // ���� �� �������� ������� �������� �� ������,
                // �� ��������� ���������
                transform.parent = null;
            }
        }
    }

