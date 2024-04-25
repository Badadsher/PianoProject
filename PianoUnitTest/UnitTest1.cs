using Microsoft.VisualStudio.TestTools.UnitTesting;
using PianoProject.Pages.Admins;
using PianoProject.Pages.Managers;
using PianoProject.Pages;
using System.Windows;
using System.Windows.Media.Media3D;

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

    /////////////////////////////////////////////////////////////////////////////////////////////
    ///

    //[TestClass]
    //public class RegInTests
    //{
    //    [TestMethod]
    //    public void TestSuccessfulRegistration()
    //    {
    //        // Arrange
    //        var regInPage = new RegIn();
    //        regInPage.TxbLogin.Text = "testUser";
    //        regInPage.TxbEmail.Text = "test@example.com";
    //        regInPage.TxbNumber.Text = "123456789";
    //        regInPage.TxbPassword.Password = "password123";
    //        regInPage.TxbRePassword.Password = "password123";

    //        // Act
    //        regInPage.RegInBtn_Click(null, null);

    //        // Assert
    //        var users = AppData.db.Users.ToList();
    //        var newUser = users.LastOrDefault();
    //        Assert.IsNotNull(newUser);
    //        Assert.AreEqual("testUser", newUser.Login);
    //        Assert.AreEqual("test@example.com", newUser.Email);
    //        Assert.AreEqual(123456789, newUser.PhoneNumber);
    //        Assert.AreEqual("password123", newUser.Password);
    //        Assert.AreEqual(3, newUser.IdRole);
    //        Assert.IsTrue(regInPage.NavigationService.Content is Login);
         
    //    }

    //    [TestMethod]
    //    public void TestEmptyFields()
    //    {
    //        // Arrange
    //        var regInPage = new RegIn();

    //        // Act
    //        regInPage.RegInBtn_Click(null, null);

    //        // Assert
    //        Assert.IsTrue(MessageBox.SimulatedMessages.Contains("Ошибка, некоторые поля пустые"));
    //    }
    //}
}
