using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ForgetMeNot.Architecture;
using ForgetMeNot.Services.Dto;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot
{
    public partial class MainForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IChoreService _choreService;
        private readonly IPlantService _plantService;
        private readonly IFormFactory _formFactory;
        private List<ChoreDto> _chores;

        public MainForm(IAuthService authService, IFormFactory formFactory, IChoreService choreService,
            IPlantService plantService)
        {
            _authService = authService;
            _formFactory = formFactory;
            _choreService = choreService;
            _plantService = plantService;
            InitializeComponent();
            // Save();
            LoadChores();

            lblYourName.Text = @$"Hello {_authService.Name}!";
        }

        private void LoadChores()
        {
            _chores = _choreService.GetAll().ToList();

            clbChores.DataSource = _chores;
            clbChores.DisplayMember = "Title";
            clbChores.ValueMember = "IsCompleted";
            clbChores.CheckOnClick = false;
            for (var i = 0; i < _chores.Count(); i++)
            {
                clbChores.SetItemCheckState(i, _chores[i].IsCompleted ? CheckState.Checked : CheckState.Unchecked);
            }
        }

        private void clbChores_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var selectedItem = sender.GetType().GetProperty("SelectedItem")?.GetValue(sender, null) as ChoreDto;
            var plant = _plantService.GetById(selectedItem.PlantId);
            var img = Image.FromFile(plant.Base64Picture);
            pbFlower.Image = img;
            pbFlower.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbChores.Items.Count; i++)
            {
                var chore = clbChores.Items[i] as ChoreDto;
                var isComplete = clbChores.CheckedItems.OfType<ChoreDto>().Any(x => x.Id == chore?.Id);
                chore.IsCompleted = isComplete;
                _choreService.Save(chore);
            }

            foreach (var chore in clbChores.Items)
            {
            }
        }

        private void btnNewPlant_Click_1(object sender, EventArgs e)
        {
            var mainForm = _formFactory.CreateForm(typeof(AddPlantForm));
            mainForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}