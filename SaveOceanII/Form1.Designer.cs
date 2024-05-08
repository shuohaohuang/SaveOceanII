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
            bttEnter = new Button();
            lblName = new Label();
            lblJob = new Label();
            txtName = new TextBox();
            cbbJob = new ComboBox();
            errorProvider = new ErrorProvider(components);
            panel1 = new Panel();
            bttRescueFiles = new Button();
            bttModifi = new Button();
            bttRescue = new Button();
            lblNowEmpId = new Label();
            lblEmpId = new Label();
            lblNowEmpRol = new Label();
            lblEmpJob = new Label();
            lblNowEmpName = new Label();
            lblEmpName = new Label();
            pnlRescueFiles = new Panel();
            bttSearchById = new Button();
            txtSearchById = new TextBox();
            lblIdSearch = new Label();
            dgFiles = new DataGridView();
            pnlRescue = new Panel();
            bttMove = new Button();
            bttHeal = new Button();
            gbFile = new GroupBox();
            lblRescueId = new Label();
            lblLocView = new Label();
            lblResIdView = new Label();
            lblLocation = new Label();
            LblDate = new Label();
            lbllvlView = new Label();
            lblDateView = new Label();
            lblLevel = new Label();
            lblEspeci = new Label();
            lblEspecieView = new Label();
            pnlAnimlFiles = new Panel();
            gbAfegir = new GroupBox();
            bttAddanimal = new Button();
            cbbFamily = new ComboBox();
            txtSpecie = new TextBox();
            lblFamily = new Label();
            lblSpecie = new Label();
            dgAnimals = new DataGridView();
            pnlLogin.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel1.SuspendLayout();
            pnlRescueFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFiles).BeginInit();
            pnlRescue.SuspendLayout();
            gbFile.SuspendLayout();
            pnlAnimlFiles.SuspendLayout();
            gbAfegir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAnimals).BeginInit();
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
            bttPlay.Click += BttPlay_Click;
            // 
            // bttExit
            // 
            bttExit.Location = new Point(85, 99);
            bttExit.Name = "bttExit";
            bttExit.Size = new Size(75, 23);
            bttExit.TabIndex = 1;
            bttExit.Text = "Sortir";
            bttExit.UseVisualStyleBackColor = true;
            bttExit.Click += BttExit_Click;
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
            // bttEnter
            // 
            bttEnter.Location = new Point(156, 159);
            bttEnter.Name = "bttEnter";
            bttEnter.Size = new Size(75, 23);
            bttEnter.TabIndex = 4;
            bttEnter.Text = "Confirmar";
            bttEnter.UseVisualStyleBackColor = true;
            bttEnter.Click += BttEnter_Click_1;
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
            lblJob.Location = new Point(257, 60);
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
            cbbJob.Location = new Point(257, 78);
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
            panel1.Controls.Add(pnlRescue);
            panel1.Controls.Add(bttRescueFiles);
            panel1.Controls.Add(bttModifi);
            panel1.Controls.Add(bttRescue);
            panel1.Controls.Add(lblNowEmpId);
            panel1.Controls.Add(lblEmpId);
            panel1.Controls.Add(lblNowEmpRol);
            panel1.Controls.Add(lblEmpJob);
            panel1.Controls.Add(lblNowEmpName);
            panel1.Controls.Add(lblEmpName);
            panel1.Controls.Add(pnlRescueFiles);
            panel1.Controls.Add(pnlAnimlFiles);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 390);
            panel1.TabIndex = 7;
            // 
            // bttRescueFiles
            // 
            bttRescueFiles.Location = new Point(3, 287);
            bttRescueFiles.Name = "bttRescueFiles";
            bttRescueFiles.Size = new Size(75, 45);
            bttRescueFiles.TabIndex = 9;
            bttRescueFiles.Text = "Fitxes Rescat";
            bttRescueFiles.UseVisualStyleBackColor = true;
            bttRescueFiles.Click += Button1_Click;
            // 
            // bttModifi
            // 
            bttModifi.Location = new Point(3, 224);
            bttModifi.Name = "bttModifi";
            bttModifi.Size = new Size(75, 57);
            bttModifi.TabIndex = 7;
            bttModifi.Text = "Afegir\r\nModificar\r\nAnimals";
            bttModifi.UseVisualStyleBackColor = true;
            bttModifi.Click += BttModifi_Click;
            // 
            // bttRescue
            // 
            bttRescue.Location = new Point(3, 195);
            bttRescue.Name = "bttRescue";
            bttRescue.Size = new Size(75, 23);
            bttRescue.TabIndex = 6;
            bttRescue.Text = "Rescatar";
            bttRescue.UseVisualStyleBackColor = true;
            bttRescue.Click += BttRescue_Click;
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
            // pnlRescueFiles
            // 
            pnlRescueFiles.Controls.Add(bttSearchById);
            pnlRescueFiles.Controls.Add(txtSearchById);
            pnlRescueFiles.Controls.Add(lblIdSearch);
            pnlRescueFiles.Controls.Add(dgFiles);
            pnlRescueFiles.Location = new Point(146, 6);
            pnlRescueFiles.Name = "pnlRescueFiles";
            pnlRescueFiles.Size = new Size(611, 353);
            pnlRescueFiles.TabIndex = 11;
            // 
            // bttSearchById
            // 
            bttSearchById.Location = new Point(253, 29);
            bttSearchById.Name = "bttSearchById";
            bttSearchById.Size = new Size(75, 23);
            bttSearchById.TabIndex = 3;
            bttSearchById.Text = "buscar";
            bttSearchById.UseVisualStyleBackColor = true;
            bttSearchById.Click += bttSearchById_Click;
            // 
            // txtSearchById
            // 
            txtSearchById.Location = new Point(113, 29);
            txtSearchById.Name = "txtSearchById";
            txtSearchById.Size = new Size(100, 23);
            txtSearchById.TabIndex = 2;
            txtSearchById.TextChanged += txtSearchById_TextChanged;
            // 
            // lblIdSearch
            // 
            lblIdSearch.AutoSize = true;
            lblIdSearch.Location = new Point(23, 32);
            lblIdSearch.Name = "lblIdSearch";
            lblIdSearch.Size = new Size(84, 15);
            lblIdSearch.TabIndex = 1;
            lblIdSearch.Text = "Buscar per Id : ";
            // 
            // dgFiles
            // 
            dgFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFiles.Location = new Point(12, 72);
            dgFiles.Name = "dgFiles";
            dgFiles.Size = new Size(579, 272);
            dgFiles.TabIndex = 0;
            // 
            // pnlRescue
            // 
            pnlRescue.Controls.Add(bttMove);
            pnlRescue.Controls.Add(bttHeal);
            pnlRescue.Controls.Add(gbFile);
            pnlRescue.Location = new Point(102, 30);
            pnlRescue.Name = "pnlRescue";
            pnlRescue.Size = new Size(614, 359);
            pnlRescue.TabIndex = 8;
            // 
            // bttMove
            // 
            bttMove.Location = new Point(370, 249);
            bttMove.Name = "bttMove";
            bttMove.Size = new Size(75, 42);
            bttMove.TabIndex = 12;
            bttMove.Text = "Traslladar";
            bttMove.UseVisualStyleBackColor = true;
            bttMove.Click += bttMove_Click;
            // 
            // bttHeal
            // 
            bttHeal.Location = new Point(116, 259);
            bttHeal.Name = "bttHeal";
            bttHeal.Size = new Size(75, 23);
            bttHeal.TabIndex = 11;
            bttHeal.Text = "Curar";
            bttHeal.UseVisualStyleBackColor = true;
            bttHeal.Click += bttHeal_Click;
            // 
            // gbFile
            // 
            gbFile.Controls.Add(lblRescueId);
            gbFile.Controls.Add(lblLocView);
            gbFile.Controls.Add(lblResIdView);
            gbFile.Controls.Add(lblLocation);
            gbFile.Controls.Add(LblDate);
            gbFile.Controls.Add(lbllvlView);
            gbFile.Controls.Add(lblDateView);
            gbFile.Controls.Add(lblLevel);
            gbFile.Controls.Add(lblEspeci);
            gbFile.Controls.Add(lblEspecieView);
            gbFile.Location = new Point(24, 26);
            gbFile.Name = "gbFile";
            gbFile.Size = new Size(561, 196);
            gbFile.TabIndex = 10;
            gbFile.TabStop = false;
            gbFile.Text = "Fitxa de rescat";
            // 
            // lblRescueId
            // 
            lblRescueId.AutoSize = true;
            lblRescueId.Location = new Point(43, 38);
            lblRescueId.Name = "lblRescueId";
            lblRescueId.Size = new Size(61, 15);
            lblRescueId.TabIndex = 0;
            lblRescueId.Text = "Nº rescat :";
            // 
            // lblLocView
            // 
            lblLocView.AutoSize = true;
            lblLocView.Location = new Point(199, 137);
            lblLocView.Name = "lblLocView";
            lblLocView.Size = new Size(38, 15);
            lblLocView.TabIndex = 9;
            lblLocView.Text = "label7";
            // 
            // lblResIdView
            // 
            lblResIdView.AutoSize = true;
            lblResIdView.Location = new Point(43, 60);
            lblResIdView.Name = "lblResIdView";
            lblResIdView.Size = new Size(38, 15);
            lblResIdView.TabIndex = 1;
            lblResIdView.Text = "label2";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(199, 115);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(75, 15);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Localització :";
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Location = new Point(199, 38);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(37, 15);
            LblDate.TabIndex = 2;
            LblDate.Text = "Data :";
            // 
            // lbllvlView
            // 
            lbllvlView.AutoSize = true;
            lbllvlView.Location = new Point(43, 137);
            lbllvlView.Name = "lbllvlView";
            lbllvlView.Size = new Size(38, 15);
            lbllvlView.TabIndex = 7;
            lbllvlView.Text = "label9";
            // 
            // lblDateView
            // 
            lblDateView.AutoSize = true;
            lblDateView.Location = new Point(199, 60);
            lblDateView.Name = "lblDateView";
            lblDateView.Size = new Size(38, 15);
            lblDateView.TabIndex = 3;
            lblDateView.Text = "label3";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(43, 115);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(79, 15);
            lblLevel.TabIndex = 6;
            lblLevel.Text = "Grau afecció :";
            // 
            // lblEspeci
            // 
            lblEspeci.AutoSize = true;
            lblEspeci.Location = new Point(356, 38);
            lblEspeci.Name = "lblEspeci";
            lblEspeci.Size = new Size(52, 15);
            lblEspeci.TabIndex = 4;
            lblEspeci.Text = "Espècie :";
            // 
            // lblEspecieView
            // 
            lblEspecieView.AutoSize = true;
            lblEspecieView.Location = new Point(356, 60);
            lblEspecieView.Name = "lblEspecieView";
            lblEspecieView.Size = new Size(38, 15);
            lblEspecieView.TabIndex = 5;
            lblEspecieView.Text = "label5";
            // 
            // pnlAnimlFiles
            // 
            pnlAnimlFiles.Controls.Add(gbAfegir);
            pnlAnimlFiles.Controls.Add(dgAnimals);
            pnlAnimlFiles.Location = new Point(126, 17);
            pnlAnimlFiles.Name = "pnlAnimlFiles";
            pnlAnimlFiles.Size = new Size(611, 353);
            pnlAnimlFiles.TabIndex = 10;
            // 
            // gbAfegir
            // 
            gbAfegir.Controls.Add(bttAddanimal);
            gbAfegir.Controls.Add(cbbFamily);
            gbAfegir.Controls.Add(txtSpecie);
            gbAfegir.Controls.Add(lblFamily);
            gbAfegir.Controls.Add(lblSpecie);
            gbAfegir.Location = new Point(16, 242);
            gbAfegir.Name = "gbAfegir";
            gbAfegir.Size = new Size(578, 100);
            gbAfegir.TabIndex = 1;
            gbAfegir.TabStop = false;
            gbAfegir.Text = "Afegir Animal";
            // 
            // bttAddanimal
            // 
            bttAddanimal.Location = new Point(183, 68);
            bttAddanimal.Name = "bttAddanimal";
            bttAddanimal.Size = new Size(75, 23);
            bttAddanimal.TabIndex = 4;
            bttAddanimal.Text = "Afegir";
            bttAddanimal.UseVisualStyleBackColor = true;
            bttAddanimal.Click += bttAddanimal_Click;
            // 
            // cbbFamily
            // 
            cbbFamily.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFamily.FormattingEnabled = true;
            cbbFamily.Location = new Point(306, 28);
            cbbFamily.Name = "cbbFamily";
            cbbFamily.Size = new Size(121, 23);
            cbbFamily.TabIndex = 3;
            // 
            // txtSpecie
            // 
            txtSpecie.Location = new Point(76, 27);
            txtSpecie.Name = "txtSpecie";
            txtSpecie.Size = new Size(100, 23);
            txtSpecie.TabIndex = 2;
            // 
            // lblFamily
            // 
            lblFamily.AutoSize = true;
            lblFamily.Location = new Point(237, 27);
            lblFamily.Name = "lblFamily";
            lblFamily.Size = new Size(49, 15);
            lblFamily.TabIndex = 1;
            lblFamily.Text = "Familia :";
            // 
            // lblSpecie
            // 
            lblSpecie.AutoSize = true;
            lblSpecie.Location = new Point(15, 27);
            lblSpecie.Name = "lblSpecie";
            lblSpecie.Size = new Size(52, 15);
            lblSpecie.TabIndex = 0;
            lblSpecie.Text = "Especie :";
            // 
            // dgAnimals
            // 
            dgAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAnimals.Location = new Point(15, 13);
            dgAnimals.Name = "dgAnimals";
            dgAnimals.Size = new Size(579, 222);
            dgAnimals.TabIndex = 0;
            dgAnimals.CellEndEdit += dgAnimals_CellEndEdit;
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
            pnlRescueFiles.ResumeLayout(false);
            pnlRescueFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgFiles).EndInit();
            pnlRescue.ResumeLayout(false);
            gbFile.ResumeLayout(false);
            gbFile.PerformLayout();
            pnlAnimlFiles.ResumeLayout(false);
            gbAfegir.ResumeLayout(false);
            gbAfegir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAnimals).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button bttPlay;
        private Button bttExit;
        private Panel pnlLogin;
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
        private Panel pnlRescue;
        private Label lblRescueId;
        private Label lblLocView;
        private Label lblLocation;
        private Label lbllvlView;
        private Label lblLevel;
        private Label lblEspecieView;
        private Label lblEspeci;
        private Label lblDateView;
        private Label LblDate;
        private Label lblResIdView;
        private Button bttMove;
        private Button bttHeal;
        private GroupBox gbFile;
        private Panel pnlAnimlFiles;
        private DataGridView dgAnimals;
        private Button bttRescueFiles;
        private Panel pnlRescueFiles;
        private DataGridView dgFiles;
        private GroupBox groupBox1;
        private Button bttEnter;
        private Label lblName;
        private Label lblJob;
        private TextBox txtName;
        private ComboBox cbbJob;
        private Label lblIdSearch;
        private Button bttSearchById;
        private TextBox txtSearchById;
        private GroupBox gbAfegir;
        private ComboBox cbbFamily;
        private TextBox txtSpecie;
        private Label lblFamily;
        private Label lblSpecie;
        private Button bttAddanimal;
    }
}
