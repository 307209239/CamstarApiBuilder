// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_InstanceSecurityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_InstanceSecurityService : V4_SecurityBase
  {
    public V4_InstanceSecurityService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_InstanceSecurityService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      V4_InstanceSecurity v4_InstanceSecurity,
      V4_InstanceSecurity_Parameters parameters,
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      result = (V4_InstanceSecurity_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_InstanceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_InstanceSecurityService) this._Channel).GetWIPMsgs(this._UserProfile, v4_InstanceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_InstanceSecurityMethod(v4_InstanceSecurity, V4_InstanceSecurityMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_InstanceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_InstanceSecurity) null, (V4_InstanceSecurity_Parameters) null, (V4_InstanceSecurity_Request) null, out V4_InstanceSecurity_Result _);
    }

    public ResultStatus GetWIPMsgs(V4_InstanceSecurity v4_InstanceSecurity)
    {
      return this.GetWIPMsgs(v4_InstanceSecurity, (V4_InstanceSecurity_Parameters) null, (V4_InstanceSecurity_Request) null, out V4_InstanceSecurity_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_InstanceSecurity v4_InstanceSecurity,
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      return this.GetWIPMsgs(v4_InstanceSecurity, (V4_InstanceSecurity_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      V4_InstanceSecurity v4_InstanceSecurity,
      V4_InstanceSecurity_Parameters parameters,
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      result = (V4_InstanceSecurity_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) v4_InstanceSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_InstanceSecurityService) this._Channel).Load(this._UserProfile, v4_InstanceSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_InstanceSecurityMethod(v4_InstanceSecurity, V4_InstanceSecurityMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) v4_InstanceSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((V4_InstanceSecurity) null, (V4_InstanceSecurity_Parameters) null, (V4_InstanceSecurity_Request) null, out V4_InstanceSecurity_Result _);
    }

    public ResultStatus Load(V4_InstanceSecurity v4_InstanceSecurity)
    {
      return this.Load(v4_InstanceSecurity, (V4_InstanceSecurity_Parameters) null, (V4_InstanceSecurity_Request) null, out V4_InstanceSecurity_Result _);
    }

    public ResultStatus Load(
      V4_InstanceSecurity v4_InstanceSecurity,
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      return this.Load(v4_InstanceSecurity, (V4_InstanceSecurity_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject v4_InstanceSecurity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_InstanceSecurity_Result result1;
        ResultStatus resultStatus = this.Load((V4_InstanceSecurity) v4_InstanceSecurity, (V4_InstanceSecurity_Parameters) parameters, (V4_InstanceSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_InstanceSecurity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_InstanceSecurity_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_InstanceSecurity) v4_InstanceSecurity, (V4_InstanceSecurity_Parameters) parameters, (V4_InstanceSecurity_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      result = (V4_InstanceSecurity_Result) null;
      try
      {
        V4_InstanceSecurityMethod[] methods = new V4_InstanceSecurityMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_InstanceSecurityService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        V4_InstanceSecurity_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_InstanceSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_InstanceSecurity cdo,
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      result = (V4_InstanceSecurity_Result) null;
      try
      {
        return ((IV4_InstanceSecurityService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        V4_InstanceSecurity_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_InstanceSecurity) cdo, (V4_InstanceSecurity_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      return this.GetEnvironment((V4_InstanceSecurity) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_InstanceSecurity cdo,
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      result = (V4_InstanceSecurity_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_InstanceSecurityService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_InstanceSecurityMethod(cdo, V4_InstanceSecurityMethods.ExecuteTransaction, (V4_InstanceSecurity_Parameters) null));
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
        V4_InstanceSecurity_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_InstanceSecurity) cdo, (V4_InstanceSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_InstanceSecurity cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_InstanceSecurity_Request) null, out V4_InstanceSecurity_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_InstanceSecurity_Request request,
      out V4_InstanceSecurity_Result result)
    {
      return this.ExecuteTransaction((V4_InstanceSecurity) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_InstanceSecurity cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_InstanceSecurityMethod(cdo, V4_InstanceSecurityMethods.AddDataTransaction, (V4_InstanceSecurity_Parameters) null));
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
        return this.AddDataTransaction((V4_InstanceSecurity) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
