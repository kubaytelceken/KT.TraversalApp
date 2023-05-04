using KT.Traversal.Business.Abstract;
using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.Container
{
    public static class DependencyExtensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            //Comment Scoped
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentRepository, EfCommentRepository>();
            //Destination Scoped
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationRepository, EfDestinationRepository>();
            //AppUser Scoped
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserRepository, EfAppUserRepository>();

            //Reservation Scoped
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationRepository, EfReservationRepository>();

            //Guide Scoped
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideRepository, EfGuideRepository>();
        }
    }
}
