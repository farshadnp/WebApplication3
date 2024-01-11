namespace WinFormsApp2
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
            btnShow = new Button();
            dgvUser = new DataGridView();
            groupBox1 = new GroupBox();
            dgvEmail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmail).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.None;
            btnShow.Location = new Point(961, 53);
            btnShow.Margin = new Padding(5, 6, 5, 6);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(119, 47);
            btnShow.TabIndex = 1;
            btnShow.Text = "نمایش اطلاعات ";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvUser
            // 
            dgvUser.Anchor = AnchorStyles.None;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(28, 112);
            dgvUser.Margin = new Padding(5, 6, 5, 6);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(1052, 205);
            dgvUser.TabIndex = 2;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvEmail);
            groupBox1.Controls.Add(dgvUser);
            groupBox1.Controls.Add(btnShow);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1175, 505);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات کاربران";
            // 
            // dgvEmail
            // 
            dgvEmail.Anchor = AnchorStyles.None;
            dgvEmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmail.Location = new Point(28, 349);
            dgvEmail.Name = "dgvEmail";
            dgvEmail.RowTemplate.Height = 25;
            dgvEmail.Size = new Size(1052, 126);
            dgvEmail.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 552);
            Controls.Add(groupBox1);
            Font = new Font("IRAN Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow;
        private DataGridView dgvUser;
        private GroupBox groupBox1;
        private DataGridView dgvEmail;
    }
}