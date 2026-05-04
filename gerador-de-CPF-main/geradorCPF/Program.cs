using System.Numerics;


for (BigInteger i = 0; i <= 999999999; i++)
{
    String cpf = i.ToString().PadLeft(9, '0');
    int multiplicador = 10;
    int somatorioCPF = 0;
    foreach (Char carac in cpf)
    {
        int ci = int.Parse(carac.ToString());
        somatorioCPF += ci * multiplicador;
        multiplicador--;
    }
    // primeiro digito
    int primeiroDig;

    int restoDiv11 = somatorioCPF%11;
    if (restoDiv11 < 2)
        primeiroDig = 0;
    else
        primeiroDig = 11 - restoDiv11;

    cpf += primeiroDig.ToString();
    
    // segundo digito

    int multiplicadorSegundoDig = 11;
    int somatorioCPFdig2 = 0;
    foreach (Char carac in cpf)
    {
        int ci2 = int.Parse(carac.ToString());
        somatorioCPFdig2 += ci2 * multiplicadorSegundoDig;
        multiplicadorSegundoDig--;
    }
    int segundoDig;
    restoDiv11 = somatorioCPFdig2 % 11;

    if (restoDiv11 < 2)
        segundoDig = 0;
    else 
        segundoDig = 11 - restoDiv11;

    cpf += segundoDig.ToString();

    string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
    Console.WriteLine(cpfFormatado);


}

