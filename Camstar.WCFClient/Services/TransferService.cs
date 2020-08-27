// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TransferService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TransferService : MoveNonStdBase
  {
    public TransferService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITransferService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).CreateParametricData(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus CreateParametricData(Transfer transfer)
    {
      return this.CreateParametricData(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus CreateParametricData(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.CreateParametricData(transfer, (Transfer_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).GetActions(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus GetActions(Transfer transfer)
    {
      return this.GetActions(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus GetActions(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.GetActions(transfer, (Transfer_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).GetDataPoints(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus GetDataPoints(Transfer transfer)
    {
      return this.GetDataPoints(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus GetDataPoints(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.GetDataPoints(transfer, (Transfer_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).GetWIPMsgs(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus GetWIPMsgs(Transfer transfer)
    {
      return this.GetWIPMsgs(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.GetWIPMsgs(transfer, (Transfer_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).Load(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus Load(Transfer transfer)
    {
      return this.Load(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus Load(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.Load(transfer, (Transfer_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Transfer transfer,
      Transfer_LoadESigDetails_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).LoadESigDetails(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.LoadESigDetails, (Transfer_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Transfer) null, (Transfer_LoadESigDetails_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus LoadESigDetails(Transfer transfer)
    {
      return this.LoadESigDetails(transfer, (Transfer_LoadESigDetails_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus LoadESigDetails(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.LoadESigDetails(transfer, (Transfer_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).ProcessComputation(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus ProcessComputation(Transfer transfer)
    {
      return this.ProcessComputation(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus ProcessComputation(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.ProcessComputation(transfer, (Transfer_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Transfer transfer,
      Transfer_Parameters parameters,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) transfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).ResolveParametricData(this._UserProfile, transfer, parameters, request, out result) : this.AddMethod((Method) new TransferMethod(transfer, TransferMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) transfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Transfer) null, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus ResolveParametricData(Transfer transfer)
    {
      return this.ResolveParametricData(transfer, (Transfer_Parameters) null, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus ResolveParametricData(
      Transfer transfer,
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.ResolveParametricData(transfer, (Transfer_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus actions = this.GetActions((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Transfer) transfer, (Transfer_LoadESigDetails_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus resultStatus = this.Load((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject transfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Transfer_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Transfer) transfer, (Transfer_Parameters) parameters, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      try
      {
        TransferMethod[] methods = new TransferMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITransferService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Transfer_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Transfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Transfer cdo,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      try
      {
        return ((ITransferService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Transfer_Result result1;
        ResultStatus environment = this.GetEnvironment((Transfer) cdo, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.GetEnvironment((Transfer) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Transfer cdo,
      Transfer_Request request,
      out Transfer_Result result)
    {
      result = (Transfer_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITransferService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TransferMethod(cdo, TransferMethods.ExecuteTransaction, (Transfer_Parameters) null));
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
        Transfer_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Transfer) cdo, (Transfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Transfer cdo)
    {
      return this.ExecuteTransaction(cdo, (Transfer_Request) null, out Transfer_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Transfer_Request request,
      out Transfer_Result result)
    {
      return this.ExecuteTransaction((Transfer) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Transfer cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TransferMethod(cdo, TransferMethods.AddDataTransaction, (Transfer_Parameters) null));
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
        return this.AddDataTransaction((Transfer) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
