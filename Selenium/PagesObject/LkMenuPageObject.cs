using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.PagesObject;

public class LkPageMenuObject
{
    private IWebDriver _driver;
    
    private readonly By iputSecondName = By.XPath("//input[@data-ui='lastname']]"); // поле для ввода Фамилии
    private readonly By inputFistName = By.XPath("//input[@data-ui='name']]"); // поле для ввода Имени
    private readonly By inputMidleName = By.XPath("//input[@data-ui='patronymic']]"); // поле для ввода Отчества
    private readonly By inputPhone = By.XPath("//input[@value='savchukpa@icloud.com'][@readonly]"); // поле с емйл (только для чтения)
    private readonly By buttonEditProfile = By.XPath("//a[@class='btn_edit_profile itemMenu']"); // кнопка редактирования профиля
    private readonly By buttonChangePassword = By.XPath("//button[@data-ui='updatePassword']"); // кнопка изменения пароля
    private readonly By buttonSaveForm = By.XPath("//button[@data-ui='formBtn']"); // кнопка сохрания формы с введенными данными
    private readonly By buttonAddMyAdress = By.XPath("//button[@data-ui='formBtn']"); // кнопка добавить "Мои адреса"
    private readonly By buttonExit = By.XPath("//a[@class='btnExit']"); // кнопка выхода с профиля
    private readonly By buttonDeleteUserProfile = By.Id("deleteProfile"); // кнопка удаления профиля
    private readonly By notificationContent = By.XPath("//div[@class='new_client_notification_content']"); // информационный блок в вверху страници
    private readonly By logo = By.XPath("//div[@class='logo']"); // логотип (левый верхний угол страницы)
    private readonly By textNameService = By.XPath("//div[@class='logo']"); // имя сервиса "Открытая Казань"
    private readonly By textInfoHellper = By.XPath("//div[@class='small']"); // описание предназначения сервиса (расположено под именем сервиса) 
    private readonly By activeUserEmail = By.XPath("//div[@class='username active']"); // емейл пользователя
    private readonly By imageSelectOtpionLine = By.XPath("//i[@class='icon-building']"); // картинка строки выбора
    private readonly By selectOtpionLine = By.XPath("//div[@class='selectLine']"); // строка выбора
}