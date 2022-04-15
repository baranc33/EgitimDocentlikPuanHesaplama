using Core;
using Core.Repositories;
using Core.Serviecs;
using Repository;
using Repository.Repositories;
using Service.Services;

namespace WebMvc.Helpers.Extensions.IServiceCollectionExtensions
{
    static public class AddScopedExtension
    {
        public static IServiceCollection AddScopedExtens(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));



            services.AddScoped<IMyUserService, MyUserService>();
            services.AddScoped<IMyRoleService, MyRoleService>();
            services.AddScoped<IEgitimEntityService, EgitimEntityService>();
            services.AddScoped<IFenEntityService, FenEntityService>();
            services.AddScoped<IFilolojiEntityService, FilolojiEntityService>();
            services.AddScoped<IGuzelSanatlarEntityService, GuzelSanatlarEntityService>();
            services.AddScoped<IHukukEntityService, HukukEntityService>();
            services.AddScoped<IIlahiyatEntityService, ilahiyatEntityService>();
            services.AddScoped<IMimarlikEntityService, MimarlikEntityService>();
            services.AddScoped<IMuhendislikEntityService, MuhendislikEntityService>();
            services.AddScoped<ISaglikEntityService, SaglikEntityService>();
            services.AddScoped<ISosyalEntityService, SosyalEntityService>();
            services.AddScoped<ISporEntityService, SporEntityService>();
            services.AddScoped<IZiraatEntityService, ZiraatEntityService>();
            services.AddScoped<IAdminMemberService, AdminMemberService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IMyContactService, MyContactService>();





            services.AddScoped<IEgitimEntityRepository, EgitimEntityRepository>();
            services.AddScoped<IFenEntityRepository, FenEntityRepository>();
            services.AddScoped<IGuzelSanatlarEntityRepository, GuzelSanatlarEntityRepository>();
            services.AddScoped<IFilolojiEntityRepository, FilolojiEntityRepository>();
            services.AddScoped<IHukukEntityRepository, HukukEntityRepository>();
            services.AddScoped<IilahiyatEntityRepository, ilahiyatEntityRepository>();
            services.AddScoped<IMimarlikEntityRepository, MimarlikEntityRepository>();
            services.AddScoped<IMuhendislikEntityRepository, MuhendislikEntityRepository>();
            services.AddScoped<ISaglikEntityRepository, SaglikEntityRepository>();
            services.AddScoped<ISosyalEntityRepository, SosyalEntityRepository>();
            services.AddScoped<ISporEntityRepository, SporEntityRepository>();
            services.AddScoped<IZiraatEntityRepository, ZiraatEntityRepository>();
            services.AddScoped<IAdminMemberRepository, AdminMemberRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IMyContactRepository, MyContactRepository>();






            return services;
        }
    }
}
