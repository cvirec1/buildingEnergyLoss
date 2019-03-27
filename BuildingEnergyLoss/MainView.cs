using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingEnergyLoss.Materials;

namespace BuildingEnergyLoss
{
    public partial class MainView : Form
    {
        private MainViewModel _mainViewModel;
        public MainView(MainViewModel mainViewModel)
        {
            _mainViewModel = new MainViewModel();
            InitializeComponent();
            addToCombo();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext1(object sender, EventArgs e)
        {

        }

        private void btnNextCreate_Click(object sender, EventArgs e)
        {
            _mainViewModel.HouseID.Add(tbxHouseName.Text);
            _mainViewModel.HouseID.Add(tbxName.Text);
            _mainViewModel.HouseID.Add(tbxSurname.Text);
            _mainViewModel.MinTemperature = (int)nupMin.Value;
            _mainViewModel.InsideTemperature = (int)nupInside.Value;
            if (rbNormal.Checked == true)
            {
                _mainViewModel.Country = CountryType.normal;
            }
            else if (rbWind.Checked == true)
            {
                _mainViewModel.Country = CountryType.wind;
            }
            if (rbProtected.Checked == true)
            {
                _mainViewModel.BuildType = BuildingType.Protected;
            }
            else if (rbUnprotected.Checked == true)
            {
                _mainViewModel.BuildType = BuildingType.Unprotected;
            }
            else if (rbNegative.Checked == true)
            {
                _mainViewModel.BuildType = BuildingType.Negative;
            }
            tbcMain.SelectTab(1);

        }
        
        private void addToCombo()
        {
            addMaterialToCombo(cmbLayer1);            
            addMaterialToCombo(cmbLayer2);            
            addMaterialToCombo(cmbLayer3);           
            addMaterialToCombo(cmbLayer4);            
            addMaterialToCombo(cmbLayer1Floor);            
            addMaterialToCombo(cmbLayer2Floor);           
            addMaterialToCombo(cmbLayer3Floor);            
            addMaterialToCombo(cmbLayer4Floor);            
        }
        

        private void addMaterialToCombo(ComboBox combo)
        {
            combo.DataSource = _mainViewModel.GetMaterial();
            combo.DisplayMember = nameof(Material.Name);
            combo.ValueMember = nameof(Material.ID);
            combo.BindingContext = new BindingContext();
        }

        private void btnNextWall_Click(object sender, EventArgs e)
        {
            _mainViewModel.WallWidth = double.Parse(txbWidthWall.Text);
            _mainViewModel.WallLenght = double.Parse(txbLenghtWall.Text);
            _mainViewModel.WallHeight = double.Parse(txbHeightWall.Text);
            //_mainViewModel.MeasureWall.Add(double.Parse(txbWidthWall.Text));
            //_mainViewModel.MeasureWall.Add(double.Parse(txbLenghtWall.Text));
            //_mainViewModel.MeasureWall.Add(double.Parse(txbHeightWall.Text));
            _mainViewModel.WallId.Add((int)cmbLayer1.SelectedValue);
            _mainViewModel.WallId.Add((int)cmbLayer2.SelectedValue);
            _mainViewModel.WallId.Add((int)cmbLayer3.SelectedValue);
            _mainViewModel.WallId.Add((int)cmbLayer4.SelectedValue);
            _mainViewModel.WallThickness.Add(double.Parse(txbLayer1.Text));
            _mainViewModel.WallThickness.Add(double.Parse(txbLayer2.Text));
            _mainViewModel.WallThickness.Add(double.Parse(txbLayer3.Text));
            _mainViewModel.WallThickness.Add(double.Parse(txbLayer4.Text));
            tbcMain.SelectTab(2);
        }

        private void btnNextFloor_Click(object sender, EventArgs e)
        {
            _mainViewModel.FloorWidth = double.Parse(txbWidthFloor.Text);
            _mainViewModel.FloorLenght = double.Parse(txbLenghtFloor.Text);            
            //_mainViewModel.MeasureFloor.(double.Parse(txbWidthFloor.Text));
            //_mainViewModel.MeasureFloor.Add(double.Parse(txbLenghtFloor.Text));            
            _mainViewModel.FloorId.Add((int)cmbLayer1Floor.SelectedValue);
            _mainViewModel.FloorId.Add((int)cmbLayer2Floor.SelectedValue);
            _mainViewModel.FloorId.Add((int)cmbLayer3Floor.SelectedValue);
            _mainViewModel.FloorId.Add((int)cmbLayer4Floor.SelectedValue);
            _mainViewModel.FloorThickness.Add(double.Parse(txbLayer1Floor.Text));
            _mainViewModel.FloorThickness.Add(double.Parse(txbLayer2Floor.Text));
            _mainViewModel.FloorThickness.Add(double.Parse(txbLayer3Floor.Text));
            _mainViewModel.FloorThickness.Add(double.Parse(txbLayer4Floor.Text));
            tbcMain.SelectTab(3);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _mainViewModel.RoofWidth = double.Parse(txbWidthRoof.Text);
            _mainViewModel.RoofLenght = double.Parse(txbLenghtRoof.Text);
            //_mainViewModel.MeasureRoof.Add(double.Parse(txbWidthRoof.Text));
            //_mainViewModel.MeasureRoof.Add(double.Parse(txbLenghtRoof.Text));
            _mainViewModel.RoofId.Add((int)cmbLayer1Roof.SelectedValue);
            _mainViewModel.RoofId.Add((int)cmbLayer2Roof.SelectedValue);
            _mainViewModel.RoofId.Add((int)cmbLayer3Roof.SelectedValue);
            _mainViewModel.RoofId.Add((int)cmbLayer4Roof.SelectedValue);
            _mainViewModel.RoofThickness.Add(double.Parse(txbLayer1Roof.Text));
            _mainViewModel.RoofThickness.Add(double.Parse(txbLayer2Roof.Text));
            _mainViewModel.RoofThickness.Add(double.Parse(txbLayer3Roof.Text));
            _mainViewModel.RoofThickness.Add(double.Parse(txbLayer4Roof.Text));
            tbcMain.SelectTab(4);
        }

        
    }
}
