using System;
using System.Data.Entity;   // нужна для метода Load() и ToBindingList()
using System.Linq;
using System.Windows.Forms;

namespace BindingNavigatorLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Контекст модели EF
        ModelEF.ModelEF model = new ModelEF.ModelEF();

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartLoadData();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // для новой записи выбираем в ComboBox первую роль
            role_NameComboBox.SelectedIndex = 0;
        }

        // Загрузка данных в источники данных
        private void StartLoadData()
        {
            model.Users.Load();
            role_NameComboBox.DataSource = model.Roles.ToList();
            usersBindingSource.DataSource = model.Users.Local.ToBindingList();
        }

        // Синхронизация источников данных с моделью и БД
        private void SaveData()
        {
            try
            {
                Validate();
                usersBindingSource.EndEdit();
                usersBindingSource.ResetBindings(true);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartLoadData();
            }
        }
    }
}
