using BookReadingApp.Application.Interfaces;

using FacadePattern.FacadeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using BookReadingApp.Core.Modals;

namespace FacadePattern.FacadeDP
{
    public class FacadeInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            // Perform interception logic before the method call
            Console.WriteLine($"Intercepting method: {invocation.Method.Name}");

            try
            {
                invocation.Proceed(); // Call the original method

                // Perform interception logic after the method call
                Console.WriteLine($"Method {invocation.Method.Name} executed successfully");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the method execution
                Console.WriteLine($"An exception occurred in method {invocation.Method.Name}: {ex.Message}");
                throw;
            }
        }
    }

    public class Facade : IFacade
    {
        private readonly ICommentFacade commentFacade;
        private readonly IEventFacade eventFacade;

        private readonly ICommentRepository _commentRepo;
        private readonly IEventRepository _eventRepo;

        public Facade(ICommentRepository commentRepo, IEventRepository eventRepo)
        {
            _eventRepo = eventRepo;
            _commentRepo = commentRepo;

            commentFacade = new CommentFacade(_commentRepo);
            eventFacade = new EventFacade(_eventRepo);

            // Create the interceptor instance
            var interceptor = new FacadeInterceptor();

            // Apply the interceptor to the eventFacade instance
            var eventFacadeProxy = new ProxyGenerator().CreateInterfaceProxyWithTarget(eventFacade, interceptor);

            // Replace the original eventFacade with the proxied instance
            eventFacade = eventFacadeProxy;
        }

        public async Task<int> CreateEvent(Event eventModel)
        {
            var result = await eventFacade.CreateEvent(eventModel);
            return result;
        }

        public async Task<IList<Comment>> GetAllCommentByEventId(int eventId)
        {
            var result = await eventFacade.GetAllCommentByEventId(eventId);
            return result;
        }

        public async Task<IList<Comment>> GetComments()
        {
            var result = await commentFacade.GetComments();
            return result;
        }

        public async Task<IList<Event>> GetEvents()
        {
            var result = await eventFacade.GetEvents();
            return result;
        }

        public async Task<IList<Event>> MyEvents(string organiser)
        {
            var result = await eventFacade.MyEvents(organiser);
            return result;
        }

        public async Task<int> PostComment(Comment response)
        {
            var result = await commentFacade.PostComment(response);
            return result;
        }

        public int UpdateEvent(Event eventModel)
        {
            var result = eventFacade.UpdateEvent(eventModel);
            return result;
        }

        public async Task<Comment> ViewComment(int commentId)
        {
            var result = await commentFacade.ViewComment(commentId);
            return result;
        }

        public async Task<Event> ViewDetails(int eventId)
        {
            var result = await eventFacade.ViewDetails(eventId);
            return result;
        }
    }
}
