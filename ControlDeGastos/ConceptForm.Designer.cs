namespace ControlDeGastos
{
    partial class ConceptForm
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
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.dgvConcepts = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.lblCreatedDate);
            this.gbPanel.Controls.Add(this.chkIsEnabled);
            this.gbPanel.Controls.Add(this.label3);
            this.gbPanel.Controls.Add(this.txtDescription);
            this.gbPanel.Controls.Add(this.label2);
            this.gbPanel.Controls.Add(this.txtName);
            this.gbPanel.Controls.Add(this.label1);
            this.gbPanel.Controls.Add(this.txtID);
            this.gbPanel.Enabled = false;
            this.gbPanel.Location = new System.Drawing.Point(0, 0);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(442, 311);
            this.gbPanel.TabIndex = 0;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = "GESTION DE CONCEPTOS";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(306, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 26);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 128);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(408, 141);
            this.txtDescription.TabIndex = 4;
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(23, 275);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(132, 20);
            this.chkIsEnabled.TabIndex = 6;
            this.chkIsEnabled.Text = "Visible al Publico";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(373, 284);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(11, 16);
            this.lblCreatedDate.TabIndex = 7;
            this.lblCreatedDate.Text = "-";
            this.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvConcepts
            // 
            this.dgvConcepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcepts.Location = new System.Drawing.Point(448, 39);
            this.dgvConcepts.Name = "dgvConcepts";
            this.dgvConcepts.RowHeadersWidth = 51;
            this.dgvConcepts.RowTemplate.Height = 24;
            this.dgvConcepts.Size = new System.Drawing.Size(820, 343);
            this.dgvConcepts.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(325, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(95, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ConceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1280, 399);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvConcepts);
            this.Controls.Add(this.gbPanel);
            this.MaximizeBox = false;
            this.Name = "ConceptForm";
            this.Text = "ConceptForm";
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvConcepts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
    }
}