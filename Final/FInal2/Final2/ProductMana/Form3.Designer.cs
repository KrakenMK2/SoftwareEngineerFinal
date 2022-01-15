
namespace ProductMana
{
    partial class Form3
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordsLabel;
            this.prodManagerDataSet = new ProductMana.ProdManagerDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new ProductMana.ProdManagerDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new ProductMana.ProdManagerDataSetTableAdapters.TableAdapterManager();
            this.Username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            customerNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodManagerDataSet
            // 
            this.prodManagerDataSet.DataSetName = "ProdManagerDataSet";
            this.prodManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.prodManagerDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProductMana.ProdManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(37, 102);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(113, 17);
            customerNameLabel.TabIndex = 3;
            customerNameLabel.Text = "Customer Name:";
            // 
            // Username
            // 
            this.Username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerName", true));
            this.Username.Location = new System.Drawing.Point(156, 99);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 22);
            this.Username.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(37, 130);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "email:";
            // 
            // email
            // 
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email", true));
            this.email.Location = new System.Drawing.Point(156, 127);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 22);
            this.email.TabIndex = 6;
            // 
            // passwordsLabel
            // 
            passwordsLabel.AutoSize = true;
            passwordsLabel.Location = new System.Drawing.Point(37, 158);
            passwordsLabel.Name = "passwordsLabel";
            passwordsLabel.Size = new System.Drawing.Size(79, 17);
            passwordsLabel.TabIndex = 7;
            passwordsLabel.Text = "passwords:";
            // 
            // password
            // 
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "passwords", true));
            this.password.Location = new System.Drawing.Point(156, 155);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(156, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(passwordsLabel);
            this.Controls.Add(this.password);
            this.Name = "Form3";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProdManagerDataSet prodManagerDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ProdManagerDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private ProdManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}