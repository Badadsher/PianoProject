using Microsoft.VisualStudio.TestTools.UnitTesting;
using PianoProject.Pages.Admins;
using PianoProject.Pages.Managers;
using PianoProject.Pages;
using System.Windows;
using System.Windows.Media.Media3D;
using System.Windows.Controls;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    /////////////////////////////////////////////////////////////////////////////////////////////
    public void TestAdminLogin()
    {
        // Arrange
        var loginPage = new Login();
       
        // Act
        // Имитируем ввод логина и пароля для администратора
        loginPage.TxbLogin.Text = "admin";
        loginPage.TxbPassword.Password = "admin";
        loginPage.LogInBtn_Click(null, null);
       
        // Assert
        Assert.IsTrue(loginPage.NavigationService.Content is AdminChooser);
    }

    [TestMethod]
    public void TestManagerLogin()
    {
        // Arrange
        var loginPage = new Login();
        
        // Act
        // Имитируем ввод логина и пароля для менеджера
        loginPage.TxbLogin.Text = "manager";
        loginPage.TxbPassword.Password = "manager123";
        loginPage.LogInBtn_Click(null, null);

        // Assert
        Assert.IsTrue(loginPage.NavigationService.Content is ManagerChooser);
    }

    [TestMethod]
    public void TestRegularUserLogin()
    {
        // Arrange
        var loginPage = new Login();

        // Act
        // Имитируем ввод логина и пароля для обычного пользователя
        loginPage.TxbLogin.Text = "user";
        loginPage.TxbPassword.Password = "user";
        loginPage.LogInBtn_Click(null, null);

        // Assert
        Assert.IsTrue(loginPage.NavigationService.Content is Catalog);
    }


    [TestMethod]
    public void TestFailedAttempts()
    {
        // Arrange
        var loginPage = new Login();

        // Act
        // Имитируем несколько неудачных попыток входа
        loginPage.TxbLogin.Text = "invalid";
        loginPage.TxbPassword.Password = "invalid123";
        loginPage.LogInBtn_Click(null, null);
        loginPage.LogInBtn_Click(null, null);
        loginPage.LogInBtn_Click(null, null);

        // Assert
        Assert.IsTrue(loginPage.NavigationService.Content is Capcha);
    }

    ////////////////////////////////////////////////////////////////////////////////////////////CapchaTest

    [TestClass]
    public class CapchaTests
    {
        [TestMethod]
        public void TestVerifyCapcha_Successful()
        {
            // Arrange
            var capchaPage = new Capcha();
            capchaPage.capchaText.Text = "1234"; // Задаем значение для capchaText
            var inputCapcha = new TextBox();
            inputCapcha.Text = "1234"; // Вводим правильный код

            // Act
            capchaPage.verifyCapcha_Click(null, null);

            // Assert
            Assert.IsTrue(capchaPage.NavigationService.Content is Login);
        }

        [TestMethod]
        public void TestVerifyCapcha_Failure()
        {
            // Arrange
            var capchaPage = new Capcha();
            capchaPage.capchaText.Text = "1234"; // Задаем значение для capchaText
            var inputCapcha = new TextBox();
            inputCapcha.Text = "5678"; // Вводим неправильный код

            // Act
            capchaPage.verifyCapcha_Click(null, null);

            // Assert
            Assert.AreNotEqual(typeof(Login), capchaPage.NavigationService.Content.GetType());
        }
    }
}

  