using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sales_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public double Cost_of_Items()
        {
            Double sum = 0;
            int i = 0;
            for (i = 0; i < (dataGridView1.Rows.Count);
                i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void AddCost()
        {
            Double tax = 3.9, q;
            if (dataGridView1.Rows.Count > 0)
            {
                CultureInfo pkrCulture = new CultureInfo("ur-PK");
                lblTax.Text = string.Format(pkrCulture, "{0:C2}", (Cost_of_Items() * tax / 100));
                lblSubTotal.Text = string.Format(pkrCulture, "{0:C2}", Cost_of_Items());
                q = (Cost_of_Items() * tax / 100);
                lblTotal.Text = string.Format(pkrCulture, "{0:C2}", (Cost_of_Items() + q));
                lblBarCode.Text = Convert.ToString(q + Cost_of_Items());
            }
        }

        private void Change()
        {
            double tax = 3.9, totalCost, cash, change;

            if (double.TryParse(lblCash.Text, out cash))
            {
                totalCost = Cost_of_Items() + ((Cost_of_Items() * tax) / 100);
                change = cash - totalCost;
                lblChange.Text = string.Format(CultureInfo.GetCultureInfo("ur-PK"), "{0:C2}", change);
            }
            else
            {
                MessageBox.Show("Invalid cash input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Bitmap bitmap;
        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {

            try
            {
                lblBarCode.Text = "";
                lblCash.Text = "";
                lblChange.Text = "";
                lblSubTotal.Text = "";
                lblTax.Text = "";
                lblTotal.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cboPayment.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPayment.Items.Add("Cash");
            cboPayment.Items.Add("Visa Card");
            cboPayment.Items.Add("Master Card");

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Your custom painting logic here
        }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            if (lblCash.Text == "0")
            {
                lblCash.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!lblCash.Text.Contains("."))
                {
                    lblCash.Text += b.Text;
                }
            }
            else
            {
                lblCash.Text += b.Text;
            }
        }



        private void button10(object sender, EventArgs e)
        {
            lblCash.Text = "0";
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (cboPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void RemoveItem_Click_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            if (cboPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double CostofItem = 4500;
            bool rowUpdated = false;

            // Update existing row if it already contains "Daisy Fragrance"
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Daisy Fragrance") // Check if the item already exists
                {
                    // Update Quantity (Column2) and Amount (Column3)
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1; // Increment quantity
                    row.Cells[2].Value = (currentQty + 1) * CostofItem; // Recalculate cost

                    rowUpdated = true; // Mark that we updated an existing row
                    break;
                }
            }

            // If no existing row found, add a new one
            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Daisy Fragrance", 1, CostofItem);
            }

            AddCost(); // Update total cost

            // Database insertion logic
            string connectionString = "Data Source=DESKTOP-A503LCQ\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (dataGridView1.Rows.Count > 0) // Ensure there are rows in the DataGridView
                {
                    try
                    {
                        connection.Open();

                        // Insert each row into the database
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue; // Skip the empty new row

                            string itemName = row.Cells[0].Value?.ToString();
                            string qtyString = row.Cells[1].Value?.ToString();
                            string amountString = row.Cells[2].Value?.ToString();

                            // Validate fields
                            if (!string.IsNullOrEmpty(itemName) &&
                                double.TryParse(qtyString, out double qty) &&
                                double.TryParse(amountString, out double amount))
                            {
                                using (SqlCommand command = new SqlCommand())
                                {
                                    command.Connection = connection;
                                    command.CommandText = "INSERT INTO Items (Item, Qty, Amount) VALUES (@item, @qty, @amount)";
                                    command.Parameters.AddWithValue("@item", itemName);
                                    command.Parameters.AddWithValue("@qty", qty);
                                    command.Parameters.AddWithValue("@amount", amount);

                                    command.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Item(s) successfully added!");

                        // Recalculate and display total cost
                        double totalCost = Cost_of_Items();
                        lblTotal.Text = "Total Cost: " + totalCost.ToString("F2");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No data available to insert.");
                }
            }
        }


        private void button23_Click(object sender, EventArgs e)
        {
            double CostofItem = 2500;
            bool rowUpdated = false;

            // Check if item exists in the DataGridView and update it
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Jasmine Fragrance")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1; // Increment quantity
                    row.Cells[2].Value = (currentQty + 1) * CostofItem; // Update cost
                    rowUpdated = true;
                    break;
                }
            }

            // If not found, add a new row
            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Jasmine Fragrance", 1, CostofItem);
            }

            AddCost(); // Recalculate costs

            // Insert into database
            SaveItemToDatabase("Jasmine Fragrance", 1, CostofItem);
        }


        private void button22_Click(object sender, EventArgs e)
        {
            double CostofItem = 3000;
            bool rowUpdated = false;

            // Check if item exists in the DataGridView and update it
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Crystal Bloom")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1; // Increment quantity
                    row.Cells[2].Value = (currentQty + 1) * CostofItem; // Update cost
                    rowUpdated = true;
                    break;
                }
            }

            // If not found, add a new row
            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Crystal Bloom ", 1, CostofItem);
            }

            AddCost(); // Recalculate costs

            // Insert into database
            SaveItemToDatabase("Crystal Bloom ", 1, CostofItem);
        }


        private void button21_Click(object sender, EventArgs e)
        {
            double CostofItem = 3500;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Royal Amour")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Royal Amour", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Royal Amour ", 1, CostofItem);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double CostofItem = 9000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Florse Fragrance")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Florse Fragrance", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Florse Fragrance", 1, CostofItem);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double CostofItem = 4000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Elettra Fragrance")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Elettra Fragrance", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Elettra Fragrance", 1, CostofItem);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Oceanic Mist")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Oceanic Mist", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Oceanic Mist", 1, CostofItem);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Saffron Dreams")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Saffron Dreams", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Saffron Dreams", 1, CostofItem);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Crimson Blossom")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Crimson Blossom", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Crimson Blossom", 1, CostofItem);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Coco Lush")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Coco Lush", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Coco Lush", 1, CostofItem);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Tropical Bliss")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Tropical Bliss", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Tropical Bliss", 1, CostofItem);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Secret Garden")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Secret Garden", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Secret Garden", 1, CostofItem);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Rosewood Delight")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Rosewood Delight", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Rosewood Delight", 1, CostofItem);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Silver Orchid")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Silver Orchid", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Silver Orchid", 1, CostofItem);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Eternal Rose")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Eternal Rose", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Eternal Rose", 1, CostofItem);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Amber Whisper")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Amber Whisper ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Amber Whisper", 1, CostofItem);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Golden Essence ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Golden Essence ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Golden Essence ", 1, CostofItem);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Twilight Jasmine ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Twilight Jasmine ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Twilight Jasmine ", 1, CostofItem);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Velvet Noir")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Velvet Noir ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Velvet Noir ", 1, CostofItem);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Celestial Dew ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Celestial Dew ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Celestial Dew ", 1, CostofItem);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Opal Bloom ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Opal Bloom", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Opal Bloom", 1, CostofItem);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Golden Sands ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Golden Sands ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Golden Sands ", 1, CostofItem);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Frosted Citrus ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Frosted Citrus ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Frosted Citrus ", 1, CostofItem);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double CostofItem = 2000;
            bool rowUpdated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "Mystic Woods ")
                {
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = currentQty + 1;
                    row.Cells[2].Value = (currentQty + 1) * CostofItem;
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                dataGridView1.Rows.Add("Mystic Woods ", 1, CostofItem);
            }

            AddCost();
            SaveItemToDatabase("Mystic Woods ", 1, CostofItem);
        }


        private void SaveItemToDatabase(string itemName, int qty, double amount)
        {
            string connectionString = "Data Source=DESKTOP-A503LCQ\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Items (Item, Qty, Amount) VALUES (@item, @qty, @amount)";
                        command.Parameters.AddWithValue("@item", itemName);
                        command.Parameters.AddWithValue("@qty", qty);
                        command.Parameters.AddWithValue("@amount", amount);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show($"{itemName} successfully added to the database!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblCash_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


