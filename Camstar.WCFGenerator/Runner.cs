// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Runner
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using Camstar.WCF.Generator.ObjectModel;
using Camstar.WCF.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Xml;

namespace Camstar.WCF.Generator
{
  public class Runner
  {
    private readonly TimeSpan ServiceTimeout = TimeSpan.FromMinutes(14.0);
    private CompleteInformation _CompleteInformation = new CompleteInformation(0, 0, TimeSpan.MinValue);
    private static HashSet<string> WebBehaviorServices = new HashSet<string>((IEnumerable<string>) new string[14]
    {
      "Label",
      "Query",
      "NamedDataObjectMaint",
      "ActionCategoryMaint",
      "ActionMaint",
      "ActionRuleMaint",
      "PortalMenuDefinitionMaint",
      "PortalTabMaint",
      "ReportTemplateMaint",
      "UIPageFlowMaint",
      "UIVirtualPageMaint",
      "UIPersonalizationMaint",
      "WebPartMaint",
      "DirectAccess"
    });
    protected GeneratorSettings _Settings;
    private const int MaxItemsInObjectGraph = 2147483647;
    private const int MaxReceivedMessageSize = 2147483647;
    private const string collectInformationMessage = "Collecting information";
    private const string lightcollectInformationMessage = "Collecting Silverlight information";
    private const string dataContractMessage = "Generating data contracts";
    private const string lightdataContractMessage = "Generating Silverlight data contracts";
    private const string serviceContractMessage = "Generating service contracts";
    private const string ServiceNamespace = "Camstar.WCF.Service";
    private const string ClientNamespace = "Camstar.WCF.Services";
    private const string ObjectStackNamespace = "Camstar.WCF.ObjectStack";
    private const string BindingConfigurationName = "DefaultBinding";
    private const string BindingConfigurationNameSSL = "DefaultBindingSSL";
    private const string BehaviorConfigurationName = "MetaDataBehavior";
    private const string EndpointBehaviorConfigName = "webBehavior";
    private const string BehaviorName = "DefaultBehavior";
    private const string BehaviorNameSSL = "DefaultBehaviorSSL";
    private Camstar.WCF.Generator.Helper.ServiceBase _RootService;
    private Camstar.WCF.Generator.Helper.ServiceBase _RootSilverlightService;
    private Thread _GenerateThread;
    private GeneratorStateType _GeneratorState;
    private List<Camstar.WCF.Generator.Helper.ServiceBase> _ExposedServices;
    private List<Camstar.WCF.Generator.Helper.ServiceBase> _ExposedSilverlightServices;
    private DCTypeCache _TypeChache;
    private DCTypeCache _TypeSilverlightChache;
    private DateTime _StartTime;
    private int _GeneratedServicesCount;
    private List<DCType> _dcTypes;
    private const string REGISTRY_KEY = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Camstar\\Camstar InSite Admin\\Path";
    private const string REGISTRY_KEY_64 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Admin\\Path";

    public GeneratorStateType GeneratorState
    {
      get
      {
        return this._GeneratorState;
      }
    }

    public CompleteInformation CompleteInformation
    {
      get
      {
        return this._CompleteInformation;
      }
    }

    public event StateChangeEventHandler StateChanged;

    public event GeneratingCompletedEventHandler GeneratingCompleted;

    public Runner()
      : this(new GeneratorSettings())
    {
    }

    public Runner(string path)
      : this(new GeneratorSettings(path))
    {
    }

    public Runner(GeneratorSettings settings)
    {
      if (settings == null)
        settings = new GeneratorSettings();
      this._Settings = settings;
    }

    public void Init()
    {
      try
      {
        RequestorBase.ConnectionString = this._Settings.DatabaseConnectionString;
        RequestorBase.IsGetFromRegistry = this._Settings.IsGetFromRegistry;
        RequestorBase.ConnectionString = this._Settings.DatabaseConnectionString;
        this._RootService = new Camstar.WCF.Generator.Helper.ServiceBase(1080, "Service", "Base service for all services.");
        this._RootSilverlightService = new Camstar.WCF.Generator.Helper.ServiceBase(1080, "Service", "Base service for all services.");
        if (this._Settings.IsGenerateAll)
          this._Settings.ApplyForAllToServices((IService) this._RootService, false);
        else
          this._Settings.ApplyToServices((IService) this._RootService);
        if (this._Settings.IsGenerateSilverlight)
          this._Settings.ApplyToSilverlightServices((IService) this._RootSilverlightService);
        this._GeneratorState = GeneratorStateType.Initialized;
      }
      catch (WCFGeneratorException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        throw new WCFGeneratorException(ex);
      }
    }

    public void BeginGenerate()
    {
      if (this._GeneratorState == GeneratorStateType.InProgress)
        throw new WCFGeneratorException("Generation process is being already started.");
      this._GenerateThread = new Thread(new ThreadStart(this.GenerateInThread));
      this._GenerateThread.IsBackground = true;
      this._GenerateThread.Start();
    }

    public void StopGenerate()
    {
      if (this._GeneratorState != GeneratorStateType.InProgress)
        throw new WCFGeneratorException("Generation process wasn't started.");
      this._GenerateThread.Abort();
      this._GenerateThread.Join();
      this._GeneratorState = GeneratorStateType.Aborted;
    }

