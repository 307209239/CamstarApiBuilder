// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_ObjectTypeSecurityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_ObjectTypeSecurityService : V4_SecurityBase
  {
    public V4_ObjectTypeSecurityService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_ObjectTypeSecurityService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Parameters parameters,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      result = (V4_ObjectTypeSecurity_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_ObjectTypeSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ObjectTypeSecurityService) this._Channel).GetWIPMsgs(this._UserProfile, v4_ObjectTypeSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ObjectTypeSecurityMethod(v4_ObjectTypeSecurity, V4_ObjectTypeSecurityMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_ObjectTypeSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_ObjectTypeSecurity) null, (V4_ObjectTypeSecurity_Parameters) null, (V4_ObjectTypeSecurity_Request) null, out V4_ObjectTypeSecurity_Result _);
    }

    public ResultStatus GetWIPMsgs(V4_ObjectTypeSecurity v4_ObjectTypeSecurity)
    {
      return this.GetWIPMsgs(v4_ObjectTypeSecurity, (V4_ObjectTypeSecurity_Parameters) null, (V4_ObjectTypeSecurity_Request) null, out V4_ObjectTypeSecurity_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      return this.GetWIPMsgs(v4_ObjectTypeSecurity, (V4_ObjectTypeSecurity_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Parameters parameters,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      result = (V4_ObjectTypeSecurity_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) v4_ObjectTypeSecurity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ObjectTypeSecurityService) this._Channel).Load(this._UserProfile, v4_ObjectTypeSecurity, parameters, request, out result) : this.AddMethod((Method) new V4_ObjectTypeSecurityMethod(v4_ObjectTypeSecurity, V4_ObjectTypeSecurityMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) v4_ObjectTypeSecurity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((V4_ObjectTypeSecurity) null, (V4_ObjectTypeSecurity_Parameters) null, (V4_ObjectTypeSecurity_Request) null, out V4_ObjectTypeSecurity_Result _);
    }

    public ResultStatus Load(V4_ObjectTypeSecurity v4_ObjectTypeSecurity)
    {
      return this.Load(v4_ObjectTypeSecurity, (V4_ObjectTypeSecurity_Parameters) null, (V4_ObjectTypeSecurity_Request) null, out V4_ObjectTypeSecurity_Result _);
    }

    public ResultStatus Load(
      V4_ObjectTypeSecurity v4_ObjectTypeSecurity,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      return this.Load(v4_ObjectTypeSecurity, (V4_ObjectTypeSecurity_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject v4_ObjectTypeSecurity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ObjectTypeSecurity_Result result1;
        ResultStatus resultStatus = this.Load((V4_ObjectTypeSecurity) v4_ObjectTypeSecurity, (V4_ObjectTypeSecurity_Parameters) parameters, (V4_ObjectTypeSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_ObjectTypeSecurity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ObjectTypeSecurity_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_ObjectTypeSecurity) v4_ObjectTypeSecurity, (V4_ObjectTypeSecurity_Parameters) parameters, (V4_ObjectTypeSecurity_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      result = (V4_ObjectTypeSecurity_Result) null;
      try
      {
        V4_ObjectTypeSecurityMethod[] methods = new V4_ObjectTypeSecurityMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_ObjectTypeSecurityService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        V4_ObjectTypeSecurity_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_ObjectTypeSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_ObjectTypeSecurity cdo,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      result = (V4_ObjectTypeSecurity_Result) null;
      try
      {
        return ((IV4_ObjectTypeSecurityService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        V4_ObjectTypeSecurity_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_ObjectTypeSecurity) cdo, (V4_ObjectTypeSecurity_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      return this.GetEnvironment((V4_ObjectTypeSecurity) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_ObjectTypeSecurity cdo,
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      result = (V4_ObjectTypeSecurity_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ObjectTypeSecurityService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_ObjectTypeSecurityMethod(cdo, V4_ObjectTypeSecurityMethods.ExecuteTransaction, (V4_ObjectTypeSecurity_Parameters) null));
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
        V4_ObjectTypeSecurity_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_ObjectTypeSecurity) cdo, (V4_ObjectTypeSecurity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_ObjectTypeSecurity cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_ObjectTypeSecurity_Request) null, out V4_ObjectTypeSecurity_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_ObjectTypeSecurity_Request request,
      out V4_ObjectTypeSecurity_Result result)
    {
      return this.ExecuteTransaction((V4_ObjectTypeSecurity) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_ObjectTypeSecurity cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_ObjectTypeSecurityMethod(cdo, V4_ObjectTypeSecurityMethods.AddDataTransaction, (V4_ObjectTypeSecurity_Parameters) null));
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
        return this.AddDataTransaction((V4_ObjectTypeSecurity) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
