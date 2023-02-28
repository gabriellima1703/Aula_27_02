namespace Aula_27_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.ListBoxPrincipal = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtTarefas = new System.Windows.Forms.TextBox();
            this.lblTarefas = new System.Windows.Forms.Label();
            this.toolTipData = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTarefas = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipIncluir = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRemover = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipListaDeTarefas = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(138, 40);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(601, 23);
            this.dateTime.TabIndex = 0;
            this.toolTipData.SetToolTip(this.dateTime, "Data da tarefa\r\n");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncluir.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnIncluir.Location = new System.Drawing.Point(803, 148);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(311, 74);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.toolTipIncluir.SetToolTip(this.btnIncluir, "Incluir");
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // ListBoxPrincipal
            // 
            this.ListBoxPrincipal.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxPrincipal.FormattingEnabled = true;
            this.ListBoxPrincipal.ItemHeight = 19;
            this.ListBoxPrincipal.Location = new System.Drawing.Point(71, 148);
            this.ListBoxPrincipal.Name = "ListBoxPrincipal";
            this.ListBoxPrincipal.ScrollAlwaysVisible = true;
            this.ListBoxPrincipal.Size = new System.Drawing.Size(668, 384);
            this.ListBoxPrincipal.TabIndex = 2;
            this.toolTipListaDeTarefas.SetToolTip(this.ListBoxPrincipal, "Lista de Tarefas");
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.Color.Red;
            this.btnRemover.Location = new System.Drawing.Point(803, 468);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(311, 74);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.toolTipRemover.SetToolTip(this.btnRemover, "Remover");
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(71, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 19);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // txtTarefas
            // 
            this.txtTarefas.Location = new System.Drawing.Point(137, 90);
            this.txtTarefas.Name = "txtTarefas";
            this.txtTarefas.Size = new System.Drawing.Size(602, 23);
            this.txtTarefas.TabIndex = 5;
            this.toolTipTarefas.SetToolTip(this.txtTarefas, "Tarefas");
            // 
            // lblTarefas
            // 
            this.lblTarefas.AutoSize = true;
            this.lblTarefas.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTarefas.Location = new System.Drawing.Point(61, 94);
            this.lblTarefas.Name = "lblTarefas";
            this.lblTarefas.Size = new System.Drawing.Size(70, 19);
            this.lblTarefas.TabIndex = 6;
            this.lblTarefas.Text = "Tarefas";
            // 
            // toolTipData
            // 
            this.toolTipData.IsBalloon = true;
            // 
            // toolTipTarefas
            // 
            this.toolTipTarefas.IsBalloon = true;
            // 
            // toolTipIncluir
            // 
            this.toolTipIncluir.IsBalloon = true;
            // 
            // toolTipRemover
            // 
            this.toolTipRemover.IsBalloon = true;
            // 
            // toolTipListaDeTarefas
            // 
            this.toolTipListaDeTarefas.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1173, 589);
            this.Controls.Add(this.lblTarefas);
            this.Controls.Add(this.txtTarefas);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.ListBoxPrincipal);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dateTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTime;
        private Button btnIncluir;
        private ListBox ListBoxPrincipal;
        private Button btnRemover;
        private Label lblData;
        private TextBox txtTarefas;
        private Label lblTarefas;
        private ToolTip toolTipData;
        private ToolTip toolTipTarefas;
        private ToolTip toolTipIncluir;
        private ToolTip toolTipRemover;
        private ToolTip toolTipListaDeTarefas;
    }
}