// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportImportTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExportImportTxnsService : UpdateBase
  {
    public ExportImportTxnsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExportImportTxnsService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Parameters parameters,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      result = (ExportImportTxns_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) exportImportTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportTxnsService) this._Channel).GetWIPMsgs(this._UserProfile, exportImportTxns, parameters, request, out result) : this.AddMethod((Method) new ExportImportTxnsMethod(exportImportTxns, ExportImportTxnsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) exportImportTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExportImportTxns) null, (ExportImportTxns_Parameters) null, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(ExportImportTxns exportImportTxns)
    {
      return this.GetWIPMsgs(exportImportTxns, (ExportImportTxns_Parameters) null, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      return this.GetWIPMsgs(exportImportTxns, (ExportImportTxns_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Parameters parameters,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      result = (ExportImportTxns_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) exportImportTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportTxnsService) this._Channel).Load(this._UserProfile, exportImportTxns, parameters, request, out result) : this.AddMethod((Method) new ExportImportTxnsMethod(exportImportTxns, ExportImportTxnsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) exportImportTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ExportImportTxns) null, (ExportImportTxns_Parameters) null, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus Load(ExportImportTxns exportImportTxns)
    {
      return this.Load(exportImportTxns, (ExportImportTxns_Parameters) null, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus Load(
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      return this.Load(exportImportTxns, (ExportImportTxns_Parameters) null, request, out result);
    }

    public ResultStatus SetCompletionMessage(
      ExportImportTxns exportImportTxns,
      ExportImportTxns_SetCompletionMessage_Parameters parameters,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      result = (ExportImportTxns_Result) null;
      this.OnBeforeCall(nameof (SetCompletionMessage), (DCObject) exportImportTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportTxnsService) this._Channel).SetCompletionMessage(this._UserProfile, exportImportTxns, parameters, request, out result) : this.AddMethod((Method) new ExportImportTxnsMethod(exportImportTxns, ExportImportTxnsMethods.SetCompletionMessage, (ExportImportTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCompletionMessage), res, (DCObject) exportImportTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCompletionMessage()
    {
      return this.SetCompletionMessage((ExportImportTxns) null, (ExportImportTxns_SetCompletionMessage_Parameters) null, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus SetCompletionMessage(ExportImportTxns exportImportTxns)
    {
      return this.SetCompletionMessage(exportImportTxns, (ExportImportTxns_SetCompletionMessage_Parameters) null, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus SetCompletionMessage(
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      return this.SetCompletionMessage(exportImportTxns, (ExportImportTxns_SetCompletionMessage_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject exportImportTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportTxns_Result result1;
        ResultStatus resultStatus = this.Load((ExportImportTxns) exportImportTxns, (ExportImportTxns_Parameters) parameters, (ExportImportTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject exportImportTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportTxns_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExportImportTxns) exportImportTxns, (ExportImportTxns_Parameters) parameters, (ExportImportTxns_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      result = (ExportImportTxns_Result) null;
      try
      {
        ExportImportTxnsMethod[] methods = new ExportImportTxnsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExportImportTxnsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ExportImportTxns_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExportImportTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportImportTxns cdo,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      result = (ExportImportTxns_Result) null;
      try
      {
        return ((IExportImportTxnsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ExportImportTxns_Result result1;
        ResultStatus environment = this.GetEnvironment((ExportImportTxns) cdo, (ExportImportTxns_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      return this.GetEnvironment((ExportImportTxns) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExportImportTxns cdo,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      result = (ExportImportTxns_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportTxnsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExportImportTxnsMethod(cdo, ExportImportTxnsMethods.ExecuteTransaction, (ExportImportTxns_Parameters) null));
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
        ExportImportTxns_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExportImportTxns) cdo, (ExportImportTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExportImportTxns cdo)
    {
      return this.ExecuteTransaction(cdo, (ExportImportTxns_Request) null, out ExportImportTxns_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result)
    {
      return this.ExecuteTransaction((ExportImportTxns) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExportImportTxns cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExportImportTxnsMethod(cdo, ExportImportTxnsMethods.AddDataTransaction, (ExportImportTxns_Parameters) null));
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
        return this.AddDataTransaction((ExportImportTxns) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
