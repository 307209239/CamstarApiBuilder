// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateService : ServiceBase
  {
    public UpdateService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      Update update,
      Update_Parameters parameters,
      Update_Request request,
      out Update_Result result)
    {
      result = (Update_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) update, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateService) this._Channel).GetWIPMsgs(this._UserProfile, update, parameters, request, out result) : this.AddMethod((Method) new UpdateMethod(update, UpdateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) update, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Update) null, (Update_Parameters) null, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus GetWIPMsgs(Update update)
    {
      return this.GetWIPMsgs(update, (Update_Parameters) null, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Update update,
      Update_Request request,
      out Update_Result result)
    {
      return this.GetWIPMsgs(update, (Update_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Update update,
      Update_Parameters parameters,
      Update_Request request,
      out Update_Result result)
    {
      result = (Update_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) update, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateService) this._Channel).Load(this._UserProfile, update, parameters, request, out result) : this.AddMethod((Method) new UpdateMethod(update, UpdateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) update, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Update) null, (Update_Parameters) null, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus Load(Update update)
    {
      return this.Load(update, (Update_Parameters) null, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus Load(
      Update update,
      Update_Request request,
      out Update_Result result)
    {
      return this.Load(update, (Update_Parameters) null, request, out result);
    }

    public ResultStatus WriteTxnGUID(
      Update update,
      Update_Parameters parameters,
      Update_Request request,
      out Update_Result result)
    {
      result = (Update_Result) null;
      this.OnBeforeCall(nameof (WriteTxnGUID), (DCObject) update, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateService) this._Channel).WriteTxnGUID(this._UserProfile, update, parameters, request, out result) : this.AddMethod((Method) new UpdateMethod(update, UpdateMethods.WriteTxnGUID, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (WriteTxnGUID), res, (DCObject) update, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus WriteTxnGUID()
    {
      return this.WriteTxnGUID((Update) null, (Update_Parameters) null, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus WriteTxnGUID(Update update)
    {
      return this.WriteTxnGUID(update, (Update_Parameters) null, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus WriteTxnGUID(
      Update update,
      Update_Request request,
      out Update_Result result)
    {
      return this.WriteTxnGUID(update, (Update_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject update,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Update_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Update) update, (Update_Parameters) parameters, (Update_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Update_Request request,
      out Update_Result result)
    {
      result = (Update_Result) null;
      try
      {
        UpdateMethod[] methods = new UpdateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Update_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Update_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Update cdo,
      Update_Request request,
      out Update_Result result)
    {
      result = (Update_Result) null;
      try
      {
        return ((IUpdateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Update_Result result1;
        ResultStatus environment = this.GetEnvironment((Update) cdo, (Update_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Update_Request request, out Update_Result result)
    {
      return this.GetEnvironment((Update) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Update cdo,
      Update_Request request,
      out Update_Result result)
    {
      result = (Update_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateMethod(cdo, UpdateMethods.ExecuteTransaction, (Update_Parameters) null));
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
        Update_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Update) cdo, (Update_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Update cdo)
    {
      return this.ExecuteTransaction(cdo, (Update_Request) null, out Update_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Update_Request request,
      out Update_Result result)
    {
      return this.ExecuteTransaction((Update) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Update cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateMethod(cdo, UpdateMethods.AddDataTransaction, (Update_Parameters) null));
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
        return this.AddDataTransaction((Update) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
