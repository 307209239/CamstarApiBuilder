using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camstar.Api.Builder
{
    public class Runner
    {
        public CompleteInformation Generate()
        {
            try
            {
                string str1 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Camstar\\Camstar InSite Admin\\Path", (string)null, (object)string.Empty) as string;
                if (string.IsNullOrEmpty(str1))
                    str1 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Admin\\Path", (string)null, (object)string.Empty) as string;
                string str2 = !string.IsNullOrEmpty(str1) ? str1 + "\\\\WCFServicesGenerator" : System.Environment.CurrentDirectory;
                System.Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                if (this._Settings.IsGenerateAll)
                {
                    this._RootService = new Camstar.Api.Generator.Helper.ServiceBase(1080, "Service", "Base service for all services.");
                    this._Settings.ApplyForAllToServices((IService)this._RootService);
                }
                this.GenerationProcess();
                System.Environment.CurrentDirectory = str2;
                this._GeneratorState = GeneratorStateType.Finished;
                return this._CompleteInformation;
            }
            catch (Exception ex)
            {
                this._CompleteInformation = new CompleteInformation(new WCFGeneratorException(ex));
                this._GeneratorState = GeneratorStateType.Error;
                return this._CompleteInformation;
            }
        }
    }
}
