class Carro
{
    public string fabricante { get; set; }
    public string modelo { get; set; }
    public int ano
    {
        get => ano;
        set
        {
            if (value < 1996 || value > 2023)
            {
                Console.WriteLine("Ano inválido");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int quantidadePortas { get; set; }
    public string descricaoDetalhada => $"Fabricante: {fabricante} Modelo: {modelo} Ano do carro: {ano}";
    public int velocidade = 0;

    public void exibirInformacoes(){
        Console.WriteLine($"Informações do carro: {this.fabricante} {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }
    
    public void acelerar(){
        Console.WriteLine("Acelerando...");
        if(velocidade < 100){
            velocidade = velocidade + 5;
        }
    }

    public void frear(){
        Console.WriteLine("Freando...");
        if(velocidade > 0){
            velocidade = velocidade - 5;
        }
    }

    public void buzinar(){
        Console.WriteLine("Bi Bi");
    }
}
