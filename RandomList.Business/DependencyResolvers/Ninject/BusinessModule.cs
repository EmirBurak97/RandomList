using Ninject.Modules;
using RandomList.Business.Abstract;
using RandomList.Business.Concrete;
using RandomList.DataAccess.Abstract;
using RandomList.DataAccess.Concrete.EntityFramewoek;
using RandomList.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILolService>().To<LolManager>().InSingletonScope();
            Bind<ILolDal>().To<EfLolDal>().InSingletonScope();

            Bind<IValoService>().To<ValoManager>().InSingletonScope();
            Bind<IValoDal>().To<EfValoDal>().InSingletonScope();

            Bind<IMusicService>().To<MusicManager>().InSingletonScope();
            Bind<IMusicDal>().To<EfMusicDal>().InSingletonScope();

            Bind<ITrackService>().To<TrackManager>().InSingletonScope();
            Bind<ITrackDal>().To<EfTrackDal>().InSingletonScope();

            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDal>().To<EfCarDal>().InSingletonScope();
        }
    }
}
