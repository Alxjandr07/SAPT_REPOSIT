using System;
using System.Net;
using System.Net.Mail;

public static class EmailHelper
{
    public static bool EnviarCorreoSolicitudCambio()
    {
        try
        {
            var fromAddress = new MailAddress("tucorreo@gmail.com", "Sistema Titulaci�n");
            var toAddress = new MailAddress("0999595561kevin@gmail.com");
            const string fromPassword = "lutuszqdxflrwoky"; // tu contrase�a de aplicaci�n sin espacios
            const string subject = "Solicitud de cambio de contrase�a";
            string body = "Se ha solicitado un cambio de contrase�a para un usuario desde el sistema de titulaci�n.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            return true;
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Error al enviar el correo: " + ex.Message);
            return false;
        }
    }
}