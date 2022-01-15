
namespace ProductMana
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prodManagerDataSet = new ProductMana.ProdManagerDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new ProductMana.ProdManagerDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new ProductMana.ProdManagerDataSetTableAdapters.TableAdapterManager();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(110, 91);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "email:";
            // 
            // passwordsLabel
            // 
            passwordsLabel.AutoSize = true;
            passwordsLabel.Location = new System.Drawing.Point(109, 119);
            passwordsLabel.Name = "passwordsLabel";
            passwordsLabel.Size = new System.Drawing.Size(79, 17);
            passwordsLabel.TabIndex = 7;
            passwordsLabel.Text = "passwords:";
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
            // Email
            // 
            this.Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email", true));
            this.Email.Location = new System.Drawing.Point(229, 88);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 22);
            this.Email.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "passwords", true));
            this.Password.Location = new System.Drawing.Point(229, 116);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Login_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(491, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(passwordsLabel);
            this.Controls.Add(this.Password);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

