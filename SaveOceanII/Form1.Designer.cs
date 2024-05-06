namespace SaveOceanII
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
            components = new System.ComponentModel.Container();
            bttPlay = new Button();
            bttExit = new Button();
            pnlLogin = new Panel();
            groupBox1 = new GroupBox();
            lblId = new Label();
            txtId = new TextBox();
            bttEnter = new Button();
            lblName = new Label();
            lblJob = new Label();
            txtName = new TextBox();
            cbbJob = new ComboBox();
            errorProvider = new ErrorProvider(components);
            panel1 = new Panel();
            bttModifi = new Button();
            bttRescue = new Button();
            lblNowEmpId = new Label();
            lblEmpId = new Label();
            lblNowEmpRol = new Label();
            lblEmpJob = new Label();
            lblNowEmpName = new Label();
            lblEmpName = new Label();
            pnlLogin.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bttPlay
            // 
            bttPlay.Location = new Point(85, 70);
            bttPlay.Name = "bttPlay";
            bttPlay.Size = new Size(75, 23);
            bttPlay.TabIndex = 0;
            bttPlay.Text = "Jugar";
            bttPlay.UseVisualStyleBackColor = true;
            bttPlay.Click += bttPlay_Click;
            // 
            // bttExit
            // 
            bttExit.Location = new Point(85, 99);
            bttExit.Name = "bttExit";
            bttExit.Size = new Size(75, 23);
            bttExit.TabIndex = 1;
            bttExit.Text = "Sortir";
            bttExit.UseVisualStyleBackColor = true;
            bttExit.Click += bttExit_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(groupBox1);
            pnlLogin.Location = new Point(114, 99);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(470, 303);
            pnlLogin.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(bttEnter);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblJob);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(cbbJob);
            groupBox1.Location = new Point(40, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 242);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fitxa De Personal";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(275, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(76, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id (Opcional)";
            // 
            // txtId
            // 
            txtId.Location = new Point(275, 78);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // bttEnter
            // 
            bttEnter.Location = new Point(156, 159);
            bttEnter.Name = "bttEnter";
            bttEnter.Size = new Size(75, 23);
            bttEnter.TabIndex = 4;
            bttEnter.Text = "Confirmar";
            bttEnter.UseVisualStyleBackColor = true;
            bttEnter.Click += bttEnter_Click_1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(18, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(33, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nom";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(142, 60);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(31, 15);
            lblJob.TabIndex = 2;
            lblJob.Text = "Ofici";
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // cbbJob
            // 
            cbbJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbJob.FormattingEnabled = true;
            cbbJob.Location = new Point(142, 78);
            cbbJob.Name = "cbbJob";
            cbbJob.Size = new Size(121, 23);
            cbbJob.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(bttModifi);
            panel1.Controls.Add(bttRescue);
            panel1.Controls.Add(lblNowEmpId);
            panel1.Controls.Add(lblEmpId);
            panel1.Controls.Add(lblNowEmpRol);
            panel1.Controls.Add(lblEmpJob);
            panel1.Controls.Add(lblNowEmpName);
            panel1.Controls.Add(lblEmpName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 390);
            panel1.TabIndex = 7;
            // 
            // bttModifi
            // 
            bttModifi.Location = new Point(3, 224);
            bttModifi.Name = "bttModifi";
            bttModifi.Size = new Size(75, 42);
            bttModifi.TabIndex = 7;
            bttModifi.Text = "Afegir\r\nModificar";
            bttModifi.UseVisualStyleBackColor = true;
            // 
            // bttRescue
            // 
            bttRescue.Location = new Point(3, 195);
            bttRescue.Name = "bttRescue";
            bttRescue.Size = new Size(75, 23);
            bttRescue.TabIndex = 6;
            bttRescue.Text = "Rescatar";
            bttRescue.UseVisualStyleBackColor = true;
            // 
            // lblNowEmpId
            // 
            lblNowEmpId.AutoSize = true;
            lblNowEmpId.Location = new Point(20, 143);
            lblNowEmpId.Name = "lblNowEmpId";
            lblNowEmpId.Size = new Size(38, 15);
            lblNowEmpId.TabIndex = 5;
            lblNowEmpId.Text = "label4";
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(3, 117);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(23, 15);
            lblEmpId.TabIndex = 4;
            lblEmpId.Text = "Id: ";
            // 
            // lblNowEmpRol
            // 
            lblNowEmpRol.AutoSize = true;
            lblNowEmpRol.Location = new Point(20, 92);
            lblNowEmpRol.Name = "lblNowEmpRol";
            lblNowEmpRol.Size = new Size(38, 15);
            lblNowEmpRol.TabIndex = 3;
            lblNowEmpRol.Text = "label2";
            // 
            // lblEmpJob
            // 
            lblEmpJob.AutoSize = true;
            lblEmpJob.Location = new Point(3, 66);
            lblEmpJob.Name = "lblEmpJob";
            lblEmpJob.Size = new Size(30, 15);
            lblEmpJob.TabIndex = 2;
            lblEmpJob.Text = "Rol :";
            // 
            // lblNowEmpName
            // 
            lblNowEmpName.AutoSize = true;
            lblNowEmpName.Location = new Point(20, 43);
            lblNowEmpName.Name = "lblNowEmpName";
            lblNowEmpName.Size = new Size(38, 15);
            lblNowEmpName.TabIndex = 1;
            lblNowEmpName.Text = "label1";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(3, 17);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(58, 15);
            lblEmpName.TabIndex = 0;
            lblEmpName.Text = "Empleat : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 756);
            Controls.Add(panel1);
            Controls.Add(pnlLogin);
            Controls.Add(bttExit);
            Controls.Add(bttPlay);
            Name = "Form1";
            Text = "Form1";
            pnlLogin.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button bttPlay;
        private Button bttExit;
        private Panel pnlLogin;
        private GroupBox groupBox1;
        private Label lblId;
        private TextBox txtId;
        private Button bttEnter;
        private Label lblName;
        private Label lblJob;
        private TextBox txtName;
        private ComboBox cbbJob;
        private ErrorProvider errorProvider;
        private Panel panel1;
        private Button bttModifi;
        private Button bttRescue;
        private Label lblNowEmpId;
        private Label lblEmpId;
        private Label lblNowEmpRol;
        private Label lblEmpJob;
        private Label lblNowEmpName;
        private Label lblEmpName;
    }
}