    public CompleteInformation Generate()
    {
      try
      {
        string str1 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Camstar\\Camstar InSite Admin\\Path", (string) null, (object) string.Empty) as string;
        if (string.IsNullOrEmpty(str1))
          str1 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Admin\\Path", (string) null, (object) string.Empty) as string;
        string str2 = !string.IsNullOrEmpty(str1) ? str1 + "\\\\WCFServicesGenerator" : System.Environment.CurrentDirectory;
        System.Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        if (this._Settings.IsGenerateAll)
        {
          this._RootService = new Camstar.WCF.Generator.Helper.ServiceBase(1080, "Service", "Base service for all services.");
          this._Settings.ApplyForAllToServices((IService) this._RootService);
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

    public IService GetRootService()
    {
      return (IService) this._RootService;
    }

    public IService GetRootSilverlightService()
    {
      return (IService) this._RootSilverlightService;
    }

    private void GenerateInThread()
    {
      this._GeneratorState = GeneratorStateType.InProgress;
      this.Generate();
      this.OccurEvent((MulticastDelegate) this.GeneratingCompleted, (EventArgs) new GeneratingCompletedEventArgs(this._CompleteInformation));
    }

    private void CollectInformation()
    {
      this._ExposedServices = this._RootService.GetExposedChildren();
      this._TypeChache = new DCTypeCache();
      for (int current = 0; current < this._ExposedServices.Count; ++current)
      {
        this.OnStateChanged(GeneratingPhase.CollectInformation, current, this._ExposedServices.Count, this._ExposedServices[current].Name);
        this._TypeChache.AddDCType(this._ExposedServices[current].DCType);
      }
    }

    private void CollectSilverlightInformation()
    {
      this._ExposedSilverlightServices = this._RootSilverlightService.GetExposedChildren();
      this._TypeSilverlightChache = new DCTypeCache();
      for (int current = 0; current < this._ExposedSilverlightServices.Count; ++current)
      {
        this.OnStateChanged(GeneratingPhase.CollectSilverlightInformation, current, this._ExposedSilverlightServices.Count, this._ExposedSilverlightServices[current].Name);
        this._TypeSilverlightChache.AddDCType(this._ExposedSilverlightServices[current].DCType);
      }
    }

    private void OnStateChanged(
      GeneratingPhase phase,
      int current,
      int count,
      string processItemName)
    {
      string phaseMessage = this.GetPhaseMessage(phase);
      int percent = 0;
      int totalPercent = 0;
      TimeSpan timeRemaining = new TimeSpan(0, 5, 0);
      if (count != 0)
      {
        percent = (current + 1) * 100 / count;
        totalPercent = ((int) phase * 100 + percent) / 6;
        TimeSpan timeSpan = DateTime.Now - this._StartTime;
        if (totalPercent != 0)
          timeRemaining = TimeSpan.FromSeconds((double) ((int) timeSpan.TotalSeconds * 100 / totalPercent - (int) timeSpan.TotalSeconds));
      }
      this.OccurEvent((MulticastDelegate) this.StateChanged, (EventArgs) new StateChangeEventArgs(this._GeneratorState, totalPercent, percent, phaseMessage, processItemName, timeRemaining));
    }

    private void OccurEvent(MulticastDelegate handler, EventArgs args)
    {
      if ((object) handler == null)
        return;
      foreach (MulticastDelegate invocation in handler.GetInvocationList())
      {
        if (invocation.Target is ISynchronizeInvoke target && target.InvokeRequired)
          target.Invoke((Delegate) invocation, new object[2]
          {
            (object) this,
            (object) args
          });
        else
          invocation.DynamicInvoke((object) args);
      }
    }

    private void GenerationProcess()
    {
      this._StartTime = DateTime.Now;
      this._GeneratedServicesCount = 0;
      this.CollectInformation();
      this.CreateDirectories();
      this._dcTypes = this._TypeChache.GetSortedDCTypes();
      Task task1 = Task.Factory.StartNew(new System.Action(this.GenerateServices));
      Task task2 = Task.Factory.StartNew(new System.Action(this.GenerateClient));
      AssemblyName assemblyName1 = new AssemblyName("Camstar.WCFSilverlightService");
      if (this._Settings.IsGenerateSilverlight)
      {
        DCTypeStore dCTypeStore = new DCTypeStore();
        new AssemblyGenerator(this.DefineDynamicAssembly(assemblyName1, this._Settings.ClientOutputDirectory, typeof (Camstar.WCF.Service.ServiceBase).Assembly.GetName().Version.ToString()).DefineDynamicModule(assemblyName1.Name + Constants.File.DllFileExt, assemblyName1.Name + Constants.File.DllFileExt, false), dCTypeStore, "Camstar.WCF.Service", typeof (Camstar.WCF.Service.ServiceBase).Assembly, "Camstar.WCF.Service").GenerateCommonTypes();
      }
      AssemblyName assemblyName2 = new AssemblyName("Camstar.WCFSilverlightClient");
      DateTime now = DateTime.Now;
      TimeSpan generationTime = TimeSpan.MinValue;
      int num = 0;
      Process disassembleProcess = (Process) null;
      List<DCType> dcTypeList = new List<DCType>();
      if (this._Settings.IsGenerateSilverlight)
      {
        this.CollectSilverlightInformation();
        DCTypeStore dCTypeStore = new DCTypeStore();
        AssemblyBuilder assemblyBuilder = this.DefineDynamicAssembly(assemblyName2, this._Settings.ClientSilverlightOutputDirectory, typeof (WCFServiceBase).Assembly.GetName().Version.ToString());
        ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName2.Name + Constants.File.DllFileExt, assemblyName2.Name + Constants.File.DllFileExt, false);
        AssemblyGenerator assemblyGenerator = new AssemblyGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.ObjectStack", typeof (WCFServiceBase).Assembly, "Camstar.WCF.Services");
        assemblyGenerator.GenerateCommonTypes();
        ClientGenerator clientGenerator = new ClientGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.Services", "Camstar.WCF.Services", true);
        dcTypeList = this._TypeSilverlightChache.GetSortedDCTypes();
        foreach (DCType dCType in dcTypeList)
          assemblyGenerator.AddDC(dCType);
        for (int current = 0; current < dcTypeList.Count; ++current)
        {
          this.OnStateChanged(GeneratingPhase.SilverlightDataContract, current, dcTypeList.Count, dcTypeList[current].Name);
          clientGenerator.AddDC(dcTypeList[current]);
        }
        for (int current = 0; current < this._ExposedSilverlightServices.Count; ++current)
        {
          this.OnStateChanged(GeneratingPhase.SilverlightServiceContract, current, this._ExposedSilverlightServices.Count, this._ExposedSilverlightServices[current].Name);
          clientGenerator.AddService(this._ExposedSilverlightServices[current]);
          if (this._ExposedSilverlightServices[current].ExposedState != ExposedServiceStateType.Base)
            ++num;
        }
        assemblyBuilder.Save(assemblyName2.Name + Constants.File.DllFileExt);
        disassembleProcess = this.Disassemble(this._Settings.ClientSilverlightOutputDirectory + "\\", assemblyName2.Name);
        generationTime = DateTime.Now - now;
      }
      Task.WaitAll(task1, task2);
      this.WriteServicesConfiguration();
      this.WriteClientConfiguration();
      if (this._Settings.IsGenerateSilverlight)
        this.AssembleSilverlight(disassembleProcess, this._Settings.ClientSilverlightOutputDirectory + "\\", assemblyName2.Name);
      this.DisperseFiles();
      this._CompleteInformation = new CompleteInformation(this._dcTypes.Count, this._GeneratedServicesCount + 3, DateTime.Now - this._StartTime);
      if (!this._Settings.IsGenerateSilverlight)
        return;
      this._CompleteInformation.SilverlightCompleteInformation = new CompleteInformation(dcTypeList.Count, num + 3, generationTime);
    }

    private void GenerateServices()
    {
      AssemblyName assemblyName = new AssemblyName("Camstar.WCFService");
      DCTypeStore dCTypeStore = new DCTypeStore();
      AssemblyBuilder assemblyBuilder = this.DefineDynamicAssembly(assemblyName, this._Settings.ServerOutputDirectory + "\\bin", typeof (Camstar.WCF.Service.ServiceBase).Assembly.GetName().Version.ToString());
      ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name + Constants.File.DllFileExt, assemblyName.Name + Constants.File.DllFileExt, false);
      AssemblyGenerator assemblyGenerator = new AssemblyGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.Service", typeof (Camstar.WCF.Service.ServiceBase).Assembly, "Camstar.WCF.Service");
      assemblyGenerator.GenerateCommonTypes();
      ServiceGenerator serviceGenerator = new ServiceGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.Service");
      foreach (DCType dcType in this._dcTypes)
        assemblyGenerator.AddDC(dcType);
      for (int current = 0; current < this._dcTypes.Count; ++current)
      {
        this.OnStateChanged(GeneratingPhase.DataContract, current, this._dcTypes.Count, this._dcTypes[current].Name);
        serviceGenerator.AddDC(this._dcTypes[current]);
      }
      for (int current = 0; current < this._ExposedServices.Count; ++current)
      {
        this.OnStateChanged(GeneratingPhase.ServiceContract, current, this._ExposedServices.Count, this._ExposedServices[current].Name);
        serviceGenerator.AddService(this._ExposedServices[current]);
        if (this._ExposedServices[current].ExposedState != ExposedServiceStateType.Base)
          ++this._GeneratedServicesCount;
      }
      assemblyBuilder.Save(assemblyName.Name + Constants.File.DllFileExt);
    }

    private void GenerateClient()
    {
      AssemblyName assemblyName = new AssemblyName("Camstar.WCFClient");
      DCTypeStore dCTypeStore = new DCTypeStore();
      AssemblyBuilder assemblyBuilder = this.DefineDynamicAssembly(assemblyName, this._Settings.ClientOutputDirectory, typeof (WCFServiceBase).Assembly.GetName().Version.ToString());
      ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name + Constants.File.DllFileExt, assemblyName.Name + Constants.File.DllFileExt, false);
      AssemblyGenerator assemblyGenerator = new AssemblyGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.ObjectStack", typeof (WCFServiceBase).Assembly, "Camstar.WCF.Services");
      assemblyGenerator.GenerateCommonTypes();
      assemblyGenerator.GenerateWorkspaceSet();
      assemblyGenerator.GenerateSiteUserData();
      ClientGenerator clientGenerator = new ClientGenerator(moduleBuilder, dCTypeStore, "Camstar.WCF.Services", "Camstar.WCF.Services");
      foreach (DCType dcType in this._dcTypes)
        assemblyGenerator.AddDC(dcType);
      foreach (DCType dcType in this._dcTypes)
        clientGenerator.AddDC(dcType);
      foreach (Camstar.WCF.Generator.Helper.ServiceBase exposedService in this._ExposedServices)
        clientGenerator.AddService(exposedService);
      assemblyBuilder.Save(assemblyName.Name + Constants.File.DllFileExt);
    }

