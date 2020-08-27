// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BatchInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BatchInquiryService : InquiryBase
  {
    public BatchInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBatchInquiryService), userProfile);
    }

    public ResultStatus GetMaterialContainers(
      BatchInquiry batchInquiry,
      BatchInquiry_Parameters parameters,
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      result = (BatchInquiry_Result) null;
      this.OnBeforeCall(nameof (GetMaterialContainers), (DCObject) batchInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchInquiryService) this._Channel).GetMaterialContainers(this._UserProfile, batchInquiry, parameters, request, out result) : this.AddMethod((Method) new BatchInquiryMethod(batchInquiry, BatchInquiryMethods.GetMaterialContainers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetMaterialContainers), res, (DCObject) batchInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetMaterialContainers()
    {
      return this.GetMaterialContainers((BatchInquiry) null, (BatchInquiry_Parameters) null, (BatchInquiry_Request) null, out BatchInquiry_Result _);
    }

    public ResultStatus GetMaterialContainers(BatchInquiry batchInquiry)
    {
      return this.GetMaterialContainers(batchInquiry, (BatchInquiry_Parameters) null, (BatchInquiry_Request) null, out BatchInquiry_Result _);
    }

    public ResultStatus GetMaterialContainers(
      BatchInquiry batchInquiry,
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      return this.GetMaterialContainers(batchInquiry, (BatchInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BatchInquiry batchInquiry,
      BatchInquiry_Parameters parameters,
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      result = (BatchInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) batchInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, batchInquiry, parameters, request, out result) : this.AddMethod((Method) new BatchInquiryMethod(batchInquiry, BatchInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) batchInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BatchInquiry) null, (BatchInquiry_Parameters) null, (BatchInquiry_Request) null, out BatchInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(BatchInquiry batchInquiry)
    {
      return this.GetWIPMsgs(batchInquiry, (BatchInquiry_Parameters) null, (BatchInquiry_Request) null, out BatchInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BatchInquiry batchInquiry,
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      return this.GetWIPMsgs(batchInquiry, (BatchInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject batchInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BatchInquiry) batchInquiry, (BatchInquiry_Parameters) parameters, (BatchInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      result = (BatchInquiry_Result) null;
      try
      {
        BatchInquiryMethod[] methods = new BatchInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBatchInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BatchInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BatchInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BatchInquiry cdo,
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      result = (BatchInquiry_Result) null;
      try
      {
        return ((IBatchInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BatchInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((BatchInquiry) cdo, (BatchInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      return this.GetEnvironment((BatchInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BatchInquiry cdo,
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      result = (BatchInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BatchInquiryMethod(cdo, BatchInquiryMethods.ExecuteTransaction, (BatchInquiry_Parameters) null));
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
        BatchInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BatchInquiry) cdo, (BatchInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BatchInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (BatchInquiry_Request) null, out BatchInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BatchInquiry_Request request,
      out BatchInquiry_Result result)
    {
      return this.ExecuteTransaction((BatchInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BatchInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BatchInquiryMethod(cdo, BatchInquiryMethods.AddDataTransaction, (BatchInquiry_Parameters) null));
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
        return this.AddDataTransaction((BatchInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
