using System.Text.Json;

namespace Anket
{
    public partial class Form1 : Form
    {
        public static void Write<T>(string filePath, T obj)
        {
            try
            {
                JsonSerializerOptions serializerOptions = new JsonSerializerOptions();
                serializerOptions.WriteIndented = true;
                File.WriteAllText(filePath, JsonSerializer.Serialize(obj, serializerOptions));
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public static T Read<T>(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(text);
            }
            catch (FileNotFoundException f) { MessageBox.Show("File Don't Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
            return default(T);
        }
        public Form1()
        {
            InitializeComponent();
            Man.Checked = true;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || fathersnameTextBox.Text == "" || countryTextBox.Text == "" ||
                cityTextBox.Text == "" || phoneTextBox.Text == "") MessageBox.Show("Fill All Blanks!");
            else
            {
                if (Man.Checked) gender = "Male";
                else gender = "Female"; 
         
                Write($"{nameTextBox.Text}.json", new User(surnameTextBox.Text, nameTextBox.Text, fathersnameTextBox.Text,
                    countryTextBox.Text, cityTextBox.Text, phoneTextBox.Text, dateTimePicker1.Value, gender));
            }
        }
        private void Load_Click(object sender, EventArgs e)
        {
            User user = Read<User>($"{jsonTextBox.Text}.json");
            if (user != null)
            {
                surnameTextBox.Text = user.Surname;
                nameTextBox.Text = user.Name;
                fathersnameTextBox.Text = user.FathersName;
                countryTextBox.Text = user.Country;
                cityTextBox.Text = user.City;
                phoneTextBox.Text = user.Phone;
                dateTimePicker1.Value = user.Birthday;
                if (user.Sex == "Male") Man.Checked = true;
                else Female.Checked = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}