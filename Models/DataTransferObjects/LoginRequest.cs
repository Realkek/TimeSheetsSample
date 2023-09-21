﻿namespace TImeSheetsSample.Models.DataTransferObjects
{
    /// <summary> Запрос аутентификации пользователя по логину и паролю </summary>
    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}