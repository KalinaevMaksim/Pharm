﻿using System.Threading.Tasks;
using System.Windows;

namespace Pharm.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private async void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string Login = TBLogin.Text, Password = PBPassword.Password;
            Пользователи User = null;

            if (CheckFields(ref Login, ref Password) == false)
                return;

            //User = await FindUser(Login);

            //if (CheckUser(ref User, ref Password) == false)
            //    return;

            LogIn(ref User);
        }

        private static bool CheckFields(ref string Login, ref string Password)
        {
            if (string.IsNullOrEmpty(Login))
            {
                MessageBox.Show(string.IsNullOrEmpty(Password) ?
                    "Поля не заполнены" :
                    "Логин не заполнен",
                    "Ошибка");
                return false;
            }

            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Пароль не заполнен", "Ошибка");
                return false;
            }

            return true;
        }

        private async static Task<Пользователи> FindUser(string Login)
        {
                using (АптекаEntities context = new АптекаEntities())
                    return await Task.Run(() => context.Пользователи.Find(Login));
        }

        private bool CheckUser(ref Пользователи user, ref string Password)
        {
            if (user == null)
            {
                MessageBox.Show("Пользователя с таким логином не существует", "Ошибка");
                return false;
            }

            if (user.Пароль != Password)
            {
                MessageBox.Show("Неверный пароль", "Ошибка");
                return false;
            }

            return true;
        }

        private void LogIn(ref Пользователи user)
        {
            //Properties.Settings.Default.UserRole = user.Роль;
            new MainWindow().Show();
            Close();
        }
    }
}