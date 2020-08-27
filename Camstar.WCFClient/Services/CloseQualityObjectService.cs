// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CloseQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CloseQualityObjectService : QualityTxnBase
  {
    public CloseQualityObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICloseQualityObjectService), userProfile);
    }

    public ResultStatus CloseMfgNCR(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (CloseMfgNCR), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).CloseMfgNCR(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.CloseMfgNCR, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CloseMfgNCR), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CloseMfgNCR()
    {
      return this.CloseMfgNCR((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus CloseMfgNCR(CloseQualityObject closeQualityObject)
    {
      return this.CloseMfgNCR(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus CloseMfgNCR(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.CloseMfgNCR(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).CreateParametricData(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(CloseQualityObject closeQualityObject)
    {
      return this.CreateParametricData(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.CreateParametricData(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteChecklist(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteChecklist), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).ExecuteChecklist(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.ExecuteChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteChecklist), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteChecklist()
    {
      return this.ExecuteChecklist((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ExecuteChecklist(CloseQualityObject closeQualityObject)
    {
      return this.ExecuteChecklist(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ExecuteChecklist(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.ExecuteChecklist(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).GetActions(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus GetActions(CloseQualityObject closeQualityObject)
    {
      return this.GetActions(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus GetActions(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.GetActions(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).GetDataPoints(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(CloseQualityObject closeQualityObject)
    {
      return this.GetDataPoints(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.GetDataPoints(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).GetWIPMsgs(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(CloseQualityObject closeQualityObject)
    {
      return this.GetWIPMsgs(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.GetWIPMsgs(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).Load(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus Load(CloseQualityObject closeQualityObject)
    {
      return this.Load(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus Load(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.Load(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).LoadESigDetails(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(CloseQualityObject closeQualityObject)
    {
      return this.LoadESigDetails(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.LoadESigDetails(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).ProcessComputation(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(CloseQualityObject closeQualityObject)
    {
      return this.ProcessComputation(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.ProcessComputation(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).ResolveParametricData(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(CloseQualityObject closeQualityObject)
    {
      return this.ResolveParametricData(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.ResolveParametricData(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ValidateClose(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (ValidateClose), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).ValidateClose(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.ValidateClose, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateClose), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateClose()
    {
      return this.ValidateClose((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ValidateClose(CloseQualityObject closeQualityObject)
    {
      return this.ValidateClose(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ValidateClose(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.ValidateClose(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ValidateDispositions(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (ValidateDispositions), (DCObject) closeQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).ValidateDispositions(this._UserProfile, closeQualityObject, parameters, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(closeQualityObject, CloseQualityObjectMethods.ValidateDispositions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateDispositions), res, (DCObject) closeQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateDispositions()
    {
      return this.ValidateDispositions((CloseQualityObject) null, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ValidateDispositions(CloseQualityObject closeQualityObject)
    {
      return this.ValidateDispositions(closeQualityObject, (CloseQualityObject_Parameters) null, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ValidateDispositions(
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.ValidateDispositions(closeQualityObject, (CloseQualityObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus actions = this.GetActions((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus resultStatus = this.Load((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject closeQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CloseQualityObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CloseQualityObject) closeQualityObject, (CloseQualityObject_Parameters) parameters, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      try
      {
        CloseQualityObjectMethod[] methods = new CloseQualityObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICloseQualityObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CloseQualityObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CloseQualityObject cdo,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      try
      {
        return ((ICloseQualityObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CloseQualityObject_Result result1;
        ResultStatus environment = this.GetEnvironment((CloseQualityObject) cdo, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.GetEnvironment((CloseQualityObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CloseQualityObject cdo,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      result = (CloseQualityObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICloseQualityObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CloseQualityObjectMethod(cdo, CloseQualityObjectMethods.ExecuteTransaction, (CloseQualityObject_Parameters) null));
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
        CloseQualityObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CloseQualityObject) cdo, (CloseQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CloseQualityObject cdo)
    {
      return this.ExecuteTransaction(cdo, (CloseQualityObject_Request) null, out CloseQualityObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result)
    {
      return this.ExecuteTransaction((CloseQualityObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CloseQualityObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CloseQualityObjectMethod(cdo, CloseQualityObjectMethods.AddDataTransaction, (CloseQualityObject_Parameters) null));
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
        return this.AddDataTransaction((CloseQualityObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
