// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CDOInstanceInfoInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CDOInstanceInfoInquiryService : InquiryBase
  {
    public CDOInstanceInfoInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICDOInstanceInfoInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Parameters parameters,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      result = (CDOInstanceInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) cDOInstanceInfoInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICDOInstanceInfoInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, cDOInstanceInfoInquiry, parameters, request, out result) : this.AddMethod((Method) new CDOInstanceInfoInquiryMethod(cDOInstanceInfoInquiry, CDOInstanceInfoInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) cDOInstanceInfoInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CDOInstanceInfoInquiry) null, (CDOInstanceInfoInquiry_Parameters) null, (CDOInstanceInfoInquiry_Request) null, out CDOInstanceInfoInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(CDOInstanceInfoInquiry cDOInstanceInfoInquiry)
    {
      return this.GetWIPMsgs(cDOInstanceInfoInquiry, (CDOInstanceInfoInquiry_Parameters) null, (CDOInstanceInfoInquiry_Request) null, out CDOInstanceInfoInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      return this.GetWIPMsgs(cDOInstanceInfoInquiry, (CDOInstanceInfoInquiry_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Parameters parameters,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      result = (CDOInstanceInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) cDOInstanceInfoInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICDOInstanceInfoInquiryService) this._Channel).Load(this._UserProfile, cDOInstanceInfoInquiry, parameters, request, out result) : this.AddMethod((Method) new CDOInstanceInfoInquiryMethod(cDOInstanceInfoInquiry, CDOInstanceInfoInquiryMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) cDOInstanceInfoInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CDOInstanceInfoInquiry) null, (CDOInstanceInfoInquiry_Parameters) null, (CDOInstanceInfoInquiry_Request) null, out CDOInstanceInfoInquiry_Result _);
    }

    public ResultStatus Load(CDOInstanceInfoInquiry cDOInstanceInfoInquiry)
    {
      return this.Load(cDOInstanceInfoInquiry, (CDOInstanceInfoInquiry_Parameters) null, (CDOInstanceInfoInquiry_Request) null, out CDOInstanceInfoInquiry_Result _);
    }

    public ResultStatus Load(
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      return this.Load(cDOInstanceInfoInquiry, (CDOInstanceInfoInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject cDOInstanceInfoInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CDOInstanceInfoInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CDOInstanceInfoInquiry) cDOInstanceInfoInquiry, (CDOInstanceInfoInquiry_Parameters) parameters, (CDOInstanceInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      result = (CDOInstanceInfoInquiry_Result) null;
      try
      {
        CDOInstanceInfoInquiryMethod[] methods = new CDOInstanceInfoInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICDOInstanceInfoInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CDOInstanceInfoInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CDOInstanceInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CDOInstanceInfoInquiry cdo,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      result = (CDOInstanceInfoInquiry_Result) null;
      try
      {
        return ((ICDOInstanceInfoInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CDOInstanceInfoInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((CDOInstanceInfoInquiry) cdo, (CDOInstanceInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      return this.GetEnvironment((CDOInstanceInfoInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CDOInstanceInfoInquiry cdo,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      result = (CDOInstanceInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICDOInstanceInfoInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CDOInstanceInfoInquiryMethod(cdo, CDOInstanceInfoInquiryMethods.ExecuteTransaction, (CDOInstanceInfoInquiry_Parameters) null));
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
        CDOInstanceInfoInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CDOInstanceInfoInquiry) cdo, (CDOInstanceInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CDOInstanceInfoInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (CDOInstanceInfoInquiry_Request) null, out CDOInstanceInfoInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result)
    {
      return this.ExecuteTransaction((CDOInstanceInfoInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CDOInstanceInfoInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CDOInstanceInfoInquiryMethod(cdo, CDOInstanceInfoInquiryMethods.AddDataTransaction, (CDOInstanceInfoInquiry_Parameters) null));
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
        return this.AddDataTransaction((CDOInstanceInfoInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
