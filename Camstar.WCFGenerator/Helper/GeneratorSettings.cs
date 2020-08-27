// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.GeneratorSettings
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System;
using System.Collections.Generic;
using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class GeneratorSettings
  {
    private string _ServerOutputDirectory = string.Empty;
    private string _ClientOutputDirectory = string.Empty;
    private string _ClientSilverlightOutputDirectory = string.Empty;
    private string _ClientOutputConfigPath = string.Empty;
    private string _DatabaseConnectionString = string.Empty;
    private string _DefaultServerConnectionString = string.Empty;
    private string _Address = string.Empty;
    private string _LogPath = string.Empty;
    private string _LogNaming = string.Empty;
    private ConnectionStringElementCollection _ConnectionStrings;
    private bool _ProcessTxnGUID;
    private bool _LogXmlDocument;
    private bool _UseSSL;
    private bool _IsGenerateAll;
    private bool _IsGenerateSilverlight;
    private bool _IsGetFromRegistry;
    private string _ConfigurationPath;

    public string ServerOutputDirectory
    {
      get
      {
        return this._ServerOutputDirectory;
      }
      set
      {
        this._ServerOutputDirectory = value;
      }
    }

    public string ClientOutputDirectory
    {
      get
      {
        return this._ClientOutputDirectory;
      }
      set
      {
        this._ClientOutputDirectory = value;
      }
    }

    public string ClientSilverlightOutputDirectory
    {
      get
      {
        return this._ClientSilverlightOutputDirectory;
      }
      set
      {
        this._ClientSilverlightOutputDirectory = value;
      }
    }

    public string ClientOutputConfigPath
    {
      get
      {
        return this._ClientOutputConfigPath;
      }
      set
      {
        this._ClientOutputConfigPath = value;
      }
    }

    public string DatabaseConnectionString
    {
      get
      {
        return this._DatabaseConnectionString;
      }
      set
      {
        this._DatabaseConnectionString = value;
      }
    }

    public string DefaultServerConnectionString
    {
      get
      {
        return this._DefaultServerConnectionString;
      }
      set
      {
        this._DefaultServerConnectionString = value;
      }
    }

    public bool IsGenerateSilverlight
    {
      get
      {
        return this._IsGenerateSilverlight;
      }
      set
      {
        this._IsGenerateSilverlight = value;
      }
    }

    public bool IsGenerateAll
    {
      get
      {
        return this._IsGenerateAll;
      }
      set
      {
        this._IsGenerateAll = value;
      }
    }

    public string Address
    {
      get
      {
        return this._Address;
      }
      set
      {
        this._Address = value;
      }
    }

    public string LogPath
    {
      get
      {
        return this._LogPath;
      }
      set
      {
        this._LogPath = value;
      }
    }

    public string LogNaming
    {
      get
      {
        return this._LogNaming;
      }
      set
      {
        this._LogNaming = value;
      }
    }

    public bool LogXmlDocument
    {
      get
      {
        return this._LogXmlDocument;
      }
      set
      {
        this._LogXmlDocument = value;
      }
    }

    public bool UseSSL
    {
      get
      {
        return this._UseSSL;
      }
      set
      {
        this._UseSSL = value;
      }
    }

    public bool ProcessTxnGUID
    {
      get
      {
        return this._ProcessTxnGUID;
      }
      set
      {
        this._ProcessTxnGUID = value;
      }
    }

    public bool IsGetFromRegistry
    {
      get
      {
        return this._IsGetFromRegistry;
      }
      set
      {
        this._IsGetFromRegistry = value;
      }
    }

    public ConnectionStringElementCollection ConnectionStrings
    {
      get
      {
        return this._ConnectionStrings;
      }
      set
      {
        this._ConnectionStrings = value;
      }
    }

    public GeneratorSettings(string path)
    {
      this._ConfigurationPath = path;
      GeneratorSection section = this.OpenConfiguration().GetSection("WCFGenerator") as GeneratorSection;
      this._IsGenerateAll = section.ServicesSettings.IsGenerateAll;
      this._IsGenerateSilverlight = section.ServicesSettings.IsGenerateSilverlight;
      this._Address = section.ServicesSettings.Address;
      this._ProcessTxnGUID = section.ServicesSettings.ProcessTxnGUID;
      this._LogXmlDocument = section.ServicesSettings.LogXmlDocument;
      this._UseSSL = section.ServicesSettings.UseSSL;
      this._LogPath = section.ServicesSettings.LogPath;
      this._LogNaming = section.ServicesSettings.LogNaming;
      this._ClientOutputConfigPath = section.GeneratedAssemblySettings.ClientOutputConfigPath;
      this._ClientOutputDirectory = section.GeneratedAssemblySettings.ClientOutputDirectory;
      this._ClientSilverlightOutputDirectory = section.GeneratedAssemblySettings.ClientSilverlightOutputDirectory;
      this._ServerOutputDirectory = section.GeneratedAssemblySettings.ServerOutputDirectory;
      this._DatabaseConnectionString = section.ConnectionSettings.DatabaseConnectionString;
      this._DefaultServerConnectionString = section.ConnectionSettings.DefaultServerConnectionString;
      this._IsGetFromRegistry = section.ConnectionSettings.IsGetFromRegistry;
      this._ConnectionStrings = section.ConnectionSettings.ConnectionStrings;
    }

    public GeneratorSettings()
      : this((string) null)
    {
    }

    public void ApplyToServices(IService service)
    {
      this.ImportServicesFromConfig((this.OpenConfiguration().GetSection("WCFGenerator") as GeneratorSection).RootService, service);
    }

    public void ApplyToSilverlightServices(IService service)
    {
      this.ImportServicesFromConfig((this.OpenConfiguration().GetSection("WCFGenerator") as GeneratorSection).LightRootService, service);
    }

    public void ApplyForAllToServices(IService service)
    {
      this.ApplyForAllToServices(service, false);
    }

    public void ApplyForAllToServices(IService service, bool isPreview)
    {
      GeneratorSection section = this.OpenConfiguration().GetSection("WCFGenerator") as GeneratorSection;
      if (!isPreview)
      {
        this.ExposeChildServices(new List<IService>((IEnumerable<IService>) new IService[1]
        {
          service
        }));
        this.ImportServicesForAllFromConfig(section.ForAllRootService, service);
        this.ApplySpecificMethods(service);
      }
      else
        this.ImportServicesFromConfig(section.ForAllRootService, service);
    }

    public void SaveServices(IService service)
    {
      if (service == null)
        throw new ArgumentNullException(nameof (service), "Parent service is expected, but null found.");
      System.Configuration.Configuration configuration = this.OpenConfiguration();
      GeneratorSection section = configuration.GetSection("WCFGenerator") as GeneratorSection;
      section.RootService = new ServiceSettingsElement();
      this.ExportServicesToConfig(section.RootService, (ServiceSettingsElement) null, new List<IService>((IEnumerable<IService>) new IService[1]
      {
        service
      }));
      configuration.Save();
    }

    public void SaveSilverlightServices(IService service)
    {
      if (service == null)
        throw new ArgumentNullException(nameof (service), "Parent service is expected, but null found.");
      System.Configuration.Configuration configuration = this.OpenConfiguration();
      GeneratorSection section = configuration.GetSection("WCFGenerator") as GeneratorSection;
      section.LightRootService = new ServiceSettingsElement();
      this.ExportServicesToConfig(section.LightRootService, (ServiceSettingsElement) null, new List<IService>((IEnumerable<IService>) new IService[1]
      {
        service
      }));
      configuration.Save();
    }

    public void SaveForAllServices(IService service)
    {
      if (service == null)
        throw new ArgumentNullException(nameof (service), "Parent service is expected, but null found.");
      System.Configuration.Configuration configuration = this.OpenConfiguration();
      GeneratorSection section = configuration.GetSection("WCFGenerator") as GeneratorSection;
      section.ForAllRootService = new ServiceSettingsElement();
      this.ExportServicesToConfig(section.ForAllRootService, (ServiceSettingsElement) null, new List<IService>((IEnumerable<IService>) new IService[1]
      {
        service
      }));
      configuration.Save();
    }

    public void SaveAs(string path)
    {
      if (this._ConfigurationPath == path)
        path = (string) null;
      System.Configuration.Configuration configuration = this.OpenConfiguration();
      if (!string.IsNullOrEmpty(path))
        this._ConfigurationPath = path;
      GeneratorSection section = configuration.GetSection("WCFGenerator") as GeneratorSection;
      section.ServicesSettings.IsGenerateAll = this._IsGenerateAll;
      section.ServicesSettings.IsGenerateSilverlight = this._IsGenerateSilverlight;
      section.ServicesSettings.Address = this._Address;
      section.ServicesSettings.LogNaming = this._LogNaming;
      section.ServicesSettings.LogPath = this._LogPath;
      section.ServicesSettings.LogXmlDocument = this._LogXmlDocument;
      section.ServicesSettings.UseSSL = this._UseSSL;
      section.ServicesSettings.ProcessTxnGUID = this._ProcessTxnGUID;
      section.GeneratedAssemblySettings.ClientOutputConfigPath = this._ClientOutputConfigPath;
      section.GeneratedAssemblySettings.ClientOutputDirectory = this._ClientOutputDirectory;
      section.GeneratedAssemblySettings.ClientSilverlightOutputDirectory = this._ClientSilverlightOutputDirectory;
      section.GeneratedAssemblySettings.ServerOutputDirectory = this._ServerOutputDirectory;
      section.ConnectionSettings.DatabaseConnectionString = this._DatabaseConnectionString;
      section.ConnectionSettings.DefaultServerConnectionString = this._DefaultServerConnectionString;
      section.ConnectionSettings.IsGetFromRegistry = this._IsGetFromRegistry;
      section.ConnectionSettings.ConnectionStrings = this._ConnectionStrings;
      if (string.IsNullOrEmpty(path))
        configuration.Save();
      else
        configuration.SaveAs(this._ConfigurationPath);
    }

    public void Save()
    {
      this.SaveAs((string) null);
    }

    private System.Configuration.Configuration OpenConfiguration()
    {
      System.Configuration.Configuration configuration = !string.IsNullOrEmpty(this._ConfigurationPath) ? ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
      {
        ExeConfigFilename = this._ConfigurationPath
      }, ConfigurationUserLevel.None) : ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      if (!(configuration.GetSection("WCFGenerator") is GeneratorSection))
      {
        GeneratorSection generatorSection = new GeneratorSection();
        configuration.Sections.Add("WCFGenerator", (ConfigurationSection) generatorSection);
      }
      return configuration;
    }

    private void ExportServicesToConfig(
      ServiceSettingsElement childElement,
      ServiceSettingsElement parentElement,
      List<IService> childServices)
    {
      if (childServices == null)
        return;
      foreach (IService childService in childServices)
      {
        ServiceSettingsElement serviceSettingsElement = new ServiceSettingsElement();
        if (childService.ExposedState != ExposedServiceStateType.NonExposed)
          this.AppendMethodsToConfig(serviceSettingsElement, (IEnumerable<IMethod>) childService.Methods);
        serviceSettingsElement.ExposedType = childService.ExposedState;
        serviceSettingsElement.Name = childService.Name;
        childElement.Children.Add(serviceSettingsElement);
        this.ExportServicesToConfig(serviceSettingsElement, childElement, childService.Children);
      }
      if (childElement.Children.Count != 0 || childElement.ExposedType != ExposedServiceStateType.NonExposed || parentElement == null)
        return;
      parentElement.Children.Remove(childElement.Name);
    }

    private void AppendMethodsToConfig(
      ServiceSettingsElement newServElement,
      IEnumerable<IMethod> methods)
    {
      if (methods == null)
        return;
      foreach (IMethod method in methods)
      {
        if (method.ExposedState != ExposedMethodStateType.NonExposed)
          newServElement.Methods.Add(new MethodElement()
          {
            ExposedType = method.ExposedState,
            Name = method.Name
          });
      }
    }

    private void ImportServicesForAllFromConfig(
      ServiceSettingsElement parentElement,
      IService parentServ)
    {
      if (parentElement == null || parentServ == null)
        return;
      foreach (ServiceSettingsElement child1 in (ConfigurationElementCollection) parentElement.Children)
      {
        IService child2 = parentServ.FindChild(child1.Name);
        if (child2 != null)
        {
          if (child1.ExposedType != ExposedServiceStateType.NonExposed)
          {
            child2.ExposedState = child1.ExposedType;
            this.ImportMethodsForAllFromConfig(child1.Methods, (IEnumerable<IMethod>) child2.Methods, parentServ);
            this.ApplyToChildren(child2);
          }
          this.ImportServicesForAllFromConfig(child1, child2);
        }
      }
    }

    private void ApplyToChildren(IService service)
    {
      foreach (IService child in service.Children)
      {
        this.ImportMethodsForAllFromConfig((MethodElementCollection) null, (IEnumerable<IMethod>) child.Methods, service);
        this.ApplyToChildren(child);
      }
    }

    private void ApplySpecificMethods(IService service)
    {
      foreach (IMethod method in service.Methods)
      {
        if (!method.IsInherited && method.ExposedState == ExposedMethodStateType.NonExposed)
          method.ExposedState = ExposedMethodStateType.Exposed;
      }
      foreach (IService child in service.Children)
        this.ApplySpecificMethods(child);
    }

    private void ImportServicesFromConfig(ServiceSettingsElement parentElement, IService parentServ)
    {
      if (parentElement == null || parentServ == null)
        return;
      foreach (ServiceSettingsElement child1 in (ConfigurationElementCollection) parentElement.Children)
      {
        IService child2 = parentServ.FindChild(child1.Name);
        if (child2 != null)
        {
          this.ImportServicesFromConfig(child1, child2);
          if (child1.ExposedType != ExposedServiceStateType.NonExposed)
          {
            child2.ExposedState = child1.ExposedType;
            this.ImportMethodsFromConfig(child1.Methods, (IEnumerable<IMethod>) child2.Methods);
          }
        }
      }
    }

    private void ImportMethodsFromConfig(
      MethodElementCollection xmlMethods,
      IEnumerable<IMethod> methods)
    {
      if (xmlMethods.Count <= 0 || methods == null)
        return;
      foreach (IMethod method in methods)
      {
        MethodElement methodElement = xmlMethods.Get(method.Name);
        if (methodElement != null)
          method.ExposedState = methodElement.ExposedType;
      }
    }

    private void ImportMethodsForAllFromConfig(
      MethodElementCollection xmlMethods,
      IEnumerable<IMethod> methods,
      IService parentServ)
    {
      if (xmlMethods == null)
      {
        foreach (IMethod method1 in methods)
        {
          method1.ExposedState = ExposedMethodStateType.NonExposed;
          foreach (IMethod method2 in parentServ.Methods)
          {
            if (method2.Name == method1.Name)
              method1.ExposedState = method2.ExposedState;
          }
        }
      }
      else
      {
        if (methods == null)
          return;
        foreach (IMethod method in methods)
        {
          MethodElement methodElement = xmlMethods.Get(method.Name);
          if (methodElement != null)
            method.ExposedState = methodElement.ExposedType;
        }
      }
    }

    private void ExposeChildServices(List<IService> services)
    {
      foreach (IService service in services)
      {
        service.ExposedState = ExposedServiceStateType.Exposed;
        foreach (IMethod method in service.Methods)
          method.ExposedState = ExposedMethodStateType.BaseAndExposed;
        if (service.IsParent)
        {
          service.ExposedState = ExposedServiceStateType.BaseAndExposed;
          this.ExposeChildServices(service.Children);
        }
      }
    }
  }
}
