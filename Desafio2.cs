public class Desafio2 : MonoBehaviour
{
   public int numero1;
   public int numero2;
   public int numero3;
   public int numero_maior;
    void Start()
    {
       if (numero_maior >= numero1 && numero_maior >= numero2 && numero_maior >= numero3)
        {
            Debug.Log("O maior numero é: " + numero_maior);
        }
        else
        {
            Debug.Log("seu codigo ta errado seu fudido");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
