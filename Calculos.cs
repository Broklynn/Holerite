using Estudos_Forms;
using System;
using System.Globalization;
using static Estudos_Forms.Pessoas;

namespace estudos_Classes
{
    public class Calculos
    {
        double inss;
        double deducao;

        public double INSS(double _salarioBruto)
        {
            if (_salarioBruto <= 1412.00)
            {
                inss = 0.075;
                deducao = 0.00;
            }
            else if (_salarioBruto <= 1412.01)
            {
                inss = 0.09;
                deducao = 21.18;
            }
            else if (_salarioBruto <= 4000.03)
            {
                inss = 0.12;
                deducao = 101.18;
            }
            else if (_salarioBruto > 4000.04)
            {
                inss = 0.14;
                deducao = 181.18;
            }
            return _salarioBruto - ((_salarioBruto - deducao) * inss);
        }

        public double Transporte(double salario, double valeTransporte)
        {
            double valorTotalValeTransporte = valeTransporte * 22;
            double descontoMaximo = salario * 0.06;
            double valorDescontado = valorTotalValeTransporte <= descontoMaximo ? valorTotalValeTransporte : descontoMaximo;

            Console.WriteLine("Desconto Máximo: R$" + descontoMaximo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Vale Transporte Utilizado: R$" + valorTotalValeTransporte.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Vale Transporte Descontado: R$" + valorDescontado.ToString("F2", CultureInfo.InvariantCulture));

            return valorDescontado;
        }

        public double Saude(double salario, double planoSaude)
        {
            Console.WriteLine("Plano de Saúde: R$" + planoSaude.ToString("F2", CultureInfo.InvariantCulture));
            return planoSaude;
        }

        public void PagarSalario(double salario, string nome)
        {
            double descontoINSS = INSS(salario);

            Console.WriteLine($"Efetuando pagamento para: {nome}");
            Console.WriteLine($"Salário original R$: {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Desconto INSS : {(salario * inss).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Dedução R$: {deducao.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Salário após INSS R$: {descontoINSS.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void TodosDescontos(double salario, string nome, double valeTransporte, double planoSaude)
        {
            double descontoINSS = INSS(salario);
            double descontoValeTransporte = Transporte(salario, valeTransporte);
            double descontoPlanoSaude = Saude(salario, planoSaude);

            double salarioLiquido = salario - descontoINSS - descontoValeTransporte - descontoPlanoSaude;

            Console.WriteLine($"Efetuando pagamento para: {nome}");
            Console.WriteLine($"Salário original: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Desconto INSS: R$ {descontoINSS.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Desconto Vale Transporte: R$ {descontoValeTransporte.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Desconto Plano de Saúde: R$ {descontoPlanoSaude.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Salário após descontos: R$ {salarioLiquido.ToString("F2", CultureInfo.InvariantCulture)}");
        }
       
    }
}
