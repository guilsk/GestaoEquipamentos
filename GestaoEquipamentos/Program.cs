using System.Collections;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace GestaoEquipamentos
{
    internal class Program
    {
        static void CadastroEquipamento(ArrayList nome, ArrayList preco, ArrayList numSerie, ArrayList dataFab, ArrayList fabricante)
        {
            Console.WriteLine("Digite o nome do equipamento: ");
            string nomeEquipamento = Console.ReadLine();
            while (nomeEquipamento.Count() < 6)
            {
                Console.WriteLine("Digite um nome com pelo menos 6 letras: ");
                nomeEquipamento = Console.ReadLine();
            }
            nome.Add(nomeEquipamento);
            Console.WriteLine("Digite o preço do equipamento: ");
            preco.Add(Console.ReadLine());
            Console.WriteLine("Digite o Nº de série do equipamento: ");
            numSerie.Add(Console.ReadLine());
            Console.WriteLine("Digite a data de fabricação do equipamento: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());
            dataFab.Add(dataFabricacao);
            Console.WriteLine("Digite a fabricante do equipamento: ");
            fabricante.Add(Console.ReadLine());
        }
        static void VisualizarEquipamento(ArrayList nome, ArrayList preco, ArrayList numSerie, ArrayList dataFab, ArrayList fabricante)
        {
            Console.WriteLine("id ".PadRight(5) + "| Nome Equipamento".PadRight(30) + "| Preço".PadRight(15) + "| Data Fabrição ".PadRight(30) + "| Fabricante");
            for (int i = 0; i < nome.Count; i++)
            {
                var dataFormatada = string.Format("{0:dd/MM/yyyy}", dataFab[i]);
                Console.WriteLine($"{numSerie[i]} ".PadRight(5) + $"| {nome[i]} ".PadRight(30) + $"| {preco[i]} ".PadRight(15) + $"| {dataFormatada} ".PadRight(30) + $"| {fabricante[i]}");
            }
            Console.ReadLine();
        }
        static void EditarEquipamento(ArrayList nome, ArrayList preco, ArrayList numSerie, ArrayList dataFab, ArrayList fabricante)
        {
            Console.WriteLine("Escolha o equipamento n para editar: ");
            for (int i = 0; i < nome.Count; i++)
            {
                Console.WriteLine($"{i} - {nome[i]}");
            }
            Console.Write(">> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o novo nome do equipamento: ");
            string nomeEquipamento = Console.ReadLine();
            while (nomeEquipamento.Count() < 6)
            {
                Console.WriteLine("Digite um nome com pelo menos 6 letras: ");
                nomeEquipamento = Console.ReadLine();
            }
            nome[n] = (nomeEquipamento);
            Console.WriteLine("Digite o novo preço do equipamento: ");
            preco[n] = (Console.ReadLine());
            Console.WriteLine("Digite o novo Nº de série do equipamento: ");
            numSerie[n] = (Console.ReadLine());
            Console.WriteLine("Digite a nova data de fabricação do equipamento: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());
            dataFab[n] = (dataFabricacao);
            Console.WriteLine("Digite a nova fabricante do equipamento: ");
            fabricante[n] = (Console.ReadLine());
        }
        static void RemoverEquipamento(ArrayList nome, ArrayList preco, ArrayList numSerie, ArrayList dataFab, ArrayList fabricante)
        {
            Console.WriteLine("Escolha o equipamento n para remover: ");
            for (int i = 0; i < nome.Count; i++)
            {
                Console.WriteLine($"{i} - {nome[i]}");
            }
            Console.Write(">> ");
            int n = Convert.ToInt32(Console.ReadLine());

            nome.RemoveAt(n);
            preco.RemoveAt(n);
            numSerie.RemoveAt(n);
            dataFab.RemoveAt(n);
            fabricante.RemoveAt(n);
        }
        static void CadastrarChamado(ArrayList titulo, ArrayList desc, ArrayList equip, ArrayList data, ArrayList nomeEquip)
        {
            Console.WriteLine("Digite o título do chamado: ");
            titulo.Add(Console.ReadLine());
            Console.WriteLine("Digite a descrição do chamado: ");
            desc.Add(Console.ReadLine());
            Console.WriteLine("Escolha um equipamento da lista abaixo: ");
            for (int i = 0; i < nomeEquip.Count; i++)
            {
                Console.WriteLine($"{i} - {nomeEquip[i]}");
            }
            Console.Write(">> ");
            equip.Add(Console.ReadLine());
            Console.WriteLine("Digite a data do chamado: ");
            DateTime dataChamado = Convert.ToDateTime(Console.ReadLine());
            data.Add(dataChamado);

        }
        static void VisualizarChamado(ArrayList titulo, ArrayList desc, ArrayList equip, ArrayList data)
        {
            Console.WriteLine("Título".PadRight(30) + "| Equipamento".PadRight(30) + "| Data de Abertura".PadRight(30) + "| Dias Aberto");
            for (int i = 0; i < desc.Count; i++)
            {
                DateTime dataChamado = (DateTime)data[i];
                double dias = (int)(DateTime.Now - dataChamado).TotalDays;
                var dataFormatada = string.Format("{0:dd/MM/yyyy}", data[i]);
                Console.WriteLine($"{titulo[i]}".PadRight(30) + $"| {equip[i]}".PadRight(30) + $"| {dataFormatada}".PadRight(30) + $"| {dias}");
            }
            Console.ReadLine();
        }
        static void EditarChamado(ArrayList titulo, ArrayList desc, ArrayList equip, ArrayList data, ArrayList nomeEquip)
        {
            Console.WriteLine("Escolha o chamado n para editar: ");
            for (int i = 0; i < titulo.Count; i++)
            {
                Console.WriteLine($"{i} - {titulo[i]}");
            }
            Console.Write(">> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o novo título do chamado: ");
            titulo[n] = (Console.ReadLine());
            Console.WriteLine("Digite a nova descrição do chamado: ");
            desc[n] = (Console.ReadLine());
            Console.WriteLine("Escolha um novo equipamento da lista abaixo: ");
            for (int i = 0; i < nomeEquip.Count; i++)
            {
                Console.WriteLine($"{i} - {nomeEquip[i]}");
            }
            Console.Write(">> ");
            equip[n] = (Console.ReadLine());
            Console.WriteLine("Digite a nova data do chamado: ");
            DateTime dataChamado = Convert.ToDateTime(Console.ReadLine());
            data[n] = (dataChamado);

        }
        static void RemoverChamado(ArrayList titulo, ArrayList desc, ArrayList equip, ArrayList data)
        {
            Console.WriteLine("Escolha o chamado n para remover: ");
            for (int i = 0; i < titulo.Count; i++)
            {
                Console.WriteLine($"{i} - {titulo[i]}");
            }
            Console.Write(">> ");
            int n = Convert.ToInt32(Console.ReadLine());

            titulo.RemoveAt(n);
            desc.RemoveAt(n);
            equip.RemoveAt(n);
            data.RemoveAt(n);
        }
        static void Equipamento(ArrayList listaNomeEquipamentos, ArrayList listaPrecoEquipamentos, ArrayList listaNumeroSerieEquipamentos, ArrayList listaDataFabricacaoEquipamentos, ArrayList listaFabricanteEquipamentos)
        {
            Console.Clear();
            Console.WriteLine("(1) Registrar Equipamento");
            Console.WriteLine("(2) Visualizar Equipamento");
            Console.WriteLine("(3) Editar Equipamento");
            Console.WriteLine("(4) Remover Equipamento");
            Console.WriteLine(">> ");
            string x = Console.ReadLine();
            if (x == "1")
            {
                CadastroEquipamento(listaNomeEquipamentos, listaPrecoEquipamentos, listaNumeroSerieEquipamentos, listaDataFabricacaoEquipamentos, listaFabricanteEquipamentos);
            }
            else if (x == "2")
            {
                VisualizarEquipamento(listaNomeEquipamentos, listaPrecoEquipamentos, listaNumeroSerieEquipamentos, listaDataFabricacaoEquipamentos, listaFabricanteEquipamentos);

            }
            else if (x == "3")
            {
                EditarEquipamento(listaNomeEquipamentos, listaPrecoEquipamentos, listaNumeroSerieEquipamentos, listaDataFabricacaoEquipamentos, listaFabricanteEquipamentos);
            }
            else if (x == "4")
            {
                RemoverEquipamento(listaNomeEquipamentos, listaPrecoEquipamentos, listaNumeroSerieEquipamentos, listaDataFabricacaoEquipamentos, listaFabricanteEquipamentos);
            }
            else
            {
                Menu();
            }
        }
        static void Chamado(ArrayList listaTituloChamados, ArrayList listaDescricaoChamados, ArrayList listaEquipamentoChamados, ArrayList listaDataAberturaChamados, ArrayList listaNomeEquipamentos)
        {
            Console.Clear();
            Console.WriteLine("(1) Registrar Chamado");
            Console.WriteLine("(2) Visualizar Chamado");
            Console.WriteLine("(3) Editar Chamado");
            Console.WriteLine("(4) Remover Chamado");
            Console.WriteLine(">> ");
            string x = Console.ReadLine();
            if (x == "1")
            {
                CadastrarChamado(listaTituloChamados, listaDescricaoChamados, listaEquipamentoChamados, listaDataAberturaChamados, listaNomeEquipamentos);
            }
            else if (x == "2")
            {
                VisualizarChamado(listaTituloChamados, listaDescricaoChamados, listaEquipamentoChamados, listaDataAberturaChamados);
            }
            else if (x == "3")
            {
                EditarChamado(listaTituloChamados, listaDescricaoChamados, listaEquipamentoChamados, listaDataAberturaChamados, listaNomeEquipamentos);
            }
            else if (x == "4")
            {
                RemoverChamado(listaTituloChamados, listaDescricaoChamados, listaEquipamentoChamados, listaDataAberturaChamados);
            }
            else
            {
                Menu();
            }
        }
        static void Menu()
        {
            //Para os equipamentos
            ArrayList listaNomeEquipamentos = new ArrayList();
            ArrayList listaPrecoEquipamentos = new ArrayList();
            ArrayList listaNumeroSerieEquipamentos = new ArrayList();
            ArrayList listaDataFabricacaoEquipamentos = new ArrayList();
            ArrayList listaFabricanteEquipamentos = new ArrayList();


            //Para os chamados
            ArrayList listaTituloChamados = new ArrayList();
            ArrayList listaDescricaoChamados = new ArrayList();
            ArrayList listaEquipamentoChamados = new ArrayList();
            ArrayList listaDataAberturaChamados = new ArrayList();

            string x = null;
            while (x != "3")
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("(1) Equipamentos");
                Console.WriteLine("(2) Chamados");
                Console.WriteLine("(3) Sair");
                Console.Write(">> ");
                x = Console.ReadLine();

                if (x == "1")
                {
                    Equipamento(listaNomeEquipamentos, listaPrecoEquipamentos, listaNumeroSerieEquipamentos, listaDataFabricacaoEquipamentos, listaFabricanteEquipamentos);
                }
                else if (x == "2")
                {
                    Chamado(listaTituloChamados, listaDescricaoChamados, listaEquipamentoChamados, listaDataAberturaChamados, listaNomeEquipamentos);
                }
                else if (x == "3")
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}