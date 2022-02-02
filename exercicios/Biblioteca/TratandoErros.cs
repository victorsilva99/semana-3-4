using System;
using static System.Console;

namespace Cap06
{
  public class TratamentoExececao
  {
      public void ExemploTratamentoExcecao()
      {
          WriteLine("Divião de dois números");
          WriteLine("");
          WriteLine("Digite o primeiro número:");
          var strNum1 = ReadLine();
          WriteLine("Digite o segundo número:");
          var strNum2 = ReadLine();

          try
          {
            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);

            var divisao = num1 / num2;
            WriteLine($"A divisão de {num1} por {num2} é {divisao}");
          }
            catch (DivideByZeroException ex)
            {
                WriteLine($"Erro de divião por zero: {ex.Message}");
            }
            catch (FormatException ex)
            {
                WriteLine($"Erro de formatação: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"Erro na divisão: {ex.Message}");
            }
            finally
            {
                WriteLine("Sempre vai executar o Finally");
            }
        WriteLine("Fim");

      }
  }
    
}