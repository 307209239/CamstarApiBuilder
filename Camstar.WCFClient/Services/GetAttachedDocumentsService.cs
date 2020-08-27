// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetAttachedDocumentsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetAttachedDocumentsService : InquiryBase
  {
    public GetAttachedDocumentsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetAttachedDocumentsService), userProfile);
    }

    public ResultStatus GetAttachedDocuments_GetDocs(
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Parameters parameters,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      result = (GetAttachedDocuments_Result) null;
      this.OnBeforeCall(nameof (GetAttachedDocuments_GetDocs), (DCObject) getAttachedDocuments, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetAttachedDocumentsService) this._Channel).GetAttachedDocuments_GetDocs(this._UserProfile, getAttachedDocuments, parameters, request, out result) : this.AddMethod((Method) new GetAttachedDocumentsMethod(getAttachedDocuments, GetAttachedDocumentsMethods.GetAttachedDocuments_GetDocs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttachedDocuments_GetDocs), res, (DCObject) getAttachedDocuments, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttachedDocuments_GetDocs()
    {
      return this.GetAttachedDocuments_GetDocs((GetAttachedDocuments) null, (GetAttachedDocuments_Parameters) null, (GetAttachedDocuments_Request) null, out GetAttachedDocuments_Result _);
    }

    public ResultStatus GetAttachedDocuments_GetDocs(
      GetAttachedDocuments getAttachedDocuments)
    {
      return this.GetAttachedDocuments_GetDocs(getAttachedDocuments, (GetAttachedDocuments_Parameters) null, (GetAttachedDocuments_Request) null, out GetAttachedDocuments_Result _);
    }

    public ResultStatus GetAttachedDocuments_GetDocs(
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      return this.GetAttachedDocuments_GetDocs(getAttachedDocuments, (GetAttachedDocuments_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Parameters parameters,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      result = (GetAttachedDocuments_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getAttachedDocuments, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetAttachedDocumentsService) this._Channel).GetWIPMsgs(this._UserProfile, getAttachedDocuments, parameters, request, out result) : this.AddMethod((Method) new GetAttachedDocumentsMethod(getAttachedDocuments, GetAttachedDocumentsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getAttachedDocuments, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GetAttachedDocuments) null, (GetAttachedDocuments_Parameters) null, (GetAttachedDocuments_Request) null, out GetAttachedDocuments_Result _);
    }

    public ResultStatus GetWIPMsgs(GetAttachedDocuments getAttachedDocuments)
    {
      return this.GetWIPMsgs(getAttachedDocuments, (GetAttachedDocuments_Parameters) null, (GetAttachedDocuments_Request) null, out GetAttachedDocuments_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GetAttachedDocuments getAttachedDocuments,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      return this.GetWIPMsgs(getAttachedDocuments, (GetAttachedDocuments_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getAttachedDocuments,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetAttachedDocuments_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GetAttachedDocuments) getAttachedDocuments, (GetAttachedDocuments_Parameters) parameters, (GetAttachedDocuments_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      result = (GetAttachedDocuments_Result) null;
      try
      {
        GetAttachedDocumentsMethod[] methods = new GetAttachedDocumentsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetAttachedDocumentsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetAttachedDocuments_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetAttachedDocuments_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetAttachedDocuments cdo,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      result = (GetAttachedDocuments_Result) null;
      try
      {
        return ((IGetAttachedDocumentsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetAttachedDocuments_Result result1;
        ResultStatus environment = this.GetEnvironment((GetAttachedDocuments) cdo, (GetAttachedDocuments_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      return this.GetEnvironment((GetAttachedDocuments) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GetAttachedDocuments cdo,
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      result = (GetAttachedDocuments_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetAttachedDocumentsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetAttachedDocumentsMethod(cdo, GetAttachedDocumentsMethods.ExecuteTransaction, (GetAttachedDocuments_Parameters) null));
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
        GetAttachedDocuments_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GetAttachedDocuments) cdo, (GetAttachedDocuments_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GetAttachedDocuments cdo)
    {
      return this.ExecuteTransaction(cdo, (GetAttachedDocuments_Request) null, out GetAttachedDocuments_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetAttachedDocuments_Request request,
      out GetAttachedDocuments_Result result)
    {
      return this.ExecuteTransaction((GetAttachedDocuments) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GetAttachedDocuments cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetAttachedDocumentsMethod(cdo, GetAttachedDocumentsMethods.AddDataTransaction, (GetAttachedDocuments_Parameters) null));
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
        return this.AddDataTransaction((GetAttachedDocuments) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
