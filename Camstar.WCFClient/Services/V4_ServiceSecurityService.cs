// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_ServiceSecurityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_ServiceSecurityService : V4_SecurityBase
  {
    public V4_ServiceSecurityService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_ServiceSecurityService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).GetWIPMsgs(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus GetWIPMsgs(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.GetWIPMsgs(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.GetWIPMsgs(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).Load(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus Load(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.Load(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus Load(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.Load(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus LoadPermissionsGroup(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (LoadPermissionsGroup), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).LoadPermissionsGroup(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.LoadPermissionsGroup, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadPermissionsGroup), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadPermissionsGroup()
    {
      return this.LoadPermissionsGroup((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus LoadPermissionsGroup(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.LoadPermissionsGroup(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus LoadPermissionsGroup(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.LoadPermissionsGroup(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus LoadPermissionsUser(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (LoadPermissionsUser), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).LoadPermissionsUser(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.LoadPermissionsUser, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadPermissionsUser), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadPermissionsUser()
    {
      return this.LoadPermissionsUser((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus LoadPermissionsUser(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.LoadPermissionsUser(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus LoadPermissionsUser(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.LoadPermissionsUser(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus PermissionsCopy(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (PermissionsCopy), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).PermissionsCopy(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.PermissionsCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PermissionsCopy), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PermissionsCopy()
    {
      return this.PermissionsCopy((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus PermissionsCopy(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.PermissionsCopy(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus PermissionsCopy(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.PermissionsCopy(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus Save(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (Save), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).Save(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.Save, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Save), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Save()
    {
      return this.Save((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus Save(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.Save(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus Save(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.Save(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus SavePermissionsGroup(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (SavePermissionsGroup), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).SavePermissionsGroup(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.SavePermissionsGroup, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SavePermissionsGroup), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SavePermissionsGroup()
    {
      return this.SavePermissionsGroup((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus SavePermissionsGroup(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.SavePermissionsGroup(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus SavePermissionsGroup(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.SavePermissionsGroup(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus SavePermissionsUser(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Parameters parameters,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (SavePermissionsUser), (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).SavePermissionsUser(this._UserProfile, v4_ServiceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(v4_ServiceSecurity, V4_ServiceSecurityMethods.SavePermissionsUser, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SavePermissionsUser), res, (DCObject) v4_ServiceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SavePermissionsUser()
    {
      return this.SavePermissionsUser((V4_ServiceSecurity) null, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus SavePermissionsUser(V4_ServiceSecurity v4_ServiceSecurity)
    {
      return this.SavePermissionsUser(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus SavePermissionsUser(
      V4_ServiceSecurity v4_ServiceSecurity,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.SavePermissionsUser(v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject v4_ServiceSecurity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ServiceSecurity_Result result1;
        ResultStatus resultStatus = this.Load((V4_ServiceSecurity) v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) parameters, (V4_ServiceSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_ServiceSecurity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ServiceSecurity_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_ServiceSecurity) v4_ServiceSecurity, (V4_ServiceSecurity_Parameters) parameters, (V4_ServiceSecurity_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      try
      {
        V4_ServiceSecurityMethod[] methods = new V4_ServiceSecurityMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_ServiceSecurityService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ServiceSecurity_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_ServiceSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_ServiceSecurity cdo,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      try
      {
        return ((IV4_ServiceSecurityService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ServiceSecurity_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_ServiceSecurity) cdo, (V4_ServiceSecurity_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.GetEnvironment((V4_ServiceSecurity) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_ServiceSecurity cdo,
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      result = (V4_ServiceSecurity_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ServiceSecurityService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_ServiceSecurityMethod(cdo, V4_ServiceSecurityMethods.ExecuteTransaction, (V4_ServiceSecurity_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ServiceSecurity_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_ServiceSecurity) cdo, (V4_ServiceSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_ServiceSecurity cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_ServiceSecurity_Request) null, out V4_ServiceSecurity_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_ServiceSecurity_Request request,
      out V4_ServiceSecurity_Result result)
    {
      return this.ExecuteTransaction((V4_ServiceSecurity) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_ServiceSecurity cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_ServiceSecurityMethod(cdo, V4_ServiceSecurityMethods.AddDataTransaction, (V4_ServiceSecurity_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((V4_ServiceSecurity) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
