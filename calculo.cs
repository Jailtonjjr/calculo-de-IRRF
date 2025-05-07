namespace chackpoint
{
    public class CalculoSalario
    {
        // Campo de classe
        public float Salario { get; private set; }
        public float SalarioBruto { get; private set; }
        public float valorInss { get; private set; }
        public float valorimposto { get; private set; }
        public int depedentes { get; private set; }
        public float Salario1;
        public float Salario2;
        public const float taxafixa1 = 142.80f;
        public const float taxafixa2 = 354.80f;
        public const float taxafixa3 =  636.13f;
        public const float taxafixa4 = 869.36f;
        
        public const float taxadepedente = 227.64f;
        // Construtor
        public CalculoSalario(float valorsalario, int depedente)
        {      
            SalarioBruto = valorsalario;
            depedentes = depedente;
            CalculoInss();
            CalculoImposto();
        }
         public void CalculoInss(){
            float desconto;
            
            
            if (SalarioBruto <=  1580.00f)
            {
            desconto = SalarioBruto * 0.075f;
            }
            else if (SalarioBruto <=  2793.88f && SalarioBruto >= 1580.01f)
            {
            desconto = SalarioBruto * 0.09f;
            }
            else if (SalarioBruto <=  4190.83f && SalarioBruto >= 2793.89f)
            {
            desconto = SalarioBruto * 0.12f;
            }
            else if (SalarioBruto <= 8157.41f  && SalarioBruto >= 4190.84f)
            {
            desconto = SalarioBruto * 0.14f;
            }
            else
            {  
                desconto = 1142.03f; 
            }
            valorInss = desconto;
            Salario = SalarioBruto - valorInss;
            Salario1 = Salario;
            Salario2 = Salario;
            // Console.WriteLine($"valor do inss E {valorInss}");
            }
            
            public void CalculoImposto()
            {   float valordeduzir;
                float Imposto;
                if(depedentes != 0){
                    valordeduzir = depedentes * taxadepedente;
                    Salario -= valordeduzir;
                }
                
                if (Salario <=  2428.80f)
                {
                    Imposto = 0;
                }
                else if(Salario <=  2826.65f && Salario >=2428.81f)
                {
                Imposto = Salario * 0.075f;
                valorimposto = Imposto - taxafixa1;
                }
                else if (Salario <=  3751.05f && Salario >= 2826.66f)
                {
                Imposto = Salario * 0.15f;
                valorimposto = Imposto - taxafixa2;
                }
                else if (Salario <=  4664.68f && Salario >= 3751.06f)
                {
                Imposto = Salario * 0.225f;
                valorimposto = Imposto - taxafixa3;
                }
                else if (Salario >= 4664.69f)
                {
                Imposto = 908.73f;
                valorimposto = Imposto - taxafixa4;
                }
                Salario2 -= valorimposto;
                // Console.WriteLine($"Sua taxa de IRRF E: R$ {valorimposto:F2}");
            
            }
            public void MostrarValor()
            {
                Console.WriteLine($"depedentes:  {depedentes}");
                Console.WriteLine($"Desconto INSS: R$ {valorInss:F2}");
                Console.WriteLine($"salario depois do desconto do INSS : R${Salario1:F2}");
                Console.WriteLine($"Sua taxa de IRRF é: R$ {valorimposto:F2}");
                Console.WriteLine($"salario depois do desconto do INSS e do IRRF: R${Salario2:F2}");
            }
    }
}
