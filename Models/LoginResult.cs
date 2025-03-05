namespace Finzo.Models
{
    public class LoginResult
    {        
            public bool Success { get; set; }
            public LoginStatus Status { get; set; }

            public LoginResult(bool success,  LoginStatus status)
            {
                Success = success;
                Status = status;
            }
        
    }
}
