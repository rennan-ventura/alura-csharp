class Produto
{
    private double preco;
    private int estoque;
    public string nome { get; set; }
    public string marca { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (preco < 0)
            {
                Console.WriteLine("Preço inválido");
            }
            else
            {
                preco = value;
            }
        }
    }
    public int Estoque
    {
        get => estoque;
        set
        {
            if (estoque < 0)
            {
                Console.WriteLine("Estoque não pode ser negativo");
            }
            else
            {
                estoque = value;
            }
        }
    }

    public string descricaoDetalhada => $"Produto: {nome} marca: {marca} preco: {preco} estoque: {estoque}";

}