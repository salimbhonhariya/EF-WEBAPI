using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    public interface IHookService 
    {

        List<Hook> GetHooks();
        Hook GetHook(int id);
        bool Add(Hook hook);
        bool UpdateHook(Hook hook);
        bool DeleteHook(int id);
    }
}
