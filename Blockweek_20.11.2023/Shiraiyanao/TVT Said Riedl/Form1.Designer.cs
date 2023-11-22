namespace TVT_Said_Riedl
{
    partial class TVT
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_patienten = new System.Windows.Forms.TabPage();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.button_savePatient = new System.Windows.Forms.Button();
            this.texBox_patient_phone = new System.Windows.Forms.TextBox();
            this.label_patient_phone = new System.Windows.Forms.Label();
            this.textBox_patient_lastName = new System.Windows.Forms.TextBox();
            this.label_patient_lastName = new System.Windows.Forms.Label();
            this.textBox_patient_firstName = new System.Windows.Forms.TextBox();
            this.label_patient_firstName = new System.Windows.Forms.Label();
            this.tab_addresses = new System.Windows.Forms.TabPage();
            this.button_ConnectAddressWithPatient = new System.Windows.Forms.Button();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.add_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_saveAddress = new System.Windows.Forms.Button();
            this.textBox_postal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_overrideAddress = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_patienten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.tab_addresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_patienten);
            this.tabControl1.Controls.Add(this.tab_addresses);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_patienten
            // 
            this.tab_patienten.Controls.Add(this.dgvPatient);
            this.tab_patienten.Controls.Add(this.button_savePatient);
            this.tab_patienten.Controls.Add(this.texBox_patient_phone);
            this.tab_patienten.Controls.Add(this.label_patient_phone);
            this.tab_patienten.Controls.Add(this.textBox_patient_lastName);
            this.tab_patienten.Controls.Add(this.label_patient_lastName);
            this.tab_patienten.Controls.Add(this.textBox_patient_firstName);
            this.tab_patienten.Controls.Add(this.label_patient_firstName);
            this.tab_patienten.Location = new System.Drawing.Point(4, 22);
            this.tab_patienten.Name = "tab_patienten";
            this.tab_patienten.Padding = new System.Windows.Forms.Padding(3);
            this.tab_patienten.Size = new System.Drawing.Size(768, 400);
            this.tab_patienten.TabIndex = 0;
            this.tab_patienten.Text = "Patienten";
            this.tab_patienten.UseVisualStyleBackColor = true;
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.firstName,
            this.lastName,
            this.phone,
            this.address_id});
            this.dgvPatient.Location = new System.Drawing.Point(190, 6);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.Size = new System.Drawing.Size(552, 388);
            this.dgvPatient.TabIndex = 6;
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
            // 
            // button_savePatient
            // 
            this.button_savePatient.Location = new System.Drawing.Point(9, 122);
            this.button_savePatient.Name = "button_savePatient";
            this.button_savePatient.Size = new System.Drawing.Size(164, 32);
            this.button_savePatient.TabIndex = 5;
            this.button_savePatient.Text = "Neue:n Patient:in hinzufügen";
            this.button_savePatient.UseVisualStyleBackColor = true;
            this.button_savePatient.Click += new System.EventHandler(this.button_savePatient_Click);
            // 
            // texBox_patient_phone
            // 
            this.texBox_patient_phone.Location = new System.Drawing.Point(67, 86);
            this.texBox_patient_phone.Name = "texBox_patient_phone";
            this.texBox_patient_phone.Size = new System.Drawing.Size(100, 20);
            this.texBox_patient_phone.TabIndex = 4;
            this.texBox_patient_phone.TextChanged += new System.EventHandler(this.textBox_patient_phone_TextChanged);
            // 
            // label_patient_phone
            // 
            this.label_patient_phone.AutoSize = true;
            this.label_patient_phone.Location = new System.Drawing.Point(6, 89);
            this.label_patient_phone.Name = "label_patient_phone";
            this.label_patient_phone.Size = new System.Drawing.Size(37, 13);
            this.label_patient_phone.TabIndex = 3;
            this.label_patient_phone.Text = "phone";
            // 
            // textBox_patient_lastName
            // 
            this.textBox_patient_lastName.Location = new System.Drawing.Point(67, 60);
            this.textBox_patient_lastName.Name = "textBox_patient_lastName";
            this.textBox_patient_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_patient_lastName.TabIndex = 4;
            this.textBox_patient_lastName.TextChanged += new System.EventHandler(this.textBox_patient_lastName_TextChanged);
            // 
            // label_patient_lastName
            // 
            this.label_patient_lastName.AutoSize = true;
            this.label_patient_lastName.Location = new System.Drawing.Point(6, 63);
            this.label_patient_lastName.Name = "label_patient_lastName";
            this.label_patient_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_patient_lastName.TabIndex = 3;
            this.label_patient_lastName.Text = "Last Name";
            // 
            // textBox_patient_firstName
            // 
            this.textBox_patient_firstName.Location = new System.Drawing.Point(67, 34);
            this.textBox_patient_firstName.Name = "textBox_patient_firstName";
            this.textBox_patient_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_patient_firstName.TabIndex = 2;
            this.textBox_patient_firstName.TextChanged += new System.EventHandler(this.textBox_patient_firstName_TextChanged);
            // 
            // label_patient_firstName
            // 
            this.label_patient_firstName.AutoSize = true;
            this.label_patient_firstName.Location = new System.Drawing.Point(6, 37);
            this.label_patient_firstName.Name = "label_patient_firstName";
            this.label_patient_firstName.Size = new System.Drawing.Size(55, 13);
            this.label_patient_firstName.TabIndex = 0;
            this.label_patient_firstName.Text = "First name";
            // 
            // tab_addresses
            // 
            this.tab_addresses.Controls.Add(this.button_overrideAddress);
            this.tab_addresses.Controls.Add(this.button_ConnectAddressWithPatient);
            this.tab_addresses.Controls.Add(this.dgvAddress);
            this.tab_addresses.Controls.Add(this.textBox_city);
            this.tab_addresses.Controls.Add(this.label4);
            this.tab_addresses.Controls.Add(this.button_saveAddress);
            this.tab_addresses.Controls.Add(this.textBox_postal);
            this.tab_addresses.Controls.Add(this.label1);
            this.tab_addresses.Controls.Add(this.textBox_nr);
            this.tab_addresses.Controls.Add(this.label2);
            this.tab_addresses.Controls.Add(this.textBox_street);
            this.tab_addresses.Controls.Add(this.label3);
            this.tab_addresses.Location = new System.Drawing.Point(4, 22);
            this.tab_addresses.Name = "tab_addresses";
            this.tab_addresses.Padding = new System.Windows.Forms.Padding(3);
            this.tab_addresses.Size = new System.Drawing.Size(768, 400);
            this.tab_addresses.TabIndex = 1;
            this.tab_addresses.Text = "Addresses";
            this.tab_addresses.UseVisualStyleBackColor = true;
            // 
            // button_ConnectAddressWithPatient
            // 
            this.button_ConnectAddressWithPatient.Location = new System.Drawing.Point(3, 240);
            this.button_ConnectAddressWithPatient.Name = "button_ConnectAddressWithPatient";
            this.button_ConnectAddressWithPatient.Size = new System.Drawing.Size(210, 32);
            this.button_ConnectAddressWithPatient.TabIndex = 17;
            this.button_ConnectAddressWithPatient.Text = "Addresse mit Patient:in verknüpfen";
            this.button_ConnectAddressWithPatient.UseVisualStyleBackColor = true;
            this.button_ConnectAddressWithPatient.Click += new System.EventHandler(this.button_ConnectAddressWithPatient_Click);
            // 
            // dgvAddress
            // 
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add_id,
            this.street,
            this.nr,
            this.postal,
            this.city});
            this.dgvAddress.Location = new System.Drawing.Point(219, 6);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.Size = new System.Drawing.Size(543, 388);
            this.dgvAddress.TabIndex = 15;
            this.dgvAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddress_CellContentClick);
            // 
            // add_id
            // 
            this.add_id.DataPropertyName = "add_id";
            this.add_id.HeaderText = "add_id";
            this.add_id.Name = "add_id";
            // 
            // street
            // 
            this.street.DataPropertyName = "street";
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            // 
            // nr
            // 
            this.nr.DataPropertyName = "nr";
            this.nr.HeaderText = "Nr";
            this.nr.Name = "nr";
            // 
            // postal
            // 
            this.postal.DataPropertyName = "postal";
            this.postal.HeaderText = "Postal";
            this.postal.Name = "postal";
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(67, 111);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(100, 20);
            this.textBox_city.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "city";
            // 
            // button_saveAddress
            // 
            this.button_saveAddress.Location = new System.Drawing.Point(3, 146);
            this.button_saveAddress.Name = "button_saveAddress";
            this.button_saveAddress.Size = new System.Drawing.Size(208, 32);
            this.button_saveAddress.TabIndex = 12;
            this.button_saveAddress.Text = "Neue Addresse hinzufügen";
            this.button_saveAddress.UseVisualStyleBackColor = true;
            this.button_saveAddress.Click += new System.EventHandler(this.button_saveAddress_Click);
            // 
            // textBox_postal
            // 
            this.textBox_postal.Location = new System.Drawing.Point(67, 85);
            this.textBox_postal.Name = "textBox_postal";
            this.textBox_postal.Size = new System.Drawing.Size(100, 20);
            this.textBox_postal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "postal";
            // 
            // textBox_nr
            // 
            this.textBox_nr.Location = new System.Drawing.Point(67, 59);
            this.textBox_nr.Name = "textBox_nr";
            this.textBox_nr.Size = new System.Drawing.Size(100, 20);
            this.textBox_nr.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nr";
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(67, 33);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(100, 20);
            this.textBox_street.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Street";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(768, 400);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(768, 400);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(768, 400);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(768, 400);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(768, 400);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // pat_id
            // 
            this.pat_id.DataPropertyName = "pat_id";
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstname";
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastname";
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address_id
            // 
            this.address_id.DataPropertyName = "address_id";
            this.address_id.HeaderText = "address_id";
            this.address_id.Name = "address_id";
            this.address_id.ReadOnly = true;
            // 
            // button_overrideAddress
            // 
            this.button_overrideAddress.Location = new System.Drawing.Point(3, 193);
            this.button_overrideAddress.Name = "button_overrideAddress";
            this.button_overrideAddress.Size = new System.Drawing.Size(208, 32);
            this.button_overrideAddress.TabIndex = 18;
            this.button_overrideAddress.Text = "Ausgewählte Addresse überschreiben";
            this.button_overrideAddress.UseVisualStyleBackColor = true;
            this.button_overrideAddress.Click += new System.EventHandler(this.button_overrideAddress_Click);
            // 
            // TVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TVT";
            this.Text = "TVT";
            this.tabControl1.ResumeLayout(false);
            this.tab_patienten.ResumeLayout(false);
            this.tab_patienten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.tab_addresses.ResumeLayout(false);
            this.tab_addresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_patienten;
        private System.Windows.Forms.TabPage tab_addresses;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TextBox texBox_patient_phone;
        private System.Windows.Forms.Label label_patient_phone;
        private System.Windows.Forms.TextBox textBox_patient_lastName;
        private System.Windows.Forms.Label label_patient_lastName;
        private System.Windows.Forms.TextBox textBox_patient_firstName;
        private System.Windows.Forms.Label label_patient_firstName;
        private System.Windows.Forms.Button button_savePatient;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Button button_saveAddress;
        private System.Windows.Forms.TextBox textBox_postal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.Button button_ConnectAddressWithPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_id;
        private System.Windows.Forms.Button button_overrideAddress;
    }
}

