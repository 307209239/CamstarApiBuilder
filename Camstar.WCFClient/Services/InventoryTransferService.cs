// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.InventoryTransferService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class InventoryTransferService : TransferBase
  {
    public InventoryTransferService(UserProfile userProfile)
    {
      this.Initialize(typeof (IInventoryTransferService), userProfile);
    }

    public ResultStatus CreateParametricData(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).CreateParametricData(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus CreateParametricData(InventoryTransfer inventoryTransfer)
    {
      return this.CreateParametricData(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus CreateParametricData(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.CreateParametricData(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).GetActions(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus GetActions(InventoryTransfer inventoryTransfer)
    {
      return this.GetActions(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus GetActions(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.GetActions(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).GetDataPoints(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus GetDataPoints(InventoryTransfer inventoryTransfer)
    {
      return this.GetDataPoints(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus GetDataPoints(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.GetDataPoints(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).GetWIPMsgs(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus GetWIPMsgs(InventoryTransfer inventoryTransfer)
    {
      return this.GetWIPMsgs(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus GetWIPMsgs(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.GetWIPMsgs(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).Load(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus Load(InventoryTransfer inventoryTransfer)
    {
      return this.Load(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus Load(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.Load(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_LoadESigDetails_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).LoadESigDetails(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.LoadESigDetails, (InventoryTransfer_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((InventoryTransfer) null, (InventoryTransfer_LoadESigDetails_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus LoadESigDetails(InventoryTransfer inventoryTransfer)
    {
      return this.LoadESigDetails(inventoryTransfer, (InventoryTransfer_LoadESigDetails_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus LoadESigDetails(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.LoadESigDetails(inventoryTransfer, (InventoryTransfer_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).ProcessComputation(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus ProcessComputation(InventoryTransfer inventoryTransfer)
    {
      return this.ProcessComputation(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus ProcessComputation(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.ProcessComputation(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).ResolveParametricData(this._UserProfile, inventoryTransfer, parameters, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(inventoryTransfer, InventoryTransferMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) inventoryTransfer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((InventoryTransfer) null, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus ResolveParametricData(InventoryTransfer inventoryTransfer)
    {
      return this.ResolveParametricData(inventoryTransfer, (InventoryTransfer_Parameters) null, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus ResolveParametricData(
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.ResolveParametricData(inventoryTransfer, (InventoryTransfer_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus parametricData = this.CreateParametricData((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus actions = this.GetActions((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((InventoryTransfer) inventoryTransfer, (InventoryTransfer_LoadESigDetails_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus resultStatus = this.Load((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject inventoryTransfer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InventoryTransfer_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((InventoryTransfer) inventoryTransfer, (InventoryTransfer_Parameters) parameters, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      try
      {
        InventoryTransferMethod[] methods = new InventoryTransferMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IInventoryTransferService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        InventoryTransfer_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      InventoryTransfer cdo,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      try
      {
        return ((IInventoryTransferService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        InventoryTransfer_Result result1;
        ResultStatus environment = this.GetEnvironment((InventoryTransfer) cdo, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.GetEnvironment((InventoryTransfer) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      InventoryTransfer cdo,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      result = (InventoryTransfer_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInventoryTransferService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new InventoryTransferMethod(cdo, InventoryTransferMethods.ExecuteTransaction, (InventoryTransfer_Parameters) null));
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
        InventoryTransfer_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((InventoryTransfer) cdo, (InventoryTransfer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(InventoryTransfer cdo)
    {
      return this.ExecuteTransaction(cdo, (InventoryTransfer_Request) null, out InventoryTransfer_Result _);
    }

    public ResultStatus ExecuteTransaction(
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result)
    {
      return this.ExecuteTransaction((InventoryTransfer) null, request, out result);
    }

    public ResultStatus AddDataTransaction(InventoryTransfer cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new InventoryTransferMethod(cdo, InventoryTransferMethods.AddDataTransaction, (InventoryTransfer_Parameters) null));
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
        return this.AddDataTransaction((InventoryTransfer) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
