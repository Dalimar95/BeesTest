namespace Bees
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beeHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beeCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DamageBees = new System.Windows.Forms.Button();
            this.btn_CreateHive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.beeType,
            this.beeHealth,
            this.beeCondition});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // beeType
            // 
            this.beeType.HeaderText = "Type";
            this.beeType.Name = "beeType";
            this.beeType.ReadOnly = true;
            // 
            // beeHealth
            // 
            this.beeHealth.HeaderText = "Health";
            this.beeHealth.Name = "beeHealth";
            this.beeHealth.ReadOnly = true;
            // 
            // beeCondition
            // 
            this.beeCondition.HeaderText = "Condition";
            this.beeCondition.Name = "beeCondition";
            this.beeCondition.ReadOnly = true;
            // 
            // btn_DamageBees
            // 
            this.btn_DamageBees.Location = new System.Drawing.Point(150, 397);
            this.btn_DamageBees.Name = "btn_DamageBees";
            this.btn_DamageBees.Size = new System.Drawing.Size(140, 41);
            this.btn_DamageBees.TabIndex = 1;
            this.btn_DamageBees.Text = "Damage Bees";
            this.btn_DamageBees.UseVisualStyleBackColor = true;
            this.btn_DamageBees.Click += new System.EventHandler(this.Btn_DamageBees_Click);
            // 
            // btn_CreateHive
            // 
            this.btn_CreateHive.Location = new System.Drawing.Point(12, 397);
            this.btn_CreateHive.Name = "btn_CreateHive";
            this.btn_CreateHive.Size = new System.Drawing.Size(123, 41);
            this.btn_CreateHive.TabIndex = 2;
            this.btn_CreateHive.Text = "Create Hive";
            this.btn_CreateHive.UseVisualStyleBackColor = true;
            this.btn_CreateHive.Click += new System.EventHandler(this.Btn_CreateHive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateHive);
            this.Controls.Add(this.btn_DamageBees);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DamageBees;
        private System.Windows.Forms.Button btn_CreateHive;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn beeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn beeHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn beeCondition;
    }
}

