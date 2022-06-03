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
    /// Шукаємо тверду повехню під ногами
    /// </summary>
    private void DetectGround()
    {
        // Довжина променя
        float rayLenght = 1.5f;

        // Створюємо промінь
        Ray ray = new Ray(transform.position, Vector3.down);

        // Малюємо промінь у вікні сцени
        Debug.DrawRay(ray.origin, ray.direction * rayLenght, Color.red);

        // Шукаємо колайдери на шляху променя
        if (Physics.Raycast(ray, out RaycastHit hit, rayLenght))
        {
            // Якщо колайдер має тег Dynamic,
            if (hit.transform.gameObject.CompareTag("Dynamic"))
            {
                // то встановлюємо платформу батьківським об'єктом для персонажа
                
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
                // Якщо не знайдено рухомих платформ під ногами,
                // то звільняємо персонажа
                transform.parent = null;
            }
        }
    }

