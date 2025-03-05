namespace Finzo.Models
{
    public class Result
    {
        public bool Success { get; }
        public string Message { get; }       


        public Result(bool sucesso, string mensagem, LoginStatus status)
        {
            Success = sucesso;
            Message = mensagem;
        
        }
    }
}
