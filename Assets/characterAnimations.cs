using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.Play("WalkAnimation"); // Nombre exacto de la animación
        }
    }
}
