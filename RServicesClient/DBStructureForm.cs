using DataAnalyzer.DbStorage;
using DataAnalyzer.DbStorage.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalyzer
{
    public partial class DBStructureForm : Form
    {
        DBStorage _storage;
        public DBStructureForm(String connectionString)
        {
            _storage = new DBStorage(connectionString);
           
            InitializeComponent();

            _categoriesList.DisplayMember = "Name";
            _scriptsList.DisplayMember = "Name";
        }

        private async void DBStructureForm_Shown(Object sender, EventArgs e)
        {
            try
            {
                _statusLabel.Text = "Checking...";

                Boolean checkResult = await _storage.CheckDbStructure();

                if (checkResult)
                {
                    _statusLabel.Text = "Struture is OK";
                    _saveCurrent.Visible = true;
                    _loadBtn.Visible = true;
                    await ReloadCategories();
                }
                else
                {
                    _initStructureBtn.Visible = true;
                    splitContainer1.Enabled = false;
                    _statusLabel.Text = "Struture is not correct. It should be initialized";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void DBStructureForm_Load(Object sender, EventArgs e)
        {

        }

        private async void _initStructureBtn_Click(Object sender, EventArgs e)
        {
            try
            {
                _statusLabel.Text = "Creating...";

                await _storage.CreateStructureAsync();

                _statusLabel.Text = "Struture is OK";
                _saveCurrent.Visible = true;
                _loadBtn.Visible = true;
                _initStructureBtn.Visible = false;
                splitContainer1.Enabled = true;
              

            }
            catch (Exception ex)
            {
                _statusLabel.Text = "Struture is not correct. It should be initialized";
                MessageBox.Show(ex.Message);

            }
        }

        private async void _categoryUpBtn_Click(Object sender, EventArgs e)
        {
            if (prevCategories.Count == 0) return;

            var category = _categoriesList.SelectedItem as CategoryModel;

            try
            {
                _statusLabel.Text = "Loading...";


                var categories = await _storage.GetCategories(prevCategories.Peek());
            
                currentCategoryId = prevCategories.Pop();

                _categoriesList.DataSource = categories;             

                _scriptsList.Text = "Loaded";
            }
            catch (Exception ex)
            {
                _statusLabel.Text = "Struture is not correct. It should be initialized";
                MessageBox.Show(ex.Message);

            }
        }

        private Stack<Int32> prevCategories = new Stack<int>();
        private Int32 currentCategoryId = 0;
        private Int32 selectedCategory = 0;

        public ScriptModel CurrentScript { get; private set; }


        private async Task ReloadCategories()
        {
            try
            {
                _statusLabel.Text = "Loading...";
                currentCategoryId = 0;
                var categories = await _storage.GetCategories(currentCategoryId);

                prevCategories = new Stack<int>();

                _categoriesList.DataSource = categories;

                _statusLabel.Text = "Loaded";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void _loadBtn_Click(Object sender, EventArgs e)
        {
            await ReloadCategories();
        }

        private async void _addScriptBtn_Click_1(Object sender, EventArgs e)
        {
            if (selectedCategory == 0) return;

            InputNameDialog inputNameDialog = new InputNameDialog();

            if (inputNameDialog.ShowDialog() == DialogResult.OK)
            {
                await _storage.AddScript(selectedCategory, inputNameDialog.InputName);

                var scripts = await _storage.GetScripts(selectedCategory);               

                _scriptsList.DataSource = scripts;
            }
        }

        private async void _addCategoryBtn_Click(Object sender, EventArgs e)
        {
            InputNameDialog inputNameDialog = new InputNameDialog();
            if (inputNameDialog.ShowDialog() == DialogResult.OK)
            {
                await _storage.AddCategory(currentCategoryId, inputNameDialog.InputName);


                var categories = await _storage.GetCategories(currentCategoryId);
                currentCategoryId = 0;

                _categoriesList.DataSource = categories;
            }
        }

        private async void _categoriesList_SelectedIndexChanged(Object sender, EventArgs e)
        {
            var category = _categoriesList.SelectedItem as CategoryModel;

            try
            {
                _statusLabel.Text = "Loading...";

                var scripts = await _storage.GetScripts(category.ID);
                selectedCategory = category.ID;

                _scriptsList.DataSource = scripts;


                _statusLabel.Text = "Loaded";
            }
            catch (Exception ex)
            {
                _statusLabel.Text = "Struture is not correct. It should be initialized";
                MessageBox.Show(ex.Message);

            }
        }

        private async void _categoriesList_DoubleClick(Object sender, EventArgs e)
        {
            var category = _categoriesList.SelectedItem as CategoryModel;

            if (category == null) return;
            
            try
            {
                _statusLabel.Text = "Loading...";


                var categories = await _storage.GetCategories(category.ID);
                prevCategories.Push(currentCategoryId);
                currentCategoryId = category.ID;
                selectedCategory = 0;

                _categoriesList.DataSource = categories;
                _scriptsList.DataSource = new List<ScriptModel>();

                _statusLabel.Text = "Loaded";
            }
            catch (Exception ex)
            {
                _statusLabel.Text = "Structure is not correct. It should be initialized";
                MessageBox.Show(ex.Message);

            }
        }

        private void _scriptsList_DoubleClick(Object sender, EventArgs e)
        {
            var script = _scriptsList.SelectedItem as ScriptModel;

            if (script != null)
            {
                CurrentScript = script;
                DialogResult = DialogResult.Yes;
            }
        }

        private async  void _saveCurrent_Click(Object sender, EventArgs e)
        {
            if(CurrentScript == null)
            {
                MessageBox.Show("Current script is not selected");
                return;
            }
                        
            await _storage.UpdateScript(CurrentScript);

        }
    }
}
