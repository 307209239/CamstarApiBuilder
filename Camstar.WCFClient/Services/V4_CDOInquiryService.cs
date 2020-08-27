// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_CDOInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_CDOInquiryService : InquiryBase
  {
    public V4_CDOInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_CDOInquiryService), userProfile);
    }

    public ResultStatus CDOInquiry_GetAllCDODefs(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (CDOInquiry_GetAllCDODefs), (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_CDOInquiryService) this._Channel).CDOInquiry_GetAllCDODefs(this._UserProfile, v4_CDOInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_CDOInquiryMethod(v4_CDOInquiry, V4_CDOInquiryMethods.CDOInquiry_GetAllCDODefs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CDOInquiry_GetAllCDODefs), res, (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CDOInquiry_GetAllCDODefs()
    {
      return this.CDOInquiry_GetAllCDODefs((V4_CDOInquiry) null, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetAllCDODefs(V4_CDOInquiry v4_CDOInquiry)
    {
      return this.CDOInquiry_GetAllCDODefs(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetAllCDODefs(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.CDOInquiry_GetAllCDODefs(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, request, out result);
    }

    public ResultStatus CDOInquiry_GetCDOs(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (CDOInquiry_GetCDOs), (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_CDOInquiryService) this._Channel).CDOInquiry_GetCDOs(this._UserProfile, v4_CDOInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_CDOInquiryMethod(v4_CDOInquiry, V4_CDOInquiryMethods.CDOInquiry_GetCDOs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CDOInquiry_GetCDOs), res, (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CDOInquiry_GetCDOs()
    {
      return this.CDOInquiry_GetCDOs((V4_CDOInquiry) null, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetCDOs(V4_CDOInquiry v4_CDOInquiry)
    {
      return this.CDOInquiry_GetCDOs(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetCDOs(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.CDOInquiry_GetCDOs(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, request, out result);
    }

    public ResultStatus CDOInquiry_GetFields(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (CDOInquiry_GetFields), (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_CDOInquiryService) this._Channel).CDOInquiry_GetFields(this._UserProfile, v4_CDOInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_CDOInquiryMethod(v4_CDOInquiry, V4_CDOInquiryMethods.CDOInquiry_GetFields, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CDOInquiry_GetFields), res, (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CDOInquiry_GetFields()
    {
      return this.CDOInquiry_GetFields((V4_CDOInquiry) null, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetFields(V4_CDOInquiry v4_CDOInquiry)
    {
      return this.CDOInquiry_GetFields(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetFields(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.CDOInquiry_GetFields(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, request, out result);
    }

    public ResultStatus CDOInquiry_GetInstances(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (CDOInquiry_GetInstances), (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_CDOInquiryService) this._Channel).CDOInquiry_GetInstances(this._UserProfile, v4_CDOInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_CDOInquiryMethod(v4_CDOInquiry, V4_CDOInquiryMethods.CDOInquiry_GetInstances, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CDOInquiry_GetInstances), res, (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CDOInquiry_GetInstances()
    {
      return this.CDOInquiry_GetInstances((V4_CDOInquiry) null, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetInstances(V4_CDOInquiry v4_CDOInquiry)
    {
      return this.CDOInquiry_GetInstances(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus CDOInquiry_GetInstances(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.CDOInquiry_GetInstances(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_CDOInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, v4_CDOInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_CDOInquiryMethod(v4_CDOInquiry, V4_CDOInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_CDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_CDOInquiry) null, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(V4_CDOInquiry v4_CDOInquiry)
    {
      return this.GetWIPMsgs(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.GetWIPMsgs(v4_CDOInquiry, (V4_CDOInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_CDOInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_CDOInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_CDOInquiry) v4_CDOInquiry, (V4_CDOInquiry_Parameters) parameters, (V4_CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      try
      {
        V4_CDOInquiryMethod[] methods = new V4_CDOInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_CDOInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        V4_CDOInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_CDOInquiry cdo,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      try
      {
        return ((IV4_CDOInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        V4_CDOInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_CDOInquiry) cdo, (V4_CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.GetEnvironment((V4_CDOInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_CDOInquiry cdo,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      result = (V4_CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_CDOInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_CDOInquiryMethod(cdo, V4_CDOInquiryMethods.ExecuteTransaction, (V4_CDOInquiry_Parameters) null));
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
        V4_CDOInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_CDOInquiry) cdo, (V4_CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_CDOInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_CDOInquiry_Request) null, out V4_CDOInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result)
    {
      return this.ExecuteTransaction((V4_CDOInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_CDOInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_CDOInquiryMethod(cdo, V4_CDOInquiryMethods.AddDataTransaction, (V4_CDOInquiry_Parameters) null));
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
        return this.AddDataTransaction((V4_CDOInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