    private void AssembleSilverlight(Process disassembleProcess, string Path, string assemblyName)
    {
      disassembleProcess.WaitForExit();
      if (disassembleProcess.ExitCode > 0)
        throw new WCFGeneratorException("Disassembling Silverlight assembly failed");
      string str1 = System.IO.File.ReadAllText(Path + assemblyName + ".il");
      int startIndex = str1.IndexOf(".assembly extern Camstar.WCFClientBase");
      int count = str1.IndexOf(".assembly " + assemblyName) + (".assembly " + assemblyName).Length - startIndex;
      string str2 = str1.Remove(startIndex, count).Replace("[Camstar.WCFClientBase]", "[Camstar.WCFSilverlightClientBase]");
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(".assembly extern Camstar.WCFSilverlightClientBase");
      stringBuilder.AppendLine("{");
      stringBuilder.AppendLine(" .ver 1:0:0:0");
      stringBuilder.AppendLine("}");
      stringBuilder.AppendLine(".assembly extern System.Runtime.Serialization");
      stringBuilder.AppendLine("{");
      stringBuilder.AppendLine(" .publickeytoken = ( 7C EC 85 D7 BE A7 79 8E )");
      stringBuilder.AppendLine(" .ver 5:0:5:0");
      stringBuilder.AppendLine("}");
      stringBuilder.AppendLine(".assembly extern System");
      stringBuilder.AppendLine("{");
      stringBuilder.AppendLine(" .publickeytoken = ( 7C EC 85 D7 BE A7 79 8E )");
      stringBuilder.AppendLine(" .ver 5:0:5:0");
      stringBuilder.AppendLine("}");
      stringBuilder.AppendLine(".assembly extern mscorlib");
      stringBuilder.AppendLine("{");
      stringBuilder.AppendLine(" .publickeytoken = ( 7C EC 85 D7 BE A7 79 8E )");
      stringBuilder.AppendLine(" .ver 5:0:5:0");
      stringBuilder.AppendLine("}");
      stringBuilder.AppendLine(".assembly Camstar.WCFSilverlightClient");
      string contents = str2.Insert(startIndex, stringBuilder.ToString());
      System.IO.File.WriteAllText(Path + "Camstar.WCFSilverlightClient.il", contents);
      string version = string.Format("v{0}.{1}.{2}", (object) System.Environment.Version.Major, (object) System.Environment.Version.Minor, (object) System.Environment.Version.Build);
      string fileName = string.Format("{0}\\ilasm.exe", (object) Runner.GetFrameworkDirectory(version));
      if (string.IsNullOrEmpty(fileName))
      {
        Console.WriteLine(".NetFramework Path not found");
      }
      else
      {
        Process process = new Process()
        {
          StartInfo = new ProcessStartInfo(fileName, string.Format("/Quiet /Optiomize /mdv={1} /nologo {0}.il /out:{0}.dll /dll", (object) assemblyName, (object) version))
        };
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path);
        process.Start();
        process.WaitForExit();
        if (process.ExitCode > 0)
          throw new WCFGeneratorException("Assembling Silverlight assembly failed");
        System.IO.File.Delete(Path + assemblyName + ".il");
        System.IO.File.Delete(Path + assemblyName + ".res");
      }
    }

