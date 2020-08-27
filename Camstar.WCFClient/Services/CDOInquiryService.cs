// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CDOInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CDOInquiryService : InquiryBase
  {
    public CDOInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICDOInquiryService), userProfile);
    }

    public ResultStatus GetReferences(
      CDOInquiry cDOInquiry,
      CDOInquiry_Parameters parameters,
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      result = (CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (GetReferences), (DCObject) cDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICDOInquiryService) this._Channel).GetReferences(this._UserProfile, cDOInquiry, parameters, request, out result) : this.AddMethod((Method) new CDOInquiryMethod(cDOInquiry, CDOInquiryMethods.GetReferences, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetReferences), res, (DCObject) cDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetReferences()
    {
      return this.GetReferences((CDOInquiry) null, (CDOInquiry_Parameters) null, (CDOInquiry_Request) null, out CDOInquiry_Result _);
    }

    public ResultStatus GetReferences(CDOInquiry cDOInquiry)
    {
      return this.GetReferences(cDOInquiry, (CDOInquiry_Parameters) null, (CDOInquiry_Request) null, out CDOInquiry_Result _);
    }

    public ResultStatus GetReferences(
      CDOInquiry cDOInquiry,
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      return this.GetReferences(cDOInquiry, (CDOInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CDOInquiry cDOInquiry,
      CDOInquiry_Parameters parameters,
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      result = (CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) cDOInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICDOInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, cDOInquiry, parameters, request, out result) : this.AddMethod((Method) new CDOInquiryMethod(cDOInquiry, CDOInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) cDOInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CDOInquiry) null, (CDOInquiry_Parameters) null, (CDOInquiry_Request) null, out CDOInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(CDOInquiry cDOInquiry)
    {
      return this.GetWIPMsgs(cDOInquiry, (CDOInquiry_Parameters) null, (CDOInquiry_Request) null, out CDOInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CDOInquiry cDOInquiry,
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      return this.GetWIPMsgs(cDOInquiry, (CDOInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject cDOInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CDOInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CDOInquiry) cDOInquiry, (CDOInquiry_Parameters) parameters, (CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      result = (CDOInquiry_Result) null;
      try
      {
        CDOInquiryMethod[] methods = new CDOInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICDOInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CDOInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CDOInquiry cdo,
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      result = (CDOInquiry_Result) null;
      try
      {
        return ((ICDOInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CDOInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((CDOInquiry) cdo, (CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      return this.GetEnvironment((CDOInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CDOInquiry cdo,
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      result = (CDOInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICDOInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CDOInquiryMethod(cdo, CDOInquiryMethods.ExecuteTransaction, (CDOInquiry_Parameters) null));
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
        CDOInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CDOInquiry) cdo, (CDOInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CDOInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (CDOInquiry_Request) null, out CDOInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CDOInquiry_Request request,
      out CDOInquiry_Result result)
    {
      return this.ExecuteTransaction((CDOInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CDOInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CDOInquiryMethod(cdo, CDOInquiryMethods.AddDataTransaction, (CDOInquiry_Parameters) null));
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
        return this.AddDataTransaction((CDOInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
