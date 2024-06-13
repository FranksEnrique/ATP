Using system; 


class Program
{

public static void Main(){
    condole.WriteLine("Escolha um exercicío da lista 5 (de um a 10): ");
    int num = int.Parse(Console.ReadLine());
     
     switch (num)
     {
     case 1:
     Exercicío_01_lista_05 exercicío_01_lista_05 = new Exercicío_01_lista_05();
     exercicío_01_lista_05.Rodar();
     break;
     }

}
}