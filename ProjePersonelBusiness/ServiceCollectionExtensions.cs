using Microsoft.Extensions.DependencyInjection;
using ProjePersonelBusiness.Abstract;
using ProjePersonelBusiness.Concrete;
using ProjePersonelDataAccess.Abstract;
using ProjePersonelDataAccess.Concrete;
using ProjePersonelDataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness
{
    public static class ServiceCollectionExtensions
    {


        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ProjePersonelContext>();
   
            serviceCollection.AddTransient<IDepartmanService, DepartmanManager>();
            serviceCollection.AddTransient<IPersonnelService, PersonnelManager>();
            serviceCollection.AddTransient<IPersonnelAddressService, PersonnelAddressManager>();
            serviceCollection.AddTransient<IPersonnelPhoneNumberService, PhoneNumberManager>();
            serviceCollection.AddTransient<IMissionService, MissionManager>();
            serviceCollection.AddTransient<IGenderService, GenderManager>();




            serviceCollection.AddScoped<IMissionRepository, EfMissionRepository>();
            serviceCollection.AddScoped<IPersonnelRepository, EfPersonnelRepository>();
            serviceCollection.AddScoped<IPersonnelNumberRepository, EfPersonnelPhoneNumberRepository>();
            serviceCollection.AddScoped<IPersonnelAddressRepository, EfPersonnelAddressRepository>();
            serviceCollection.AddScoped<IDepartmanRepsitory, EfDepartmanRepository>();
            serviceCollection.AddScoped<IGenderRepository, EfGenderRepository>();



            return serviceCollection;

        }
    }
}
