// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CreateCAPAService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CreateCAPAService : QualityTxnBase
  {
    public CreateCAPAService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICreateCAPAService), userProfile);
    }

    public ResultStatus AddHistoryCrossRefs(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (AddHistoryCrossRefs), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).AddHistoryCrossRefs(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.AddHistoryCrossRefs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddHistoryCrossRefs), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddHistoryCrossRefs()
    {
      return this.AddHistoryCrossRefs((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus AddHistoryCrossRefs(CreateCAPA createCAPA)
    {
      return this.AddHistoryCrossRefs(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus AddHistoryCrossRefs(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.AddHistoryCrossRefs(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).CreateParametricData(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus CreateParametricData(CreateCAPA createCAPA)
    {
      return this.CreateParametricData(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus CreateParametricData(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.CreateParametricData(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).GetActions(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetActions(CreateCAPA createCAPA)
    {
      return this.GetActions(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetActions(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.GetActions(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetCAPAName(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetCAPAName), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).GetCAPAName(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.GetCAPAName, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCAPAName), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCAPAName()
    {
      return this.GetCAPAName((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetCAPAName(CreateCAPA createCAPA)
    {
      return this.GetCAPAName(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetCAPAName(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.GetCAPAName(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).GetDataPoints(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetDataPoints(CreateCAPA createCAPA)
    {
      return this.GetDataPoints(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetDataPoints(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.GetDataPoints(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).GetWIPMsgs(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetWIPMsgs(CreateCAPA createCAPA)
    {
      return this.GetWIPMsgs(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.GetWIPMsgs(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).Load(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus Load(CreateCAPA createCAPA)
    {
      return this.Load(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus Load(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.Load(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).LoadESigDetails(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus LoadESigDetails(CreateCAPA createCAPA)
    {
      return this.LoadESigDetails(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus LoadESigDetails(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.LoadESigDetails(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).ProcessComputation(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ProcessComputation(CreateCAPA createCAPA)
    {
      return this.ProcessComputation(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ProcessComputation(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.ProcessComputation(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).ResolveParametricData(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ResolveParametricData(CreateCAPA createCAPA)
    {
      return this.ResolveParametricData(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.ResolveParametricData(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus SubmitCAPA(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (SubmitCAPA), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).SubmitCAPA(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.SubmitCAPA, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SubmitCAPA), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SubmitCAPA()
    {
      return this.SubmitCAPA((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus SubmitCAPA(CreateCAPA createCAPA)
    {
      return this.SubmitCAPA(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus SubmitCAPA(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.SubmitCAPA(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCAPACrossRefs(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (ValidateCAPACrossRefs), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).ValidateCAPACrossRefs(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.ValidateCAPACrossRefs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCAPACrossRefs), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCAPACrossRefs()
    {
      return this.ValidateCAPACrossRefs((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ValidateCAPACrossRefs(CreateCAPA createCAPA)
    {
      return this.ValidateCAPACrossRefs(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ValidateCAPACrossRefs(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.ValidateCAPACrossRefs(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ValidateQualityObject(
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (ValidateQualityObject), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).ValidateQualityObject(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.ValidateQualityObject, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateQualityObject), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateQualityObject()
    {
      return this.ValidateQualityObject((CreateCAPA) null, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ValidateQualityObject(CreateCAPA createCAPA)
    {
      return this.ValidateQualityObject(createCAPA, (CreateCAPA_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ValidateQualityObject(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.ValidateQualityObject(createCAPA, (CreateCAPA_Parameters) null, request, out result);
    }

    public ResultStatus ValidateServiceDetail(
      CreateCAPA createCAPA,
      CreateCAPA_ValidateServiceDetail_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (ValidateServiceDetail), (DCObject) createCAPA, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).ValidateServiceDetail(this._UserProfile, createCAPA, parameters, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(createCAPA, CreateCAPAMethods.ValidateServiceDetail, (CreateCAPA_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateServiceDetail), res, (DCObject) createCAPA, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateServiceDetail()
    {
      return this.ValidateServiceDetail((CreateCAPA) null, (CreateCAPA_ValidateServiceDetail_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ValidateServiceDetail(CreateCAPA createCAPA)
    {
      return this.ValidateServiceDetail(createCAPA, (CreateCAPA_ValidateServiceDetail_Parameters) null, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ValidateServiceDetail(
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.ValidateServiceDetail(createCAPA, (CreateCAPA_ValidateServiceDetail_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus actions = this.GetActions((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus resultStatus = this.Load((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject createCAPA,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateCAPA_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CreateCAPA) createCAPA, (CreateCAPA_Parameters) parameters, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      try
      {
        CreateCAPAMethod[] methods = new CreateCAPAMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICreateCAPAService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CreateCAPA_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateCAPA cdo,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      try
      {
        return ((ICreateCAPAService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CreateCAPA_Result result1;
        ResultStatus environment = this.GetEnvironment((CreateCAPA) cdo, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.GetEnvironment((CreateCAPA) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CreateCAPA cdo,
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      result = (CreateCAPA_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateCAPAService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CreateCAPAMethod(cdo, CreateCAPAMethods.ExecuteTransaction, (CreateCAPA_Parameters) null));
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
        CreateCAPA_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CreateCAPA) cdo, (CreateCAPA_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CreateCAPA cdo)
    {
      return this.ExecuteTransaction(cdo, (CreateCAPA_Request) null, out CreateCAPA_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CreateCAPA_Request request,
      out CreateCAPA_Result result)
    {
      return this.ExecuteTransaction((CreateCAPA) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CreateCAPA cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CreateCAPAMethod(cdo, CreateCAPAMethods.AddDataTransaction, (CreateCAPA_Parameters) null));
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
        return this.AddDataTransaction((CreateCAPA) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
