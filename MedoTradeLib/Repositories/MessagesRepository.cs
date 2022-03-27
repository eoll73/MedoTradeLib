using MedoTradeLib.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedoTradeLib.Repositories
{
    public class MessagesRepository
    {
        private readonly IConfiguration _configuration;
        private readonly LibDbContext context;

        public MessagesRepository(IConfiguration configuration, LibDbContext context)
        {
            _configuration = configuration;
            this.context = context;
        }

        public List<Messages> GetAllMessages()
        {
            var messages = context.Messages.ToList();
            return messages;
        }

        public void Add(Messages messages)
        {
            context.Messages.Add(messages);
            context.SaveChanges();
        }

        public void Update(Messages messages)
        {
            context.Messages.Update(messages);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var message = context.Messages.FirstOrDefault(x => x.Id == id);

            context.Messages.Remove(message);
            context.SaveChanges();
        }

        public Messages Get(int id)
        {
            return (context.Messages.FirstOrDefault(x => x.Id == id));
        }
    }
}
