namespace Aula_27_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (txtTarefas.Text.Length == 0)
            {
                MessageBox.Show("Favor digitar um item.");
            }
            else
            {
                ListBoxPrincipal.Items.Add($"{dateTime.Value:d} - {txtTarefas.Text}");
            }
         }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(ListBoxPrincipal.SelectedItem == null)
            {
                MessageBox.Show("Não há itens para ser removido.");
            }
            else
            {
                ListBoxPrincipal.Items.Remove(ListBoxPrincipal.SelectedItem);
            }
         }
    }
}
