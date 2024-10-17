using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {
        int[] vet = new int[500]; // vetor interno para a animação

        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(Pens.Blue, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this, 
                "Prática 5 2022/2 - Métodos de Ordenação\n\n" +
                "Desenvolvido por:\n72200545 - \n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Apenas para fins didáticos.", 
                "Sobre o trabalho...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
            if (bgw.IsBusy != true) {
                bgw.RunWorkerAsync(a);
            }
            else {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Prática 5 2022/2 - Métodos de Ordenação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Prática 5 2022/2 - Métodos de Ordenação",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            
            ShowDialog();

            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000); // TODO (preenchimento inicial deverá ser escolhido pelo usuário)
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: TODO" +
                  "\nOrdenação inicial: TODO" +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: TODO" +
                  "\nNº de trocas: TODO",
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void FormOrdenacao_Load(object sender, EventArgs e)
        {

        }


        //BOLHA
        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }
        private void crescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        private void decrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        //SELEÇÃO
        private void aleatorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Selecao(vet, panel));
        }
        private void crescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Selecao(vet, panel));
        }

        private void decrescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Selecao(vet, panel));
        }

        //INSERÇÃO
        private void aleatorioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Insercao(vet, panel));
        }
        private void crescenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Insercao(vet, panel));
        }
        private void decrescenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.Insercao(vet, panel));
        }

        //SHELLSORT
        private void aleatorioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.ShellSort(vet, panel));
        }

        private void crescenteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.ShellSort(vet, panel));
        }

        private void decrescenteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.ShellSort(vet, panel));
        }

        //QUICKSORT
        private void aleatorioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int dir = 499;
            int esq = 0;
            Preenchimento.Aleatorio(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.QuickSort(vet,esq, dir, panel));
        }

        private void crescenteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int dir = 499;
            int esq = 0;
            Preenchimento.Crescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.QuickSort(vet, esq, dir, panel));
        }

        private void decrescenteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int dir = 499;
            int esq = 0;
            Preenchimento.Decrescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.QuickSort(vet, esq, dir, panel));
        }

        //HEAPSORT
        private void aleatorioToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.HeapSort(vet, panel));
        }

        private void crescenteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.HeapSort(vet, panel));
        }

        private void decrescenteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 300);
            iniciaAnimacao(() => OrdenacaoGrafica.HeapSort(vet, panel));
        }

        private void algoritmoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




    }
}
