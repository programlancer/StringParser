namespace StringParser
{
    partial class FormMain
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelFields = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSchemas = new System.Windows.Forms.ComboBox();
            this.stringParserEntitiesSchemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonBuldSource = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stringParserEntitiesSchemasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.AllowDrop = true;
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.Location = new System.Drawing.Point(12, 54);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(1034, 58);
            this.textBoxSource.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxSource, "Copy here a data string");
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelFields.AutoScroll = true;
            this.tableLayoutPanelFields.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelFields.ColumnCount = 6;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(12, 131);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 2;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(1034, 400);
            this.tableLayoutPanelFields.TabIndex = 1;
            // 
            // comboBoxSchemas
            // 
            this.comboBoxSchemas.DisplayMember = "Schemes";
            this.comboBoxSchemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSchemas.FormattingEnabled = true;
            this.comboBoxSchemas.Location = new System.Drawing.Point(12, 17);
            this.comboBoxSchemas.Name = "comboBoxSchemas";
            this.comboBoxSchemas.Size = new System.Drawing.Size(329, 21);
            this.comboBoxSchemas.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxSchemas, "Select a Schema");
            this.comboBoxSchemas.ValueMember = "Schemes";
            // 
            // stringParserEntitiesSchemasBindingSource
            // 
            this.stringParserEntitiesSchemasBindingSource.DataSource = typeof(StringParser.StringParserEntitiesSchemas);
            // 
            // buttonBuldSource
            // 
            this.buttonBuldSource.Location = new System.Drawing.Point(915, 17);
            this.buttonBuldSource.Name = "buttonBuldSource";
            this.buttonBuldSource.Size = new System.Drawing.Size(128, 23);
            this.buttonBuldSource.TabIndex = 3;
            this.buttonBuldSource.Text = "Buld Source String";
            this.buttonBuldSource.UseVisualStyleBackColor = true;
            this.buttonBuldSource.Click += new System.EventHandler(this.buttonBuldSource_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(750, 17);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(86, 23);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(585, 17);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(86, 23);
            this.buttonPaste.TabIndex = 5;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(420, 17);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 543);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonBuldSource);
            this.Controls.Add(this.comboBoxSchemas);
            this.Controls.Add(this.tableLayoutPanelFields);
            this.Controls.Add(this.textBoxSource);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "String Parser";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stringParserEntitiesSchemasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFields;
        private System.Windows.Forms.ComboBox comboBoxSchemas;
        private System.Windows.Forms.BindingSource stringParserEntitiesSchemasBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonBuldSource;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonClear;
    }
}

