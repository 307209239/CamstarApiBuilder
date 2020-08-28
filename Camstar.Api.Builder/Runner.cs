using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Camstar.Api.Builder
{
    public class Runner
    {
        public CompleteInformation Generate()
        {
            try
            {
                if (this._Settings.IsGenerateAll)
                {
                    this._RootService =
                        new Api.Generator.Helper.ServiceBase(1080, "Service", "Base service for all services.");
                    this._Settings.ApplyForAllToServices((IService) this._RootService);
                }

                GenerationProcess();
                Environment.CurrentDirectory = str2;
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

        private void GenerationProcess()
        {
            this._StartTime = DateTime.Now;
            this._GeneratedServicesCount = 0;
            this.CollectInformation();
            CreateDirectories();
            this._dcTypes = this._TypeChache.GetSortedDCTypes();
            var task1 = Task.Factory.StartNew(GenerateServices);
            var task2 = Task.Factory.StartNew(this.GenerateClient);
            var assemblyName1 = new AssemblyName("Camstar.WCFSilverlightService");
            if (this._Settings.IsGenerateSilverlight)
            {
                DCTypeStore dCTypeStore = new DCTypeStore();
                new AssemblyGenerator(
                    DefineDynamicAssembly(assemblyName1, this._Settings.ClientOutputDirectory,
                            typeof(Camstar.WCF.Service.ServiceBase).Assembly.GetName().Version.ToString())
                        .DefineDynamicModule(assemblyName1.Name + Constants.File.DllFileExt,
                            assemblyName1.Name + Constants.File.DllFileExt, false), dCTypeStore, "Camstar.WCF.Service",
                    typeof(Camstar.WCF.Service.ServiceBase).Assembly, "Camstar.WCF.Service").GenerateCommonTypes();
            }

            var assemblyName2 = new AssemblyName("Camstar.WCFSilverlightClient");
            var now = DateTime.Now;
            var generationTime = TimeSpan.MinValue;
            var num = 0;
            var disassembleProcess = (Process) null;
            List<DCType> dcTypeList = new List<DCType>();
            if (this._Settings.IsGenerateSilverlight)
            {
                this.CollectSilverlightInformation();
                DCTypeStore dCTypeStore = new DCTypeStore();
                var assemblyBuilder = DefineDynamicAssembly(assemblyName2,
                    this._Settings.ClientSilverlightOutputDirectory,
                    typeof(WCFServiceBase).Assembly.GetName().Version.ToString());
                var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName2.Name + Constants.File.DllFileExt,
                    assemblyName2.Name + Constants.File.DllFileExt, false);
                var assemblyGenerator = new AssemblyGenerator(moduleBuilder, dCTypeStore,
                    "Camstar.WCF.ObjectStack", typeof(WCFServiceBase).Assembly, "Camstar.WCF.Services");
                assemblyGenerator.GenerateCommonTypes();
                ClientGenerator clientGenerator = new ClientGenerator(moduleBuilder, dCTypeStore,
                    "Camstar.WCF.Services", "Camstar.WCF.Services", true);
                dcTypeList = this._TypeSilverlightChache.GetSortedDCTypes();
                foreach (DCType dCType in dcTypeList)
                    assemblyGenerator.AddDC(dCType);
                for (var current = 0; current < dcTypeList.Count; ++current)
                {
                    this.OnStateChanged(GeneratingPhase.SilverlightDataContract, current, dcTypeList.Count,
                        dcTypeList[current].Name);
                    clientGenerator.AddDC(dcTypeList[current]);
                }

                for (var current = 0; current < this._ExposedSilverlightServices.Count; ++current)
                {
                    this.OnStateChanged(GeneratingPhase.SilverlightServiceContract, current,
                        this._ExposedSilverlightServices.Count, this._ExposedSilverlightServices[current].Name);
                    clientGenerator.AddService(this._ExposedSilverlightServices[current]);
                    if (this._ExposedSilverlightServices[current].ExposedState != ExposedServiceStateType.Base)
                        ++num;
                }

                assemblyBuilder.Save(assemblyName2.Name + Constants.File.DllFileExt);
                disassembleProcess = this.Disassemble(this._Settings.ClientSilverlightOutputDirectory + "\\",
                    assemblyName2.Name);
                generationTime = DateTime.Now - now;
            }

            Task.WaitAll(task1, task2);
            this.WriteServicesConfiguration();
            this.WriteClientConfiguration();
            if (this._Settings.IsGenerateSilverlight)
                this.AssembleSilverlight(disassembleProcess, this._Settings.ClientSilverlightOutputDirectory + "\\",
                    assemblyName2.Name);
            this.DisperseFiles();
            this._CompleteInformation = new CompleteInformation(this._dcTypes.Count, this._GeneratedServicesCount + 3,
                DateTime.Now - this._StartTime);
            if (!this._Settings.IsGenerateSilverlight)
                return;
            this._CompleteInformation.SilverlightCompleteInformation =
                new CompleteInformation(dcTypeList.Count, num + 3, generationTime);
        }

        private void CreateDirectories()
        {
            if (!Directory.Exists("ApiBin")) Directory.CreateDirectory("ApiBin");
        }

        private void GenerateServices()
        {
            var assemblyName = new AssemblyName("Camstar.ApiService");
            DCTypeStore dCTypeStore = new DCTypeStore();
            var assemblyBuilder =
                DefineDynamicAssembly(assemblyName, "ApiBin", "1.0.0.0");
            var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name + Constants.File.DllFileExt,
                assemblyName.Name + Constants.File.DllFileExt, false);
            var assemblyGenerator = new AssemblyGenerator(moduleBuilder, dCTypeStore,
                "Camstar.WCF.Service", typeof(Camstar.WCF.Service.ServiceBase).Assembly, "Camstar.WCF.Service");
            assemblyGenerator.GenerateCommonTypes();
            ServiceGenerator serviceGenerator = new ServiceGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.Service");
            foreach (DCType dcType in this._dcTypes)
                assemblyGenerator.AddDC(dcType);
            for (var current = 0; current < this._dcTypes.Count; ++current)
            {
                this.OnStateChanged(GeneratingPhase.DataContract, current, this._dcTypes.Count,
                    this._dcTypes[current].Name);
                serviceGenerator.AddDC(this._dcTypes[current]);
            }

            for (var current = 0; current < this._ExposedServices.Count; ++current)
            {
                this.OnStateChanged(GeneratingPhase.ServiceContract, current, this._ExposedServices.Count,
                    this._ExposedServices[current].Name);
                serviceGenerator.AddService(this._ExposedServices[current]);
                if (this._ExposedServices[current].ExposedState != ExposedServiceStateType.Base)
                    ++this._GeneratedServicesCount;
            }

            assemblyBuilder.Save(assemblyName.Name + Constants.File.DllFileExt);
        }

        private AssemblyBuilder DefineDynamicAssembly(
            AssemblyName assemblyName,
            string path,
            string version)
        {
            assemblyName.Version = new Version(version);
            var assemblyBuilder =
                AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save, path);
            var customBuilder1 = new CustomAttributeBuilder(typeof(AssemblyTitleAttribute).GetConstructor(new Type[1]
            {
                typeof(string)
            }), new object[1] {"WebApi Generated Assembly"});
            assemblyBuilder.SetCustomAttribute(customBuilder1);
            var customBuilder2 = new CustomAttributeBuilder(typeof(AssemblyDescriptionAttribute).GetConstructor(
                new Type[1]
                {
                    typeof(string)
                }), new object[1]
            {
                assemblyName.Name + " Library"
            });
            assemblyBuilder.SetCustomAttribute(customBuilder2);
            assemblyBuilder.DefineVersionInfoResource("Camstar Enterprise Platform", version,
                "Siemens Product Lifecycle Management Software Inc.",
                "© 2017 Siemens Product Lifecycle Management Software Inc.", string.Empty);
            var customBuilder3 = new CustomAttributeBuilder(typeof(DebuggableAttribute).GetConstructor(new Type[1]
            {
                typeof(DebuggableAttribute.DebuggingModes)
            }), new object[1]
            {
                DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations
            });
            assemblyBuilder.SetCustomAttribute(customBuilder3);
            return assemblyBuilder;
        }
    }
}