using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Rigidbody2D _rigidbody;
    public InputAction enterShopAction;
    public int Coins = 250;
    public int OutfitNumber = 0;
    private bool CanMove = true;
    Vector3 startScale;
    
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        startScale = transform.localScale;
        SubscribeToEvents();
        
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        //objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
    }

    //void LateUpdate()
    //{
    //    Vector3 viewPos = transform.position;
    //    viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
    //    viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
    //    transform.position = viewPos;
    //}

    void FixedUpdate()
    {
        if (CanMove)
        {
            Move();
        }
    }

    private void OnDestroy()
    {
        UnsubscribeFromEvents();
    }

    private void SubscribeToEvents()
    {
        enterShopAction.Enable();
        enterShopAction.performed += EnterShop;
    }

    private void UnsubscribeFromEvents()
    {
        enterShopAction.performed -= EnterShop;
        enterShopAction.Disable();
    }

    private void EnterShop(InputAction.CallbackContext obj)
    {
        if (GameManager.Instance.Shop.CanEnter())
        {
            SetCanMove(false);
            GameManager.Instance.UIManager.OpenUI();
        }
    }

    public void SetCanMove(bool canMove)
    {
        CanMove = canMove;
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * _speed * Time.deltaTime;
            transform.localScale = new Vector3(-startScale.x, startScale.y, startScale.z);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * _speed * Time.deltaTime;
            transform.localScale = startScale;
        }
    }
}
