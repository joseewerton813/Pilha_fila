namespace Pilha_fila
{
    public partial class Form1 : Form
    {
        Queue<string> fila = new Queue<string>();
        Stack<string> pilha = new Stack<string>();
        public Form1()
        {
            InitializeComponent();


        }


        private void Adicionarpilha_Click(object sender, EventArgs e)
        {
            pilha.Push(textPilha.Text);
            AtualizarPilha();
        }

        private void Removerpilha_Click(object sender, EventArgs e)
        {
            if (pilha.Count > 0)
                pilha.Pop();

            AtualizarPilha();
        }

        private void AdicionarFila_Click(object sender, EventArgs e)
        {
            fila.Enqueue(textFila.Text);
            AtualizarFila();
        }

        private void RemoverFila_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
                fila.Dequeue();

            AtualizarFila();
        }

        private void AtualizarPilha()
        {
            Pilha.Items.Clear();
            foreach (string item in pilha)
            {
                Pilha.Items.Add(item);
            }
        }

        void AtualizarFila()
        {
            Fila.Items.Clear();
            foreach (var item in fila)
                Fila.Items.Add(item);
        }
    }
}
