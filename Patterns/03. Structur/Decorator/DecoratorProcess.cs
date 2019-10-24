using Patterns._03._Structur.Decorator.Models;
using Patterns.Interfaces;

namespace Patterns._03._Structur.Decorator
{
    public class DecoratorProcess : IExampleService
    {
        #region Public Methods

        public void StartExample()
        {
            var packageSender = new PackageSender("Lermontov st.", "Lermontov");
            var mailSender = new MailSender("Pushkin st.", "Pushkin");
            var postDecorator = new PostProcessingSenderDecorator(packageSender);

            packageSender.Send();
            mailSender.Send();
            postDecorator.Process();
            postDecorator.Send();
        }

        #endregion Public Methods
    }
}