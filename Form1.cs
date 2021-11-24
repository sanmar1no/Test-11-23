using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка "Проверить"
        private void btnCheck_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> PersonCollection = 
                JsonConvert.DeserializeObject<Dictionary<string, string>> (File.ReadAllText(@"users.json"));

            if (PersonCollection.ContainsKey(tbUserName.Text))
            {
                if (PersonCollection[tbUserName.Text] == tbPass.Text)
                {
                    MessageBox.Show("Пользователь существует");                         //Существует пользователь с таким именем и паролем
                }
                else
                {
                    MessageBox.Show("Пользователь не существует");                      //Пользователь с таким именем и паролем не существует
                }
            }
            else
            {
                MessageBox.Show("Пользователь не существует");                          //Пользователь с таким именем не зарегистрирован
            }

        }

        // Добавить/записать данные в JSON
        private void WriteJson(string username, string pass)
        {
            if (!(username == "" || pass == ""))
            {
                Dictionary<string, string> PersonCollection = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(@"users.json"));
                if (PersonCollection.ContainsKey(username))
                {
                    PersonCollection[username] = pass;                      //При условии, что существует такой пользователь, обновим ему пароль
                }
                else
                {
                    PersonCollection.Add(username, pass);                   // в противном случае добавим нового пользователя и пароль
                }
                
                File.WriteAllText(@"users.json", JsonConvert.SerializeObject(PersonCollection).ToString());
            }
        }

        //Кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {

            WriteJson(tbUserName.Text, tbPass.Text);

        }

        private void EnabledBtn()
        {
            if (!(tbUserName.Text == "" || tbPass.Text == ""))
            {
                btnAdd.Enabled = true;              // Разрешаем нажимать на кнопки
                btnCheck.Enabled = true;
            }
            else 
            {
                btnAdd.Enabled = false;             //запрещаем нажимать на кнопки
                btnCheck.Enabled = false;
            }
        }
        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }
    }
}
