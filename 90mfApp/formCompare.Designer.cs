namespace _90mfApp
{
    partial class formCompare
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
            this.components = new System.ComponentModel.Container();
            this.comboP1 = new System.Windows.Forms.ComboBox();
            this.comboP2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnimport1 = new System.Windows.Forms.Button();
            this.btnimport2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._90MFAppDataSet = new _90mfApp._90MFAppDataSet();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new _90mfApp._90MFAppDataSetTableAdapters.PlayerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._90MFAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboP1
            // 
            this.comboP1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboP1.FormattingEnabled = true;
            this.comboP1.Location = new System.Drawing.Point(12, 12);
            this.comboP1.Name = "comboP1";
            this.comboP1.Size = new System.Drawing.Size(411, 31);
            this.comboP1.TabIndex = 0;
            this.comboP1.Text = "Player 1";
            // 
            // comboP2
            // 
            this.comboP2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboP2.FormattingEnabled = true;
            this.comboP2.Location = new System.Drawing.Point(800, 12);
            this.comboP2.Name = "comboP2";
            this.comboP2.Size = new System.Drawing.Size(422, 31);
            this.comboP2.TabIndex = 1;
            this.comboP2.Text = "Player 2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 461);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1210, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnimport1
            // 
            this.btnimport1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport1.Location = new System.Drawing.Point(12, 49);
            this.btnimport1.Name = "btnimport1";
            this.btnimport1.Size = new System.Drawing.Size(169, 31);
            this.btnimport1.TabIndex = 3;
            this.btnimport1.Text = "Import Player 1";
            this.btnimport1.UseVisualStyleBackColor = true;
            this.btnimport1.Click += new System.EventHandler(this.btnimport1_Click);
            // 
            // btnimport2
            // 
            this.btnimport2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport2.Location = new System.Drawing.Point(1053, 49);
            this.btnimport2.Name = "btnimport2";
            this.btnimport2.Size = new System.Drawing.Size(169, 31);
            this.btnimport2.TabIndex = 4;
            this.btnimport2.Text = "Import Player 2";
            this.btnimport2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _90MFAppDataSet
            // 
            this._90MFAppDataSet.DataSetName = "_90MFAppDataSet";
            this._90MFAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this._90MFAppDataSet;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 257);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1207, 201);
            this.dataGridView2.TabIndex = 1;
            // 
            // formCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.btnimport2);
            this.Controls.Add(this.btnimport1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboP2);
            this.Controls.Add(this.comboP1);
            this.Name = "formCompare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "90MF App - Player Comparison";
            this.Load += new System.EventHandler(this.formCompare_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._90MFAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboP1;
        private System.Windows.Forms.ComboBox comboP2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnimport1;
        private System.Windows.Forms.Button btnimport2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _90MFAppDataSet _90MFAppDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private _90MFAppDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}