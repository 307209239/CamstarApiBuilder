// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeMgtTxnService : ShopFloorBase
  {
    public ChangeMgtTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeMgtTxnService), userProfile);
    }

    public ResultStatus BuildEmptySelectionValues(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_BuildEmptySelectionValues_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (BuildEmptySelectionValues), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).BuildEmptySelectionValues(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.BuildEmptySelectionValues, (ChangeMgtTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (BuildEmptySelectionValues), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus BuildEmptySelectionValues()
    {
      return this.BuildEmptySelectionValues((ChangeMgtTxn) null, (ChangeMgtTxn_BuildEmptySelectionValues_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus BuildEmptySelectionValues(ChangeMgtTxn changeMgtTxn)
    {
      return this.BuildEmptySelectionValues(changeMgtTxn, (ChangeMgtTxn_BuildEmptySelectionValues_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus BuildEmptySelectionValues(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.BuildEmptySelectionValues(changeMgtTxn, (ChangeMgtTxn_BuildEmptySelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).CreateParametricData(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus CreateParametricData(ChangeMgtTxn changeMgtTxn)
    {
      return this.CreateParametricData(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.CreateParametricData(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus DoesPermissionExistInRole(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_DoesPermissionExistInRole_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (DoesPermissionExistInRole), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).DoesPermissionExistInRole(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.DoesPermissionExistInRole, (ChangeMgtTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DoesPermissionExistInRole), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DoesPermissionExistInRole()
    {
      return this.DoesPermissionExistInRole((ChangeMgtTxn) null, (ChangeMgtTxn_DoesPermissionExistInRole_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus DoesPermissionExistInRole(ChangeMgtTxn changeMgtTxn)
    {
      return this.DoesPermissionExistInRole(changeMgtTxn, (ChangeMgtTxn_DoesPermissionExistInRole_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus DoesPermissionExistInRole(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.DoesPermissionExistInRole(changeMgtTxn, (ChangeMgtTxn_DoesPermissionExistInRole_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).GetActions(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus GetActions(ChangeMgtTxn changeMgtTxn)
    {
      return this.GetActions(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus GetActions(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.GetActions(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).GetDataPoints(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus GetDataPoints(ChangeMgtTxn changeMgtTxn)
    {
      return this.GetDataPoints(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.GetDataPoints(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).GetWIPMsgs(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeMgtTxn changeMgtTxn)
    {
      return this.GetWIPMsgs(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.GetWIPMsgs(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).Load(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus Load(ChangeMgtTxn changeMgtTxn)
    {
      return this.Load(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus Load(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.Load(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_LoadESigDetails_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).LoadESigDetails(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.LoadESigDetails, (ChangeMgtTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeMgtTxn) null, (ChangeMgtTxn_LoadESigDetails_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeMgtTxn changeMgtTxn)
    {
      return this.LoadESigDetails(changeMgtTxn, (ChangeMgtTxn_LoadESigDetails_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.LoadESigDetails(changeMgtTxn, (ChangeMgtTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).ProcessComputation(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus ProcessComputation(ChangeMgtTxn changeMgtTxn)
    {
      return this.ProcessComputation(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.ProcessComputation(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).ResolveParametricData(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeMgtTxn changeMgtTxn)
    {
      return this.ResolveParametricData(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.ResolveParametricData(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    public ResultStatus SelectionValues_Validation(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (SelectionValues_Validation), (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).SelectionValues_Validation(this._UserProfile, changeMgtTxn, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(changeMgtTxn, ChangeMgtTxnMethods.SelectionValues_Validation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SelectionValues_Validation), res, (DCObject) changeMgtTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SelectionValues_Validation()
    {
      return this.SelectionValues_Validation((ChangeMgtTxn) null, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus SelectionValues_Validation(ChangeMgtTxn changeMgtTxn)
    {
      return this.SelectionValues_Validation(changeMgtTxn, (ChangeMgtTxn_Parameters) null, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus SelectionValues_Validation(
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.SelectionValues_Validation(changeMgtTxn, (ChangeMgtTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus actions = this.GetActions((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_LoadESigDetails_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus resultStatus = this.Load((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeMgtTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeMgtTxn) changeMgtTxn, (ChangeMgtTxn_Parameters) parameters, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      try
      {
        ChangeMgtTxnMethod[] methods = new ChangeMgtTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeMgtTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeMgtTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtTxn cdo,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      try
      {
        return ((IChangeMgtTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeMgtTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeMgtTxn) cdo, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.GetEnvironment((ChangeMgtTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtTxn cdo,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      result = (ChangeMgtTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeMgtTxnMethod(cdo, ChangeMgtTxnMethods.ExecuteTransaction, (ChangeMgtTxn_Parameters) null));
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
        ChangeMgtTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeMgtTxn) cdo, (ChangeMgtTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeMgtTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeMgtTxn_Request) null, out ChangeMgtTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result)
    {
      return this.ExecuteTransaction((ChangeMgtTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeMgtTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeMgtTxnMethod(cdo, ChangeMgtTxnMethods.AddDataTransaction, (ChangeMgtTxn_Parameters) null));
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
        return this.AddDataTransaction((ChangeMgtTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
