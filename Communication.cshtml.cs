using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCommunicationRazor.Pages
{
    public class CommunicationModel : PageModel
    {
        [BindProperty]
        public string ReceivedMessage { get; set; }

        [BindProperty]
        public string SendMessage { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostSendMessage([FromBody] MessageModel messageModel)
        {
            // Hier können Sie die zu sendende Nachricht verarbeiten.
            string messageToSend = messageModel.Message;
            SendMessage = "Nachricht gesendet: " + messageToSend;
            return new JsonResult(SendMessage);
        }
    }

    public class MessageModel
    {
        public string Message { get; set; }
    }
}
