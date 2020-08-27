// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DictionaryServiceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DictionaryServiceService : InquiryBase
  {
    public DictionaryServiceService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDictionaryServiceService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      DictionaryService dictionaryService,
      DictionaryService_Parameters parameters,
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      result = (DictionaryService_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dictionaryService, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryServiceService) this._Channel).GetWIPMsgs(this._UserProfile, dictionaryService, parameters, request, out result) : this.AddMethod((Method) new DictionaryServiceMethod(dictionaryService, DictionaryServiceMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dictionaryService, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DictionaryService) null, (DictionaryService_Parameters) null, (DictionaryService_Request) null, out DictionaryService_Result _);
    }

    public ResultStatus GetWIPMsgs(DictionaryService dictionaryService)
    {
      return this.GetWIPMsgs(dictionaryService, (DictionaryService_Parameters) null, (DictionaryService_Request) null, out DictionaryService_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DictionaryService dictionaryService,
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      return this.GetWIPMsgs(dictionaryService, (DictionaryService_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dictionaryService,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DictionaryService_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DictionaryService) dictionaryService, (DictionaryService_Parameters) parameters, (DictionaryService_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      result = (DictionaryService_Result) null;
      try
      {
        DictionaryServiceMethod[] methods = new DictionaryServiceMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDictionaryServiceService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DictionaryService_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DictionaryService_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DictionaryService cdo,
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      result = (DictionaryService_Result) null;
      try
      {
        return ((IDictionaryServiceService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DictionaryService_Result result1;
        ResultStatus environment = this.GetEnvironment((DictionaryService) cdo, (DictionaryService_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      return this.GetEnvironment((DictionaryService) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DictionaryService cdo,
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      result = (DictionaryService_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDictionaryServiceService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DictionaryServiceMethod(cdo, DictionaryServiceMethods.ExecuteTransaction, (DictionaryService_Parameters) null));
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
        DictionaryService_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DictionaryService) cdo, (DictionaryService_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DictionaryService cdo)
    {
      return this.ExecuteTransaction(cdo, (DictionaryService_Request) null, out DictionaryService_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DictionaryService_Request request,
      out DictionaryService_Result result)
    {
      return this.ExecuteTransaction((DictionaryService) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DictionaryService cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DictionaryServiceMethod(cdo, DictionaryServiceMethods.AddDataTransaction, (DictionaryService_Parameters) null));
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
        return this.AddDataTransaction((DictionaryService) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
