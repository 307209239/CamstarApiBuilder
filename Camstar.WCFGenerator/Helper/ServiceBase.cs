// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.ServiceBase
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.ObjectModel;
using System.Collections.Generic;

namespace Camstar.WCF.Generator.Helper
{
  internal class ServiceBase : IService
  {
    private readonly List<IMethod> _Methods = new List<IMethod>();
    private readonly List<IService> _ChildrenServices = new List<IService>();
    private bool _IsParent = true;
    private ExposedServiceStateType _ExposedState;
    private DCType _DCType;
    private ServiceBase _Parent;
    private bool _IsChildrenLoaded;
    private bool _IsMethodsLoaded;
    private string _Name;
    private string _Description;
    private int _Id;

    public ServiceBase()
    {
    }

    public ServiceBase(int id, string name, string description)
    {
      this._ExposedState = ExposedServiceStateType.NonExposed;
      this._Id = id;
      this._Name = name;
      this._Description = description;
      this._DCType = new DCType(name, id, 0, string.Empty, false, false);
    }

    public ServiceBase Parent
    {
      get
      {
        return this._Parent;
      }
    }

    public ServiceBase ParentWCFServiceBaseType
    {
      get
      {
        ServiceBase serviceBase = (ServiceBase) null;
        if (this._Parent != null)
          serviceBase = this._Parent._ExposedState == ExposedServiceStateType.Base || this._Parent._ExposedState == ExposedServiceStateType.BaseAndExposed ? this._Parent : this._Parent.ParentWCFServiceBaseType;
        return serviceBase;
      }
    }

    public DCType DCType
    {
      get
      {
        return this._DCType;
      }
    }

    public bool IsParent
    {
      get
      {
        return this._IsParent;
      }
    }

    public string Name
    {
      get
      {
        return this._Name;
      }
    }

    public string Description
    {
      get
      {
        return this._Description;
      }
    }

    public int ID
    {
      get
      {
        return this._Id;
      }
    }

    public ExposedServiceStateType ExposedState
    {
      get
      {
        return this._ExposedState;
      }
      set
      {
        this._ExposedState = value;
      }
    }

    public List<IMethod> Methods
    {
      get
      {
        return new List<IMethod>((IEnumerable<IMethod>) this._Methods);
      }
    }

    public List<IService> Children
    {
      get
      {
        if (!this._IsChildrenLoaded)
          this.GetChildren();
        return new List<IService>((IEnumerable<IService>) this._ChildrenServices);
      }
    }

    public IService FindChild(string name)
    {
      IService service = (IService) null;
      if (this._Name == name)
      {
        service = (IService) this;
      }
      else
      {
        foreach (IService child in this.Children)
        {
          service = child.FindChild(name);
          if (service != null)
            break;
        }
      }
      return service;
    }

    public List<ServiceBase> GetExposedChildren()
    {
      List<ServiceBase> serviceBaseList = new List<ServiceBase>();
      if (this._ExposedState != ExposedServiceStateType.NonExposed)
        serviceBaseList.Add(this);
      foreach (IService childrenService in this._ChildrenServices)
      {
        ServiceBase serviceBase = childrenService as ServiceBase;
        serviceBaseList.AddRange((IEnumerable<ServiceBase>) serviceBase.GetExposedChildren());
      }
      return serviceBaseList;
    }

    public List<ServiceBase> GetWCFServiceBaseChildren()
    {
      List<ServiceBase> serviceBaseList = new List<ServiceBase>();
      if (this._ExposedState == ExposedServiceStateType.Base || this._ExposedState == ExposedServiceStateType.BaseAndExposed)
        serviceBaseList.Add(this);
      foreach (IService childrenService in this._ChildrenServices)
      {
        ServiceBase serviceBase = childrenService as ServiceBase;
        serviceBaseList.AddRange((IEnumerable<ServiceBase>) serviceBase.GetWCFServiceBaseChildren());
      }
      return serviceBaseList;
    }

    public List<IService> GetChildren()
    {
      if (!this._IsChildrenLoaded && this._IsParent)
      {
        ServiceBase service = this.PrepareService();
        Method method = (Method) null;
        Parameter parameter = (Parameter) null;
        this.GetMethods();
        foreach (CDODefinition child in CDORequestor.CurrentRequestor.GetChildren(this._Id))
        {
          if (!string.Equals(child.Name, service._Name))
          {
            if (!string.IsNullOrEmpty(service._Name))
              this.FinishAddingMethods(service);
            service = this.PrepareService();
            service._Name = child.Name;
            service._Description = child.Description;
            service._Id = child.CDOId;
            service._Parent = this;
            service._IsParent = !child.IsCountNull;
            service._ExposedState = ExposedServiceStateType.NonExposed;
            service._DCType = new DCType(child.Name, child.CDOId, 0, string.Empty, false, false);
            this._ChildrenServices.Add((IService) service);
            method = new Method(string.Empty, ExposedMethodStateType.NonExposed, false);
          }
          if (!child.IsMethodNameNull && !string.Equals(child.MethodName, method.Name))
          {
            method = new Method(child.MethodName, ExposedMethodStateType.NonExposed, false);
            service._Methods.Add((IMethod) method);
            parameter = new Parameter(string.Empty);
          }
          if (!child.IsParameterNameNull && !string.Equals(child.ParameterName, parameter.Name))
          {
            parameter = new Parameter(child.ParameterName);
            method.Parameters.Add(parameter);
          }
        }
        this.FinishAddingMethods(service);
        this._IsChildrenLoaded = true;
      }
      return this._ChildrenServices;
    }

    public List<IMethod> GetMethods()
    {
      if (!this._IsMethodsLoaded)
      {
        int num = 0;
        foreach (CDOMethod method in CDORequestor.CurrentRequestor.GetMethods(this._Id))
        {
          num = method.ParentID;
          if (!method.IsMethodNameNull)
          {
            if (this._Methods.Count == 0 || this._Methods[this._Methods.Count - 1].Name != method.MethodName)
              this._Methods.Add((IMethod) new Method(method.MethodName, ExposedMethodStateType.NonExposed, false));
            if (!method.IsParameterNameNull)
              (this._Methods[this._Methods.Count - 1] as Method).Parameters.Add(new Parameter(method.ParameterName));
          }
        }
        if (num != 0)
        {
          this._Parent = this.PrepareService();
          this._Parent._Id = num;
          this.AddMethods(this._Parent.GetMethods());
        }
        this.PrepareMethods();
        this._IsMethodsLoaded = true;
      }
      return this._Methods;
    }

    protected void PrepareMethods()
    {
      this._Methods.Sort((IComparer<IMethod>) new MethodComparer());
    }

    private void FinishAddingMethods(ServiceBase service)
    {
      service.AddMethods(this._Methods);
      service.PrepareMethods();
      service._IsMethodsLoaded = true;
    }

    protected void AddMethods(List<IMethod> methodsToAdd)
    {
      foreach (Method method1 in methodsToAdd)
      {
        bool flag = false;
        foreach (Method method2 in this._Methods)
        {
          if (method2.Name == method1.Name)
          {
            flag = true;
            method2.IsInherited = true;
          }
        }
        if (!flag)
        {
          Method method2 = new Method(method1.Name, ExposedMethodStateType.NonExposed, true);
          method2.Parameters.AddRange((IEnumerable<Parameter>) method1.Parameters);
          this._Methods.Add((IMethod) method2);
        }
      }
    }

    protected ServiceBase PrepareService()
    {
      return new ServiceBase();
    }
  }
}