    private Process Disassemble(string Path, string assemblyName)
    {
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo("Tools\\ildasm.exe", string.Format("{0}.dll /out:{0}.il /text /nobar", (object) assemblyName))
      };
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path);
      process.Start();
      return process;
    }

    private static string GetFrameworkDirectory(string version)
    {
      string name = "Software\\Microsoft\\.NetFramework";
      string path = Path.Combine(Registry.LocalMachine.OpenSubKey(name, false).GetValue("InstallRoot").ToString(), version);
      return Directory.Exists(path) ? path : string.Empty;
    }

    private AssemblyBuilder DefineDynamicAssembly(
      AssemblyName assemblyName,
      string path,
      string version)
    {
      assemblyName.Version = new Version(version);
      AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save, path);
      CustomAttributeBuilder customBuilder1 = new CustomAttributeBuilder(typeof (AssemblyTitleAttribute).GetConstructor(new Type[1]
      {
        typeof (string)
      }), new object[1]{ (object) "WCF Generated Assembly" });
      assemblyBuilder.SetCustomAttribute(customBuilder1);
      CustomAttributeBuilder customBuilder2 = new CustomAttributeBuilder(typeof (AssemblyDescriptionAttribute).GetConstructor(new Type[1]
      {
        typeof (string)
      }), new object[1]
      {
        (object) (assemblyName.Name + " Library")
      });
      assemblyBuilder.SetCustomAttribute(customBuilder2);
      assemblyBuilder.DefineVersionInfoResource("Camstar Enterprise Platform", version, "Siemens Product Lifecycle Management Software Inc.", "© 2017 Siemens Product Lifecycle Management Software Inc.", string.Empty);
      CustomAttributeBuilder customBuilder3 = new CustomAttributeBuilder(typeof (DebuggableAttribute).GetConstructor(new Type[1]
      {
        typeof (DebuggableAttribute.DebuggingModes)
      }), new object[1]
      {
        (object) (DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations)
      });
      assemblyBuilder.SetCustomAttribute(customBuilder3);
      return assemblyBuilder;
    }

    private void WriteServicesConfiguration()
    {
      string str = this._Settings.ServerOutputDirectory + "\\" + Constants.File.WebConfig;
      if (!System.IO.File.Exists(str))
      {
        using (XmlWriter xmlWriter = XmlWriter.Create(this._Settings.ServerOutputDirectory + "\\" + Constants.File.WebConfig))
        {
          xmlWriter.WriteStartDocument();
          xmlWriter.WriteRaw("\n");
          xmlWriter.WriteStartElement("configuration");
          xmlWriter.WriteRaw("\n");
          xmlWriter.WriteStartElement("system.webServer");
          xmlWriter.WriteRaw("\n\t");
          xmlWriter.WriteStartElement("urlCompression");
          xmlWriter.WriteAttributeString("doDynamicCompression", "false");
          xmlWriter.WriteEndElement();
          xmlWriter.WriteRaw("\n");
          xmlWriter.WriteEndElement();
          xmlWriter.WriteRaw("\n");
          xmlWriter.WriteEndElement();
        }
      }
      else
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(str);
        XmlNode xmlNode1 = xmlDocument.SelectSingleNode("configuration");
        if (xmlNode1 != null)
        {
          XmlNode xmlNode2 = xmlNode1.SelectSingleNode("system.webServer/urlCompression");
          if (xmlNode2 == null)
          {
            XmlNode newChild = xmlNode1.SelectSingleNode("system.webServer") ?? xmlDocument.CreateNode(XmlNodeType.Element, "system.webServer", (string) null);
            XmlNode node = xmlDocument.CreateNode(XmlNodeType.Element, "urlCompression", (string) null);
            ((XmlElement) node).SetAttribute("doDynamicCompression", "false");
            newChild.AppendChild(node);
            xmlNode1.AppendChild(newChild);
          }
          else
            ((XmlElement) xmlNode2).SetAttribute("doDynamicCompression", "false");
          xmlDocument.Save(str);
        }
      }
      System.Configuration.Configuration serverConfig = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
      {
        ExeConfigFilename = this._Settings.ServerOutputDirectory + "\\" + Constants.File.WebConfig
      }, ConfigurationUserLevel.None);
      HttpRuntimeSection section1 = serverConfig.GetSection("system.web/httpRuntime") as HttpRuntimeSection;
      if (!section1.ElementInformation.Properties["maxRequestLength"].IsModified)
        section1.MaxRequestLength = (int) ushort.MaxValue;
      ServicesSection section2 = serverConfig.GetSection("system.serviceModel/services") as ServicesSection;
      BindingsSection section3 = serverConfig.GetSection("system.serviceModel/bindings") as BindingsSection;
      BasicHttpBindingElement element1 = (BasicHttpBindingElement) null;
      foreach (BasicHttpBindingElement binding in (ConfigurationElementCollection) section3.BasicHttpBinding.Bindings)
      {
        if (binding.Name == "DefaultBinding")
          element1 = binding;
      }
      if (element1 == null)
      {
        element1 = new BasicHttpBindingElement("DefaultBinding");
        element1.Name = "DefaultBinding";
        element1.MaxReceivedMessageSize = (long) int.MaxValue;
        element1.ReceiveTimeout = this.ServiceTimeout;
        element1.SendTimeout = this.ServiceTimeout;
        element1.ReaderQuotas.MaxArrayLength = int.MaxValue;
        element1.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
        element1.ReaderQuotas.MaxDepth = int.MaxValue;
        element1.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
        element1.ReaderQuotas.MaxStringContentLength = int.MaxValue;
        section3.BasicHttpBinding.Bindings.Add(element1);
      }
      element1.Security.Mode = !this._Settings.UseSSL ? BasicHttpSecurityMode.None : BasicHttpSecurityMode.Transport;
      element1.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
      if (!(section3["webHttpBinding"] is WebHttpBindingCollectionElement collectionElement))
      {
        collectionElement = new WebHttpBindingCollectionElement();
        section3.BindingCollections.Add((BindingCollectionElement) collectionElement);
      }
      WebHttpBindingElement element2 = (WebHttpBindingElement) null;
      foreach (WebHttpBindingElement binding in (ConfigurationElementCollection) collectionElement.Bindings)
      {
        if (binding.Name == "DefaultBinding")
        {
          element2 = binding;
          break;
        }
      }
      if (element2 == null)
      {
        element2 = new WebHttpBindingElement("DefaultBinding");
        element2.Name = "DefaultBinding";
        element2.MaxReceivedMessageSize = (long) int.MaxValue;
        element2.ReceiveTimeout = this.ServiceTimeout;
        element2.SendTimeout = this.ServiceTimeout;
        element2.ReaderQuotas.MaxArrayLength = int.MaxValue;
        element2.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
        element2.ReaderQuotas.MaxDepth = int.MaxValue;
        element2.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
        element2.ReaderQuotas.MaxStringContentLength = int.MaxValue;
        collectionElement.Bindings.Add(element2);
      }
      element2.Security.Mode = !this._Settings.UseSSL ? WebHttpSecurityMode.None : WebHttpSecurityMode.Transport;
      element2.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
      BehaviorsSection section4 = serverConfig.GetSection("system.serviceModel/behaviors") as BehaviorsSection;
      ServiceBehaviorElement element3 = section4.ServiceBehaviors.Cast<ServiceBehaviorElement>().FirstOrDefault<ServiceBehaviorElement>((Func<ServiceBehaviorElement, bool>) (item => item.Name == "MetaDataBehavior"));
      EndpointBehaviorElement element4 = section4.EndpointBehaviors.Cast<EndpointBehaviorElement>().FirstOrDefault<EndpointBehaviorElement>((Func<EndpointBehaviorElement, bool>) (item => item.Name == "webBehavior"));
      if (serverConfig.AppSettings.Settings["LogXmlDocument"] == null)
        serverConfig.AppSettings.Settings.Add("LogXmlDocument", this._Settings.LogXmlDocument.ToString());
      if (serverConfig.AppSettings.Settings["LogPath"] == null)
        serverConfig.AppSettings.Settings.Add("LogPath", this._Settings.LogPath);
      if (serverConfig.AppSettings.Settings["LogNaming"] == null)
        serverConfig.AppSettings.Settings.Add("LogNaming", this._Settings.LogNaming);
      if (serverConfig.AppSettings.Settings["ProcessTxnGUID"] == null)
        serverConfig.AppSettings.Settings.Add("ProcessTxnGUID", this._Settings.ProcessTxnGUID.ToString());
      if (serverConfig.AppSettings.Settings["IncludedServices"] == null)
        serverConfig.AppSettings.Settings.Add("IncludedServices", string.Empty);
      if (serverConfig.AppSettings.Settings["ExcludedServices"] == null)
        serverConfig.AppSettings.Settings.Add("ExcludedServices", string.Empty);
      if (serverConfig.AppSettings.Settings["DefaultServerConnectionString"] == null)
        serverConfig.AppSettings.Settings.Add("DefaultServerConnectionString", this._Settings.DefaultServerConnectionString);
      if (element4 == null)
      {
        element4 = new EndpointBehaviorElement("webBehavior");
        section4.EndpointBehaviors.Add(element4);
      }
      if (element4[typeof (WebHttpElement)] == null)
      {
        WebHttpElement webHttpElement = new WebHttpElement()
        {
          DefaultBodyStyle = WebMessageBodyStyle.Wrapped,
          DefaultOutgoingResponseFormat = WebMessageFormat.Json
        };
        element4.Add((BehaviorExtensionElement) webHttpElement);
      }
      if (element3 == null)
      {
        element3 = new ServiceBehaviorElement("MetaDataBehavior");
        section4.ServiceBehaviors.Add(element3);
      }
      if (element3[typeof (ServiceMetadataPublishingElement)] == null)
        element3.Add((BehaviorExtensionElement) new ServiceMetadataPublishingElement()
        {
          HttpsGetEnabled = this._Settings.UseSSL,
          HttpGetEnabled = !this._Settings.UseSSL
        });
      else if (element3[typeof (ServiceMetadataPublishingElement)] is ServiceMetadataPublishingElement publishingElement)
      {
        publishingElement.HttpsGetEnabled = this._Settings.UseSSL;
        publishingElement.HttpGetEnabled = !this._Settings.UseSSL;
      }
      if (element3[typeof (ServiceDebugElement)] == null)
        element3.Add((BehaviorExtensionElement) new ServiceDebugElement()
        {
          IncludeExceptionDetailInFaults = true
        });
      if (element3[typeof (DataContractSerializerElement)] == null)
        element3.Add((BehaviorExtensionElement) new DataContractSerializerElement()
        {
          MaxItemsInObjectGraph = int.MaxValue
        });
      this.WriteServiceToConfig("Query", section2, this._Settings.UseSSL);
      this.WriteServiceToConfig("DirectAccess", section2, this._Settings.UseSSL);
      this.WriteServiceToConfig("Authentication", section2, this._Settings.UseSSL);
      this.WriteServiceToConfig("Label", section2, this._Settings.UseSSL);
      foreach (Camstar.WCF.Generator.Helper.ServiceBase exposedService in this._ExposedServices)
      {
        if (exposedService.ExposedState != ExposedServiceStateType.Base)
          this.WriteServiceToConfig(exposedService.Name, section2, this._Settings.UseSSL);
      }
      this.WriteServerConnectionString(serverConfig, this._Settings.ConnectionStrings);
      serverConfig.Save();
    }

    private void WriteServerConnectionString(
      System.Configuration.Configuration serverConfig,
      ConnectionStringElementCollection connectionStrings)
    {
      foreach (ConnectionStringElement connectionString in (ConfigurationElementCollection) connectionStrings)
      {
        if (serverConfig.ConnectionStrings.ConnectionStrings[connectionString.Name] == null)
        {
          ConnectionStringSettings settings = new ConnectionStringSettings(connectionString.Name, connectionString.Value);
          serverConfig.ConnectionStrings.ConnectionStrings.Add(settings);
        }
      }
    }

    private void WriteServiceToConfig(
      string serviceName,
      ServicesSection servicesSection,
      bool ssl)
    {
      this.MakeSvcFile("Camstar.WCF.Service", serviceName + "Service");
      ServiceElement element1 = servicesSection.Services.Cast<ServiceElement>().FirstOrDefault<ServiceElement>((Func<ServiceElement, bool>) (element => element.Name == string.Format("{0}.{1}Service", (object) "Camstar.WCF.Service", (object) serviceName)));
      if (element1 == null)
      {
        element1 = new ServiceElement(string.Format("{0}.{1}Service", (object) "Camstar.WCF.Service", (object) serviceName))
        {
          BehaviorConfiguration = "MetaDataBehavior"
        };
        servicesSection.Services.Add(element1);
      }
      ServiceEndpointElement serviceEndpointElement1 = (ServiceEndpointElement) null;
      ServiceEndpointElement element2 = (ServiceEndpointElement) null;
      ServiceEndpointElement serviceEndpointElement2 = (ServiceEndpointElement) null;
      foreach (ServiceEndpointElement endpoint in (ConfigurationElementCollection) element1.Endpoints)
      {
        if (endpoint.Contract == string.Format("{0}.I{1}Service", (object) "Camstar.WCF.Service", (object) serviceName))
        {
          if (endpoint.Binding == "webHttpBinding")
            serviceEndpointElement2 = endpoint;
          else
            serviceEndpointElement1 = endpoint;
        }
        else if (endpoint.Contract == "IMetadataExchange")
          element2 = endpoint;
      }
      if (serviceEndpointElement1 == null)
        element1.Endpoints.Add(new ServiceEndpointElement()
        {
          Address = new Uri(string.Empty, UriKind.Relative),
          Binding = "basicHttpBinding",
          BindingConfiguration = "DefaultBinding",
          Contract = string.Format("{0}.I{1}Service", (object) "Camstar.WCF.Service", (object) serviceName)
        });
      if (element2 == null)
      {
        element2 = new ServiceEndpointElement();
        element2.Address = new Uri("mex", UriKind.Relative);
        element2.Contract = "IMetadataExchange";
        element1.Endpoints.Add(element2);
      }
      if (Runner.IsWebEndpointRequired(serviceName) && serviceEndpointElement2 == null)
        element1.Endpoints.Add(new ServiceEndpointElement()
        {
          Address = new Uri("web", UriKind.Relative),
          BehaviorConfiguration = "webBehavior",
          Binding = "webHttpBinding",
          BindingConfiguration = "DefaultBinding",
          Contract = string.Format("{0}.I{1}Service", (object) "Camstar.WCF.Service", (object) serviceName)
        });
      element2.Binding = ssl ? "mexHttpsBinding" : "mexHttpBinding";
    }

    private static bool IsWebEndpointRequired(string serviceName)
    {
      return Runner.WebBehaviorServices.Contains(serviceName);
    }

    private void WriteClientConfiguration()
    {
      if (!System.IO.File.Exists(this._Settings.ClientOutputConfigPath))
      {
        XmlWriter xmlWriter = XmlWriter.Create(this._Settings.ClientOutputConfigPath);
        xmlWriter.WriteStartDocument();
        xmlWriter.WriteRaw("\n");
        xmlWriter.WriteStartElement("configuration");
        xmlWriter.WriteEndElement();
        xmlWriter.Close();
      }
      System.Configuration.Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
      {
        ExeConfigFilename = this._Settings.ClientOutputConfigPath
      }, ConfigurationUserLevel.None);
      ClientSection section = configuration.GetSection("system.serviceModel/client") as ClientSection;
      this.WriteClientServiceToConfig("Query", this._Settings.Address, section, this._Settings.UseSSL);
      this.WriteClientServiceToConfig("DirectAccess", this._Settings.Address, section, this._Settings.UseSSL);
      this.WriteClientServiceToConfig("Authentication", this._Settings.Address, section, this._Settings.UseSSL);
      this.WriteClientServiceToConfig("Label", this._Settings.Address, section, this._Settings.UseSSL);
      this.WriteClientSequirityServiceToConfig(this._Settings.Address, section);
      this.WriteClientSilverlightServices(configuration.GetSection("system.serviceModel/services") as ServicesSection, this._Settings.UseSSL);
      foreach (Camstar.WCF.Generator.Helper.ServiceBase exposedService in this._ExposedServices)
      {
        if (exposedService.ExposedState != ExposedServiceStateType.Base)
          this.WriteClientServiceToConfig(exposedService.Name, this._Settings.Address, section, this._Settings.UseSSL);
      }
      configuration.Save();
    }

    private void WriteClientServiceToConfig(
      string serviceName,
      string address,
      ClientSection clientSection,
      bool ssl)
    {
      ChannelEndpointElement element = (ChannelEndpointElement) null;
      foreach (ChannelEndpointElement endpoint in (ConfigurationElementCollection) clientSection.Endpoints)
      {
        if (endpoint.Name == "Camstar.WCF.Services." + serviceName + "Service")
          element = endpoint;
      }
      if (element == null)
      {
        element = new ChannelEndpointElement();
        element.Binding = "basicHttpBinding";
        element.Contract = "Camstar.WCF.Services.I" + serviceName + "Service";
        element.Name = "Camstar.WCF.Services." + serviceName + "Service";
        element.BehaviorConfiguration = "DefaultBehavior";
        clientSection.Endpoints.Add(element);
      }
      UriBuilder uriBuilder = new UriBuilder(new Uri(address + serviceName + "Service.svc"))
      {
        Port = -1
      };
      if (ssl)
      {
        uriBuilder.Scheme = "https";
        if (string.Equals(uriBuilder.Host, "localhost", StringComparison.OrdinalIgnoreCase))
          uriBuilder.Host = Dns.GetHostEntry(System.Environment.MachineName).HostName;
      }
      element.BindingConfiguration = ssl ? "DefaultBindingSSL" : "DefaultBinding";
      element.Address = uriBuilder.Uri;
    }

    private void WriteClientSilverlightServices(
      ServicesSection silverlightServicesSection,
      bool ssl)
    {
      if (silverlightServicesSection == null || silverlightServicesSection.Services == null)
        return;
      foreach (ServiceElement service in (ConfigurationElementCollection) silverlightServicesSection.Services)
      {
        service.BehaviorConfiguration = ssl ? "DefaultBehaviorSSL" : "DefaultBehavior";
        if (service.Endpoints != null)
        {
          foreach (ServiceEndpointElement endpoint in (ConfigurationElementCollection) service.Endpoints)
          {
            if (string.Equals(endpoint.Contract, "IMetadataExchange"))
              endpoint.Binding = ssl ? "mexHttpsBinding" : "mexHttpBinding";
            else
              endpoint.BindingConfiguration = ssl ? "DefaultBindingSSL" : "DefaultBinding";
          }
        }
      }
    }

    private void WriteClientSequirityServiceToConfig(string address, ClientSection clientSection)
    {
      if (clientSection.Endpoints.Cast<ChannelEndpointElement>().FirstOrDefault<ChannelEndpointElement>((Func<ChannelEndpointElement, bool>) (el => el.Name == "BasicHttpBinding_IAuthenticationService")) == null)
      {
        Uri uri = new Uri(address);
        ChannelEndpointElement element = new ChannelEndpointElement()
        {
          Address = new Uri(string.Format("{0}://{1}:2890/CamstarSecurityServices", (object) uri.Scheme, (object) uri.Host)),
          Binding = "basicHttpBinding",
          BindingConfiguration = "DefaultBinding",
          Contract = "Authentication.IAuthenticationService",
          Name = "BasicHttpBinding_IAuthenticationService",
          BehaviorConfiguration = "DefaultBehavior"
        };
        clientSection.Endpoints.Add(element);
      }
      if (clientSection.Endpoints.Cast<ChannelEndpointElement>().FirstOrDefault<ChannelEndpointElement>((Func<ChannelEndpointElement, bool>) (el => el.Name == "BasicHttpBinding_IAuthorizationService")) != null)
        return;
      Uri uri1 = new Uri(address);
      ChannelEndpointElement element1 = new ChannelEndpointElement()
      {
        Address = new Uri(string.Format("{0}://{1}:2891/CamstarSecurityServices", (object) uri1.Scheme, (object) uri1.Host)),
        Binding = "basicHttpBinding",
        BindingConfiguration = "DefaultBinding",
        Contract = "Authorization.IAuthorizationService",
        Name = "BasicHttpBinding_IAuthorizationService",
        BehaviorConfiguration = "DefaultBehavior"
      };
      clientSection.Endpoints.Add(element1);
    }

    private string GetPhaseMessage(GeneratingPhase phase)
    {
      string str = string.Empty;
      switch (phase)
      {
        case GeneratingPhase.CollectInformation:
          str = "Collecting information";
          break;
        case GeneratingPhase.CollectSilverlightInformation:
          str = "Collecting Silverlight information";
          break;
        case GeneratingPhase.DataContract:
          str = "Generating data contracts";
          break;
        case GeneratingPhase.SilverlightDataContract:
          str = "Generating Silverlight data contracts";
          break;
        case GeneratingPhase.ServiceContract:
          str = "Generating service contracts";
          break;
      }
      return str;
    }

    private void MakeSvcFile(string namespaceName, string serviceName)
    {
      System.IO.File.WriteAllText(this._Settings.ServerOutputDirectory + "\\" + serviceName + ".svc", "<%@ServiceHost Service=\"" + namespaceName + "." + serviceName + "\" %>");
    }

    private void DisperseFiles()
    {
      System.IO.File.Copy("Camstar.WCFServiceBase.dll", this._Settings.ServerOutputDirectory + "\\Bin\\Camstar.WCFServiceBase.dll", true);
      System.IO.File.Copy("Camstar.Utility.dll", this._Settings.ServerOutputDirectory + "\\Bin\\Camstar.Utility.dll", true);
      System.IO.File.Copy("Camstar.Util.dll", this._Settings.ServerOutputDirectory + "\\Bin\\Camstar.Util.dll", true);
      System.IO.File.Copy("Camstar.Exceptions.dll", this._Settings.ServerOutputDirectory + "\\Bin\\Camstar.Exceptions.dll", true);
      System.IO.File.Copy("Camstar.Util.dll", this._Settings.ClientOutputDirectory + "\\Camstar.Util.dll", true);
      System.IO.File.Copy("Camstar.Exceptions.dll", this._Settings.ClientOutputDirectory + "\\Camstar.Exceptions.dll", true);
      System.IO.File.Copy("Camstar.WCFClientBase.dll", this._Settings.ClientOutputDirectory + "\\Camstar.WCFClientBase.dll", true);
      if (!this._Settings.IsGenerateSilverlight)
        return;
      System.IO.File.Copy("Camstar.WCFSilverlightClientBase.dll", this._Settings.ClientSilverlightOutputDirectory + "\\Camstar.WCFSilverlightClientBase.dll", true);
    }

    private void CreateDirectories()
    {
      if (Directory.Exists(this._Settings.ServerOutputDirectory))
      {
        foreach (string file in Directory.GetFiles(this._Settings.ServerOutputDirectory))
          System.IO.File.SetAttributes(file, FileAttributes.Normal);
      }
      if (Directory.Exists(this._Settings.ServerOutputDirectory + "\\Bin"))
      {
        foreach (string file in Directory.GetFiles(this._Settings.ServerOutputDirectory + "\\Bin"))
          System.IO.File.SetAttributes(file, FileAttributes.Normal);
      }
      if (Directory.Exists(this._Settings.ClientOutputDirectory))
      {
        foreach (string file in Directory.GetFiles(this._Settings.ClientOutputDirectory))
          System.IO.File.SetAttributes(file, FileAttributes.Normal);
      }
      if (Directory.Exists(this._Settings.ClientSilverlightOutputDirectory))
      {
        foreach (string file in Directory.GetFiles(this._Settings.ClientSilverlightOutputDirectory))
          System.IO.File.SetAttributes(file, FileAttributes.Normal);
      }
      Directory.CreateDirectory(this._Settings.ServerOutputDirectory + "\\Bin");
      Directory.CreateDirectory(this._Settings.ClientOutputDirectory);
      Directory.CreateDirectory(this._Settings.ClientSilverlightOutputDirectory);
    }
  }
}
