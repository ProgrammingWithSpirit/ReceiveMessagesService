using System;
using System.Threading.Tasks;
using MassTransit;
using SendMessagesApi;

namespace ReceiveMessagesService
{
    public class BookConsumer : IConsumer<Book>
    {
        public Task Consume(ConsumeContext<Book> context)
        {
            var value = $"Received: book {context.Message.Title} with {context.Message.PagesCount} pages written on {context.Message.Date}";
            return Task.CompletedTask;
        }
    }
}