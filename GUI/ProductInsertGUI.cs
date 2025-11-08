using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductInsertGUI : UserControl
    {
        public ProductInsertGUI()
        {
            InitializeComponent();
        }
        public void InsertData(List<BrandDTO> brands, List<TypeProductDTO> types)
        {
            // AI Generated code
            brand_listBox.DataSource = brands?.ToList() ?? new List<BrandDTO>();
            brand_listBox.DisplayMember = nameof(BrandDTO.BrandName);
            brand_listBox.ValueMember = nameof(BrandDTO.BrandId);

            category_listBox.DataSource = types?.ToList() ?? new List<TypeProductDTO>();
            category_listBox.DisplayMember = nameof(TypeProductDTO.TypeProductName);
            category_listBox.ValueMember = nameof(TypeProductDTO.TypeProductId);
            // End of AI Generated code
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayout_storeItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fileDialog.InitialDirectory = "BadmintonCourtManagement\\GUI\\Img\\Product";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // The full path of the user's selected file
                    string sourceFilePath = fileDialog.FileName;

                    // The name of the file, without the path
                    string fileName = fileDialog.SafeFileName;

                    // Define the destination folder relative to the application's executable
                    string appDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    // Navigate up to the project folder and then to your Img folder
                    // This might need adjustment based on your project structure.
                    // A common structure is bin/Debug, so you might go up two levels.
                    string destFolder = Path.Combine(appDirectory, @"..\..\GUI\Img\Product");

                    // Ensure the destination directory exists
                    if (!Directory.Exists(destFolder))
                    {
                        Directory.CreateDirectory(destFolder);
                    }

                    // Construct the full destination path
                    string destFilePath = Path.Combine(destFolder, fileName);

                    // Copy the file to the destination, with the option to overwrite
                    File.Copy(sourceFilePath, destFilePath, true);

                    // Now 'destFilePath' holds the path to the copied image within your project structure.
                    // You can store this path in a database or use it to display the image.
                    // For example:
                    // pictureBox1.Image = new Bitmap(destFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
            else
            {
                // User cancelled the dialog
            }
        }

        private void brand_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
