using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        RequestResponseService evaluator;
        House inputValues;
        public Form1()
        {
            InitializeComponent();
            evaluator = new RequestResponseService();
            inputValues = new House("", "", "", "", "","", "","","","","","");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInputValues();
            evaluator.StartPricePrediction(inputValues);
            
        }

        private void getInputValues()
        {
            inputValues.Bathrooms = bathrooms.Value.ToString();
            inputValues.Bedrooms = bedrooms.Value.ToString();
            inputValues.Sqft_living = sqft_living.Value.ToString();
            inputValues.Sqft_lot = sqft_lot.Value.ToString();
            inputValues.Floors = floors.Value.ToString();
            inputValues.Waterfront = waterfront.Value.ToString();
            inputValues.View = view.Value.ToString();
            inputValues.Condition = condition.Value.ToString();
            inputValues.Grade = grade.Value.ToString();
            inputValues.Yr_built = yr_built.Value.ToString();
            inputValues.Yr_renovated = yr_renovated.Value.ToString();
            inputValues.Zipcode = zipcode.Value.ToString();
            
            Console.WriteLine(inputValues);
        }

        
    }
}
