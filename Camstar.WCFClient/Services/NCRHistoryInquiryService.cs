// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRHistoryInquiryService : ContainerHistoryInquiryBase
  {
    public NCRHistoryInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRHistoryInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      NCRHistoryInquiry nCRHistoryInquiry,
      NCRHistoryInquiry_Parameters parameters,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      result = (NCRHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRHistoryInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, nCRHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new NCRHistoryInquiryMethod(nCRHistoryInquiry, NCRHistoryInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRHistoryInquiry) null, (NCRHistoryInquiry_Parameters) null, (NCRHistoryInquiry_Request) null, out NCRHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRHistoryInquiry nCRHistoryInquiry)
    {
      return this.GetWIPMsgs(nCRHistoryInquiry, (NCRHistoryInquiry_Parameters) null, (NCRHistoryInquiry_Request) null, out NCRHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRHistoryInquiry nCRHistoryInquiry,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      return this.GetWIPMsgs(nCRHistoryInquiry, (NCRHistoryInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRHistoryInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRHistoryInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRHistoryInquiry) nCRHistoryInquiry, (NCRHistoryInquiry_Parameters) parameters, (NCRHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      result = (NCRHistoryInquiry_Result) null;
      try
      {
        NCRHistoryInquiryMethod[] methods = new NCRHistoryInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRHistoryInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRHistoryInquiry cdo,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      result = (NCRHistoryInquiry_Result) null;
      try
      {
        return ((INCRHistoryInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRHistoryInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRHistoryInquiry) cdo, (NCRHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      return this.GetEnvironment((NCRHistoryInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRHistoryInquiry cdo,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      result = (NCRHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRHistoryInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRHistoryInquiryMethod(cdo, NCRHistoryInquiryMethods.ExecuteTransaction, (NCRHistoryInquiry_Parameters) null));
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
        NCRHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRHistoryInquiry) cdo, (NCRHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRHistoryInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRHistoryInquiry_Request) null, out NCRHistoryInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result)
    {
      return this.ExecuteTransaction((NCRHistoryInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRHistoryInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRHistoryInquiryMethod(cdo, NCRHistoryInquiryMethods.AddDataTransaction, (NCRHistoryInquiry_Parameters) null));
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
        return this.AddDataTransaction((NCRHistoryInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
