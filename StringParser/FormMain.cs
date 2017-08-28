using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringParser
{
    public partial class FormMain : Form
    {
        private StringParserEntitiesSchemas dbContext;

        private SchemaItem[] schema;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dbContext = new StringParserEntitiesSchemas();

            var schemas = dbContext.Schemas.ToList();

            foreach (var item in schemas)
            {
                this.comboBoxSchemas.Items.Add(item);
            }

            comboBoxSchemas.SelectedIndex = 0;
            comboBoxSchemas.DisplayMember = "Name";
            comboBoxSchemas.ValueMember = "Id";
            comboBoxSchemas.SelectedIndexChanged += new System.EventHandler(this.comboBoxSchemes_SelectedIndexChanged);

            BuildTable();

            this.textBoxSource.Text =
                //"E042017V4713009000012000000099900000000000001107110000P00N";
                            "F0000003671T2017V107508807120300163122518698 2017012500000019900ILS00000001879EUR00001109261PFP 2017012500010000000 00000000000000000000000000000000000             P 000010003000000000000000000000020";

            Source2Schema();

            Schema2TextBoxes();

        }

        private void comboBoxSchemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildTable();

            Source2Schema();

            Schema2TextBoxes();
        }


        private void Source2Schema()
        {
            foreach (SchemaItem item in schema)
            {
                string tmp = "";
                try
                {
                    tmp = textBoxSource.Text.Substring(item.Start - 1, item.Length);
                }
                catch (ArgumentOutOfRangeException aor1)
                {
                    Console.WriteLine(aor1.Message);

                    try
                    {
                        tmp = textBoxSource.Text.Substring(item.Start - 1);
                    }
                    catch (ArgumentOutOfRangeException aor2)
                    {
                        Console.WriteLine(aor2.Message);
                    }
                }

                item.Value = tmp;
            }
        }

        //private void Schema2Source()
        //{
        //}

        private void Schema2TextBoxes()
        {
            int row = 0;

            foreach (var item in tableLayoutPanelFields.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = schema[row++].Value;
                    Size size = TextRenderer.MeasureText(((TextBox)item).Text, ((TextBox)item).Font);
                    if (((TextBox)item).Width < size.Width) ((TextBox)item).Width = size.Width;
                }
            }
        }

        //private void TextBoxes2Schema()
        //{
        //}

        private void BuildSchema()
        {
            var fields = dbContext.SchemasFields.Where(c => c.Schema == ((Schema)(comboBoxSchemas.SelectedItem)).Id).OrderBy(c => c.Start);

            int r = 0;
            schema = new SchemaItem[fields.Count()];

            foreach (SchemaFields item in fields)
            {
                schema[r++] = new SchemaItem(item.Name, item.Start, item.Length, item.Type, item.Remark);
            }

        }

        private void BuildTable()
        {

            tableLayoutPanelFields.Controls.Clear();

            BuildSchema();

            int r = 0;

            foreach (SchemaItem item in schema)
            {
                Label name = new Label() { Text = item.Name };
                name.Click += new EventHandler(label_Click);
                tableLayoutPanelFields.Controls.Add(name, 0, r);

                Label start = new Label() { Text = item.Start.ToString() };
                start.Click += new EventHandler(label_Click);
                tableLayoutPanelFields.Controls.Add(start, 1, r);

                Label length = new Label() { Text = item.Length.ToString() };
                length.Click += new EventHandler(label_Click);
                tableLayoutPanelFields.Controls.Add(length, 2, r);

                TextBox value = new TextBox();//{ ReadOnly = true }
                //value.Click += new EventHandler(label_Click);                
                //value.TextChanged += new EventHandler(textBoxValue_TextChanged);
                value.Validating += new CancelEventHandler(value_Validating);

                Size size = TextRenderer.MeasureText(value.Text, value.Font);
                if (value.Width < size.Width) value.Width = size.Width;

                this.toolTip1.SetToolTip(value, item.Type == null ? "Not defined" : item.Type.Trim());

                tableLayoutPanelFields.Controls.Add(value, 3, r);

                Label type = new Label() { Text = item.Type };
                tableLayoutPanelFields.Controls.Add(type, 4, r);

                Label remark = new Label() { Text = item.Remark };
                tableLayoutPanelFields.Controls.Add(remark, 5, r);

                r++;
            }
        }

        void value_Validating(object sender, CancelEventArgs e)
        {
            int row = tableLayoutPanelFields.GetRow((Control)sender);

            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                schema[row].Value = tb.Text;
            }
            else
                if (tb.Text.Length == schema[row].Length)
                {
                    schema[row].Value = tb.Text;
                }
                else
                    if (tb.Text.Length < schema[row].Length)
                    {
                        schema[row].Value = tb.Text.PadRight(schema[row].Length);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Text length must be {0} symbol{1}. Please correct.", schema[row].Length, schema[row].Length == 1 ? "" : "s"));

                        tb.Text = schema[row].Value;
                    }

        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != "")
            {
                Source2Schema();

                Schema2TextBoxes();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

            int row = tableLayoutPanelFields.GetRow((Control)sender);

            if (schema[row].Start > 0 && schema[row].Length > 0)
            {
                textBoxSource.Select(schema[row].Start - 1, schema[row].Length);
            }
            else
            {
                textBoxSource.DeselectAll();
            }

        }

        private void buttonBuldSource_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(textBoxSource.Text.Length);

            foreach (SchemaItem item in schema)
            {
                if (item.Value.Length == item.Length)
                {
                    sb.Append(item.Value);
                }
                else
                    if (item.Value.Length == 0)
                    {
                        sb.Append(new string(' ', item.Length));
                    }
                    else
                        if (item.Value.Length < item.Length)
                        {
                            sb.Append(item.Value.PadRight(item.Length));
                        }
                        else
                        {
                            sb.Append(item.Value.Substring(1, item.Length));
                        }

            }

            textBoxSource.Text = sb.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSource.Clear();
            //textBoxSource.Text = "";

            Source2Schema();
            Schema2TextBoxes();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            textBoxSource.Clear();
            textBoxSource.Paste();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            textBoxSource.Copy();
        }

    }
}
