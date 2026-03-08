namespace PruebaECOP.Models.Responses
{
    public class LoginResponse
    {
        public UsuarioResponse Usuario { get; set; }
        public string AccessToken { get; set; }
        public TokenType TokenType { get; set; }
        public int ExpiresIn { get; set; }
    }
}