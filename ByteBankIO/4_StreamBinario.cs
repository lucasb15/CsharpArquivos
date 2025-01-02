using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {

        var caminhoNovoArquivo = "contaCorrente.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new BinaryWriter(fluxoDeArquivo))
        {
            escritor.Write(true);
            escritor.Write(false);
            escritor.Write(1564);
            escritor.Write("1564");
            escritor.Write("Gustavo Guanabara");
        }
        Console.WriteLine("Aplicação Finalizada...");
    }

    static void LeituraBinaria()
    {
        var caminhoNovoArquivo = "contaCorrente.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Open))
        using (var leitor = new BinaryReader(fluxoDeArquivo))
        {
            var verdadeiro = leitor.ReadBoolean();
            var falso = leitor.ReadBoolean();
            var numero = leitor.ReadInt32();
            var numeroFormatoString = leitor.ReadString();
            var nome = leitor.ReadString();

            Console.WriteLine($"Booleans: {verdadeiro} e {falso}\nNumeros: {numero} e {numeroFormatoString}\nNome: {nome}");
        }
    }
}