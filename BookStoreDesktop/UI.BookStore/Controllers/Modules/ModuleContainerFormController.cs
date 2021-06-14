using Businness.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UI.BookStore.Forms;

namespace UI.BookStore.Controllers.Modules
{
    public class ModuleContainerFormController
    {
        readonly FormModuleContainer _form;
        readonly string _name;
         ModuleEntities _module;
        public ModuleContainerFormController(FormModuleContainer form,object o)
        {
            _form = form;
            Type type = o.GetType();
            _name = type.Name;
            _form.lbNameDatas.Text = _name;
        }


        public void ChargeModule(ModuleEntities module)
        {
            _module = module;
            switch (_module)
            {
                case ModuleEntities.Coupons:
                    break;
                case ModuleEntities.Employees:
                    break;
                case ModuleEntities.Orders:
                    break;
                case ModuleEntities.Permits:
                    break;
                case ModuleEntities.Providers:
                    break;
                case ModuleEntities.Purchases:
                    break;
                case ModuleEntities.Sales:
                    break;
                case ModuleEntities.Socies:
                    break;
                case ModuleEntities.WareHouse:
                    break;
                default:
                    break;   
            }
        }
    }
}
