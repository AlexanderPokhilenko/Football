using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Abstract;
using BLL.Implementation;
using DAL.Abstract.Repositories;
using DAL.Implementation;
using DAL.Implementation.Repositories;

namespace Football
{
    public static class IoC
    {
        private static readonly IDictionary<Type, Type> Registered;

        static IoC()
        {
            Registered = new Dictionary<Type, Type>();
            //TODO: переместить в Startup
            IoC.Register<ApplicationContext>();
            //репозитории:
            IoC.Register<ICountryRepository, CountryRepository>();
            IoC.Register<IStageRepository, StageRepository>();
            IoC.Register<IStageTypeRepository, StageTypeRepository>();
            IoC.Register<ITeamRepository, TeamRepository>();
            IoC.Register<ITournamentRepository, TournamentRepository>();
            //сервисы:
            IoC.Register<ITeamService, TeamService>();
            IoC.Register<ITournamentService, TournamentService>();
        }

        public static void Register<TType, TConcrete>() where TConcrete : class, TType
        {
            Registered[typeof(TType)] = typeof(TConcrete);
        }

        public static void Register<TType>() where TType : class
        {
            Register<TType, TType>();
        }

        public static TTypeToResolve Resolve<TTypeToResolve>()
        {
            return (TTypeToResolve)Resolve(typeof(TTypeToResolve));
        }

        public static object Resolve(Type type)
        {
            if (!Registered.TryGetValue(type, out var registeredType))
            {
                throw new ArgumentOutOfRangeException($"The type {type.Name} has not been registered.");
            }
            return GetInstance(registeredType);
        }

        private static object GetInstance(Type type)
        {
            var parameters = ResolveCtorParams(type);
            return Activator.CreateInstance(type, parameters.ToArray());
        }

        private static IEnumerable<object> ResolveCtorParams(Type type)
        {
            var constructorInfo = type.GetConstructors().First();
            return constructorInfo.GetParameters().Select(parameter => Resolve(parameter.ParameterType));
        }
    }
}