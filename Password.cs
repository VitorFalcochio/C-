namespace MinhaPrimeiraTela;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // 1. Configurações da Janela
        this.Text = "🔐 Gerador de Senhas Blindadas";
        this.Size = new Size(400, 350);
        this.StartPosition = FormStartPosition.CenterScreen; // Abre bem no meio do monitor!

        // 2. Campo para o Tamanho da Senha
        Label lblTamanho = new Label();
        lblTamanho.Text = "Tamanho da senha (ex: 12):";
        lblTamanho.Location = new Point(50, 30);
        lblTamanho.AutoSize = true;

        TextBox txtTamanho = new TextBox();
        txtTamanho.Location = new Point(50, 55);
        txtTamanho.Size = new Size(100, 30);
        txtTamanho.Text = "12"; // Já deixamos o número 12 preenchido por padrão

        // 3. O Botão de Gerar
        Button btnGerar = new Button();
        btnGerar.Text = "Gerar Senha";
        btnGerar.Location = new Point(50, 100);
        btnGerar.Size = new Size(150, 40);
        btnGerar.BackColor = Color.LightBlue; // Dando uma corzinha pra ficar estiloso

        // 4. Campo para mostrar a Senha Gerada
        Label lblResultado = new Label();
        lblResultado.Text = "Sua nova senha:";
        lblResultado.Location = new Point(50, 160);
        lblResultado.AutoSize = true;

        TextBox txtSenha = new TextBox();
        txtSenha.Location = new Point(50, 185);
        txtSenha.Size = new Size(280, 30);
        txtSenha.ReadOnly = true; // Impede que o usuário apague a senha sem querer

        Button btnSalvar = new Button();
        btnSalvar.Text = "Salvar Senha";
        btnSalvar.Location = new Point(210, 100); // Colocando ele mais para a direita
        btnSalvar.Size = new Size(120, 40);
        btnSalvar.BackColor = Color.LightGreen; // Uma corzinha pra diferenciar


        // 5. A LÓGICA (O cérebro do botão)
        btnGerar.Click += (sender, e) =>
        {
            // Tenta converter o que foi digitado para número. Se der erro (ex: digitar "ABC"), ele avisa!
            if (int.TryParse(txtTamanho.Text, out int tamanho))
            {
                string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";
                string senhaGerada = "";
                Random random = new Random();

                for (int i = 0; i < tamanho; i++)
                {
                    senhaGerada += caracteres[random.Next(caracteres.Length)];
                }

                // Joga a senha pronta na caixinha de baixo!
                txtSenha.Text = senhaGerada;
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido para o tamanho!", "Erro");
            }
        };
        btnSalvar.Click += (sender, e) =>
{
    // Primeiro, checamos se tem alguma senha gerada ali para não dar erro
   if (!string.IsNullOrEmpty(txtSenha.Text))
   {
        // O comando que copia pro seu Windows!
       Clipboard.SetText(txtSenha.Text);
       MessageBox.Show("Senha copiada! Agora é só dar Ctrl+V onde você quiser.", "Sucesso!");
   }
   else
   {
       MessageBox.Show("Gere uma senha primeiro!", "Aviso");
   }
};
        // 6. Colando tudo na janela
        this.Controls.Add(lblTamanho);
        this.Controls.Add(txtTamanho);
        this.Controls.Add(btnGerar);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtSenha);
        this.Controls.Add(btnSalvar);
        this.Controls.Add(btnSalvar);
    }
}
