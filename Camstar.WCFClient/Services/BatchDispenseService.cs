// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BatchDispenseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BatchDispenseService : ComponentIssueBase
  {
    public BatchDispenseService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBatchDispenseService), userProfile);
    }

    public ResultStatus CreateParametricData(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).CreateParametricData(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus CreateParametricData(BatchDispense batchDispense)
    {
      return this.CreateParametricData(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus CreateParametricData(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.CreateParametricData(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).GetActions(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetActions(BatchDispense batchDispense)
    {
      return this.GetActions(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetActions(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.GetActions(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).GetDataPoints(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetDataPoints(BatchDispense batchDispense)
    {
      return this.GetDataPoints(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetDataPoints(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.GetDataPoints(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus GetMaterialSelectionValues(
      BatchDispense batchDispense,
      BatchDispense_GetMaterialSelectionValues_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (GetMaterialSelectionValues), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).GetMaterialSelectionValues(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.GetMaterialSelectionValues, (BatchDispense_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetMaterialSelectionValues), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetMaterialSelectionValues()
    {
      return this.GetMaterialSelectionValues((BatchDispense) null, (BatchDispense_GetMaterialSelectionValues_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetMaterialSelectionValues(BatchDispense batchDispense)
    {
      return this.GetMaterialSelectionValues(batchDispense, (BatchDispense_GetMaterialSelectionValues_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetMaterialSelectionValues(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.GetMaterialSelectionValues(batchDispense, (BatchDispense_GetMaterialSelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).GetWIPMsgs(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetWIPMsgs(BatchDispense batchDispense)
    {
      return this.GetWIPMsgs(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.GetWIPMsgs(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).Load(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus Load(BatchDispense batchDispense)
    {
      return this.Load(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus Load(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.Load(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BatchDispense batchDispense,
      BatchDispense_LoadESigDetails_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).LoadESigDetails(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.LoadESigDetails, (BatchDispense_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BatchDispense) null, (BatchDispense_LoadESigDetails_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus LoadESigDetails(BatchDispense batchDispense)
    {
      return this.LoadESigDetails(batchDispense, (BatchDispense_LoadESigDetails_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus LoadESigDetails(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.LoadESigDetails(batchDispense, (BatchDispense_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).ProcessComputation(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ProcessComputation(BatchDispense batchDispense)
    {
      return this.ProcessComputation(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ProcessComputation(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.ProcessComputation(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).ResolveParametricData(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BatchDispense) null, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ResolveParametricData(BatchDispense batchDispense)
    {
      return this.ResolveParametricData(batchDispense, (BatchDispense_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ResolveParametricData(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.ResolveParametricData(batchDispense, (BatchDispense_Parameters) null, request, out result);
    }

    public ResultStatus ValidateUOM(
      BatchDispense batchDispense,
      BatchDispense_ValidateUOM_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (ValidateUOM), (DCObject) batchDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).ValidateUOM(this._UserProfile, batchDispense, parameters, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(batchDispense, BatchDispenseMethods.ValidateUOM, (BatchDispense_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateUOM), res, (DCObject) batchDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateUOM()
    {
      return this.ValidateUOM((BatchDispense) null, (BatchDispense_ValidateUOM_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ValidateUOM(BatchDispense batchDispense)
    {
      return this.ValidateUOM(batchDispense, (BatchDispense_ValidateUOM_Parameters) null, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ValidateUOM(
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.ValidateUOM(batchDispense, (BatchDispense_ValidateUOM_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus actions = this.GetActions((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BatchDispense) batchDispense, (BatchDispense_LoadESigDetails_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus resultStatus = this.Load((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject batchDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BatchDispense_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BatchDispense) batchDispense, (BatchDispense_Parameters) parameters, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      try
      {
        BatchDispenseMethod[] methods = new BatchDispenseMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBatchDispenseService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BatchDispense_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BatchDispense cdo,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      try
      {
        return ((IBatchDispenseService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BatchDispense_Result result1;
        ResultStatus environment = this.GetEnvironment((BatchDispense) cdo, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.GetEnvironment((BatchDispense) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BatchDispense cdo,
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      result = (BatchDispense_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBatchDispenseService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BatchDispenseMethod(cdo, BatchDispenseMethods.ExecuteTransaction, (BatchDispense_Parameters) null));
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
        BatchDispense_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BatchDispense) cdo, (BatchDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BatchDispense cdo)
    {
      return this.ExecuteTransaction(cdo, (BatchDispense_Request) null, out BatchDispense_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BatchDispense_Request request,
      out BatchDispense_Result result)
    {
      return this.ExecuteTransaction((BatchDispense) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BatchDispense cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BatchDispenseMethod(cdo, BatchDispenseMethods.AddDataTransaction, (BatchDispense_Parameters) null));
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
        return this.AddDataTransaction((BatchDispense) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
