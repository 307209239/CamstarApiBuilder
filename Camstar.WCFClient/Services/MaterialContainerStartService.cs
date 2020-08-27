// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaterialContainerStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaterialContainerStartService : StartBase
  {
    public MaterialContainerStartService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaterialContainerStartService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).CreateParametricData(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus CreateParametricData(
      MaterialContainerStart materialContainerStart)
    {
      return this.CreateParametricData(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus CreateParametricData(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.CreateParametricData(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).GetActions(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus GetActions(MaterialContainerStart materialContainerStart)
    {
      return this.GetActions(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus GetActions(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.GetActions(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).GetDataPoints(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus GetDataPoints(MaterialContainerStart materialContainerStart)
    {
      return this.GetDataPoints(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus GetDataPoints(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.GetDataPoints(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).GetWIPMsgs(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus GetWIPMsgs(MaterialContainerStart materialContainerStart)
    {
      return this.GetWIPMsgs(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.GetWIPMsgs(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).Load(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus Load(MaterialContainerStart materialContainerStart)
    {
      return this.Load(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus Load(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.Load(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_LoadESigDetails_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).LoadESigDetails(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.LoadESigDetails, (MaterialContainerStart_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaterialContainerStart) null, (MaterialContainerStart_LoadESigDetails_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus LoadESigDetails(MaterialContainerStart materialContainerStart)
    {
      return this.LoadESigDetails(materialContainerStart, (MaterialContainerStart_LoadESigDetails_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.LoadESigDetails(materialContainerStart, (MaterialContainerStart_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).ProcessComputation(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ProcessComputation(MaterialContainerStart materialContainerStart)
    {
      return this.ProcessComputation(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ProcessComputation(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.ProcessComputation(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).ResolveParametricData(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ResolveParametricData(
      MaterialContainerStart materialContainerStart)
    {
      return this.ResolveParametricData(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ResolveParametricData(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.ResolveParametricData(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    public ResultStatus ValidateBatchStatus(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (ValidateBatchStatus), (DCObject) materialContainerStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).ValidateBatchStatus(this._UserProfile, materialContainerStart, parameters, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(materialContainerStart, MaterialContainerStartMethods.ValidateBatchStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateBatchStatus), res, (DCObject) materialContainerStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateBatchStatus()
    {
      return this.ValidateBatchStatus((MaterialContainerStart) null, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ValidateBatchStatus(
      MaterialContainerStart materialContainerStart)
    {
      return this.ValidateBatchStatus(materialContainerStart, (MaterialContainerStart_Parameters) null, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ValidateBatchStatus(
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.ValidateBatchStatus(materialContainerStart, (MaterialContainerStart_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus actions = this.GetActions((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_LoadESigDetails_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus resultStatus = this.Load((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject materialContainerStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaterialContainerStart_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaterialContainerStart) materialContainerStart, (MaterialContainerStart_Parameters) parameters, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      try
      {
        MaterialContainerStartMethod[] methods = new MaterialContainerStartMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaterialContainerStartService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaterialContainerStart_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaterialContainerStart cdo,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      try
      {
        return ((IMaterialContainerStartService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaterialContainerStart_Result result1;
        ResultStatus environment = this.GetEnvironment((MaterialContainerStart) cdo, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.GetEnvironment((MaterialContainerStart) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaterialContainerStart cdo,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      result = (MaterialContainerStart_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaterialContainerStartService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaterialContainerStartMethod(cdo, MaterialContainerStartMethods.ExecuteTransaction, (MaterialContainerStart_Parameters) null));
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
        MaterialContainerStart_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaterialContainerStart) cdo, (MaterialContainerStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaterialContainerStart cdo)
    {
      return this.ExecuteTransaction(cdo, (MaterialContainerStart_Request) null, out MaterialContainerStart_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result)
    {
      return this.ExecuteTransaction((MaterialContainerStart) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaterialContainerStart cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaterialContainerStartMethod(cdo, MaterialContainerStartMethods.AddDataTransaction, (MaterialContainerStart_Parameters) null));
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
        return this.AddDataTransaction((MaterialContainerStart) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
