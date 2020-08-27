// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateCAPAService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateCAPAService : QualityTxnBase
  {
    public UpdateCAPAService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateCAPAService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).CreateParametricData(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus CreateParametricData(UpdateCAPA updateCAPA)
    {
      return this.CreateParametricData(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.CreateParametricData(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetActions(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetActions(UpdateCAPA updateCAPA)
    {
      return this.GetActions(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetActions(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetActions(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetApprovalSheetDetails(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(UpdateCAPA updateCAPA)
    {
      return this.GetApprovalSheetDetails(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetApprovalSheetDetails(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetCAPADetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetCAPADetails), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetCAPADetails(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetCAPADetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCAPADetails), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCAPADetails()
    {
      return this.GetCAPADetails((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetCAPADetails(UpdateCAPA updateCAPA)
    {
      return this.GetCAPADetails(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetCAPADetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetCAPADetails(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetCrossRefDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetCrossRefDetails), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetCrossRefDetails(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetCrossRefDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCrossRefDetails), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCrossRefDetails()
    {
      return this.GetCrossRefDetails((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetCrossRefDetails(UpdateCAPA updateCAPA)
    {
      return this.GetCrossRefDetails(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetCrossRefDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetCrossRefDetails(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetDataPoints(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetDataPoints(UpdateCAPA updateCAPA)
    {
      return this.GetDataPoints(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetDataPoints(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetDetails), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetDetails(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDetails), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDetails()
    {
      return this.GetDetails((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetDetails(UpdateCAPA updateCAPA)
    {
      return this.GetDetails(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetDetails(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).GetWIPMsgs(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateCAPA updateCAPA)
    {
      return this.GetWIPMsgs(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetWIPMsgs(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).Load(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus Load(UpdateCAPA updateCAPA)
    {
      return this.Load(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus Load(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.Load(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).LoadESigDetails(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateCAPA updateCAPA)
    {
      return this.LoadESigDetails(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.LoadESigDetails(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).ProcessComputation(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ProcessComputation(UpdateCAPA updateCAPA)
    {
      return this.ProcessComputation(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.ProcessComputation(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).ResolveParametricData(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateCAPA updateCAPA)
    {
      return this.ResolveParametricData(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.ResolveParametricData(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus SaveApprovalSheet(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (SaveApprovalSheet), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).SaveApprovalSheet(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.SaveApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveApprovalSheet), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveApprovalSheet()
    {
      return this.SaveApprovalSheet((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus SaveApprovalSheet(UpdateCAPA updateCAPA)
    {
      return this.SaveApprovalSheet(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus SaveApprovalSheet(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.SaveApprovalSheet(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus SubmitCAPA(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (SubmitCAPA), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).SubmitCAPA(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.SubmitCAPA, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SubmitCAPA), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SubmitCAPA()
    {
      return this.SubmitCAPA((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus SubmitCAPA(UpdateCAPA updateCAPA)
    {
      return this.SubmitCAPA(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus SubmitCAPA(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.SubmitCAPA(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ValidateOwner(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (ValidateOwner), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).ValidateOwner(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.ValidateOwner, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateOwner), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateOwner()
    {
      return this.ValidateOwner((UpdateCAPA) null, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ValidateOwner(UpdateCAPA updateCAPA)
    {
      return this.ValidateOwner(updateCAPA, (UpdateCAPA_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ValidateOwner(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.ValidateOwner(updateCAPA, (UpdateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ValidateServiceDetail(
      UpdateCAPA updateCAPA,
      UpdateCAPA_ValidateServiceDetail_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (ValidateServiceDetail), (DCObject) updateCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).ValidateServiceDetail(this._UserProfile, updateCAPA, parameters, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(updateCAPA, UpdateCAPAMethods.ValidateServiceDetail, (UpdateCAPA_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateServiceDetail), res, (DCObject) updateCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateServiceDetail()
    {
      return this.ValidateServiceDetail((UpdateCAPA) null, (UpdateCAPA_ValidateServiceDetail_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ValidateServiceDetail(UpdateCAPA updateCAPA)
    {
      return this.ValidateServiceDetail(updateCAPA, (UpdateCAPA_ValidateServiceDetail_Parameters) null, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ValidateServiceDetail(
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.ValidateServiceDetail(updateCAPA, (UpdateCAPA_ValidateServiceDetail_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus actions = this.GetActions((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus resultStatus = this.Load((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateCAPA_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateCAPA) updateCAPA, (UpdateCAPA_Parameters) parameters, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      try
      {
        UpdateCAPAMethod[] methods = new UpdateCAPAMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateCAPAService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateCAPA_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateCAPA cdo,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      try
      {
        return ((IUpdateCAPAService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateCAPA_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateCAPA) cdo, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.GetEnvironment((UpdateCAPA) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateCAPA cdo,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      result = (UpdateCAPA_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateCAPAService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateCAPAMethod(cdo, UpdateCAPAMethods.ExecuteTransaction, (UpdateCAPA_Parameters) null));
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
        UpdateCAPA_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateCAPA) cdo, (UpdateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateCAPA cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateCAPA_Request) null, out UpdateCAPA_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result)
    {
      return this.ExecuteTransaction((UpdateCAPA) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateCAPA cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateCAPAMethod(cdo, UpdateCAPAMethods.AddDataTransaction, (UpdateCAPA_Parameters) null));
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
        return this.AddDataTransaction((UpdateCAPA) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
