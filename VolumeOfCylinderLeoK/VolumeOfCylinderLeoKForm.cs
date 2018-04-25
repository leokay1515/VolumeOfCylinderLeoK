using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeOfCylinderLeoK
{
    public partial class frmVolumeOfCylinderLeoK : Form
    {
        public frmVolumeOfCylinderLeoK()
        {
            InitializeComponent();
        }

        private double CalculateVolume(double height, double radius)
        {
            //variables
            const double PI = Math.PI;
            double volume;

            //calculate the volume
            volume = PI * Math.Pow(radius, 2) * height;

            //round the volume
            volume = Math.Round(volume, 2);

            //return volume
            return volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables
            double userHeight;
            double userRadius;
            double userVolume;

            //get the radius and height from the user
            if (txtHeight.Text == "")
            {
                MessageBox.Show("Please enter the height.", "Volume of a Cylinder");
            }
            else if (txtRadius.Text == "")
            {
                MessageBox.Show("Please enter the radius", "Volume of a Cylinder");
            }
            else
            {
                //convert the user input to a double
                userHeight = Convert.ToDouble(txtHeight.Text);
                userRadius = Convert.ToDouble(txtRadius.Text);

                //call the function CalculateVolume
                userVolume = CalculateVolume(userHeight, userRadius);

                //Display the Volume
                MessageBox.Show("The volume of the cylinder is " + userVolume, "Volume of a Cylinder");
            }
        }
    }
}
