public static class MensagemFactory
{
    public static IServicoMensagem CriarServico(string tipoServico)
    {
        switch (tipoServico.ToLower())
        {
            case "email":
                return new EmailService();
            case "push":
                return new PushService();
            case "sms":
                return new SmsService();
            default:
                throw new ArgumentException("Tipo de serviço de mensagem inválido.");
        }
    }
}