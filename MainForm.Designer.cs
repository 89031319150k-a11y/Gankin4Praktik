namespace BindingNavigatorLab
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label role_NameLabel;
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.role_NameComboBox = new System.Windows.Forms.ComboBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            role_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // loginLabel
            //
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            loginLabel.Location = new System.Drawing.Point(12, 70);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(66, 24);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login:";
            //
            // passwordLabel
            //
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            passwordLabel.Location = new System.Drawing.Point(12, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(94, 24);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            //
            // first_NameLabel
            //
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            first_NameLabel.Location = new System.Drawing.Point(12, 142);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(108, 24);
            first_NameLabel.TabIndex = 5;
            first_NameLabel.Text = "First Name:";
            //
            // role_NameLabel
            //
            role_NameLabel.AutoSize = true;
            role_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            role_NameLabel.Location = new System.Drawing.Point(12, 178);
            role_NameLabel.Name = "role_NameLabel";
            role_NameLabel.Size = new System.Drawing.Size(105, 24);
            role_NameLabel.TabIndex = 7;
            role_NameLabel.Text = "Role Name:";
            //
            // usersBindingSource
            //
            this.usersBindingSource.DataSource = typeof(BindingNavigatorLab.ModelEF.Users);
            //
            // rolesBindingSource
            //
            this.rolesBindingSource.DataSource = typeof(BindingNavigatorLab.ModelEF.Roles);
            //
            // usersBindingNavigator
            //
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersBindingNavigator.Size = new System.Drawing.Size(909, 25);
            this.usersBindingNavigator.TabIndex = 0;
            this.usersBindingNavigator.Text = "usersBindingNavigator";
            //
            // bindingNavigatorAddNewItem
            //
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(66, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            //
            // bindingNavigatorCountItem
            //
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            //
            // bindingNavigatorDeleteItem
            //
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            //
            // bindingNavigatorMoveFirstItem
            //
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "|<";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Переместить в начало";
            //
            // bindingNavigatorMovePreviousItem
            //
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "<";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Переместить назад";
            //
            // bindingNavigatorSeparator
            //
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorPositionItem
            //
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            //
            // bindingNavigatorSeparator1
            //
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorMoveNextItem
            //
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = ">";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Переместить вперед";
            //
            // bindingNavigatorMoveLastItem
            //
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = ">|";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Переместить в конец";
            //
            // bindingNavigatorSeparator2
            //
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            //
            // usersBindingNavigatorSaveItem
            //
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.usersBindingNavigatorSaveItem.Enabled = true;
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(70, 22);
            this.usersBindingNavigatorSaveItem.Text = "Сохранить";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            //
            // loginTextBox
            //
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(140, 72);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(120, 20);
            this.loginTextBox.TabIndex = 2;
            //
            // passwordTextBox
            //
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(140, 108);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(120, 20);
            this.passwordTextBox.TabIndex = 4;
            //
            // first_NameTextBox
            //
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(140, 144);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(120, 20);
            this.first_NameTextBox.TabIndex = 6;
            //
            // role_NameComboBox
            //
            this.role_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Role_Name", true));
            this.role_NameComboBox.DataSource = this.rolesBindingSource;
            this.role_NameComboBox.DisplayMember = "Name";
            this.role_NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_NameComboBox.FormattingEnabled = true;
            this.role_NameComboBox.Location = new System.Drawing.Point(140, 180);
            this.role_NameComboBox.Name = "role_NameComboBox";
            this.role_NameComboBox.Size = new System.Drawing.Size(120, 21);
            this.role_NameComboBox.TabIndex = 8;
            this.role_NameComboBox.ValueMember = "Name";
            //
            // usersDataGridView
            //
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(290, 50);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(600, 360);
            this.usersDataGridView.TabIndex = 9;
            //
            // iDDataGridViewTextBoxColumn
            //
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // loginDataGridViewTextBoxColumn
            //
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            //
            // passwordDataGridViewTextBoxColumn
            //
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            //
            // firstNameDataGridViewTextBoxColumn
            //
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            //
            // roleNameDataGridViewTextBoxColumn
            //
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "Role_Name";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Role_Name";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 430);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(role_NameLabel);
            this.Controls.Add(this.role_NameComboBox);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.usersBindingNavigator);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.ComboBox role_NameComboBox;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
    }
}
