// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TriageQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TriageQualityObjectService : QualityTxnBase
  {
    public TriageQualityObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITriageQualityObjectService), userProfile);
    }

    public ResultStatus AssignChecklist(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (AssignChecklist), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).AssignChecklist(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.AssignChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignChecklist), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignChecklist()
    {
      return this.AssignChecklist((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus AssignChecklist(TriageQualityObject triageQualityObject)
    {
      return this.AssignChecklist(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus AssignChecklist(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.AssignChecklist(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus AssignProcessModel(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (AssignProcessModel), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).AssignProcessModel(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.AssignProcessModel, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignProcessModel), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignProcessModel()
    {
      return this.AssignProcessModel((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus AssignProcessModel(TriageQualityObject triageQualityObject)
    {
      return this.AssignProcessModel(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus AssignProcessModel(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.AssignProcessModel(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).CreateParametricData(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(TriageQualityObject triageQualityObject)
    {
      return this.CreateParametricData(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.CreateParametricData(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).GetActions(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetActions(TriageQualityObject triageQualityObject)
    {
      return this.GetActions(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetActions(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.GetActions(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).GetDataPoints(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(TriageQualityObject triageQualityObject)
    {
      return this.GetDataPoints(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.GetDataPoints(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetTriageSpecDetail(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetTriageSpecDetail), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).GetTriageSpecDetail(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.GetTriageSpecDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTriageSpecDetail), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTriageSpecDetail()
    {
      return this.GetTriageSpecDetail((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetTriageSpecDetail(TriageQualityObject triageQualityObject)
    {
      return this.GetTriageSpecDetail(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetTriageSpecDetail(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.GetTriageSpecDetail(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).GetWIPMsgs(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(TriageQualityObject triageQualityObject)
    {
      return this.GetWIPMsgs(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.GetWIPMsgs(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).Load(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus Load(TriageQualityObject triageQualityObject)
    {
      return this.Load(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus Load(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.Load(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).LoadESigDetails(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(TriageQualityObject triageQualityObject)
    {
      return this.LoadESigDetails(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.LoadESigDetails(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).ProcessComputation(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(TriageQualityObject triageQualityObject)
    {
      return this.ProcessComputation(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.ProcessComputation(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).ResolveParametricData(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(TriageQualityObject triageQualityObject)
    {
      return this.ResolveParametricData(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.ResolveParametricData(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus SetEscalationDate(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (SetEscalationDate), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).SetEscalationDate(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.SetEscalationDate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetEscalationDate), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetEscalationDate()
    {
      return this.SetEscalationDate((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus SetEscalationDate(TriageQualityObject triageQualityObject)
    {
      return this.SetEscalationDate(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus SetEscalationDate(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.SetEscalationDate(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus SetTriageComplete(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (SetTriageComplete), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).SetTriageComplete(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.SetTriageComplete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTriageComplete), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTriageComplete()
    {
      return this.SetTriageComplete((TriageQualityObject) null, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus SetTriageComplete(TriageQualityObject triageQualityObject)
    {
      return this.SetTriageComplete(triageQualityObject, (TriageQualityObject_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus SetTriageComplete(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.SetTriageComplete(triageQualityObject, (TriageQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCategoryTransition(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_ValidateCategoryTransition_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (ValidateCategoryTransition), (DCObject) triageQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).ValidateCategoryTransition(this._UserProfile, triageQualityObject, parameters, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(triageQualityObject, TriageQualityObjectMethods.ValidateCategoryTransition, (TriageQualityObject_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCategoryTransition), res, (DCObject) triageQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCategoryTransition()
    {
      return this.ValidateCategoryTransition((TriageQualityObject) null, (TriageQualityObject_ValidateCategoryTransition_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ValidateCategoryTransition(
      TriageQualityObject triageQualityObject)
    {
      return this.ValidateCategoryTransition(triageQualityObject, (TriageQualityObject_ValidateCategoryTransition_Parameters) null, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ValidateCategoryTransition(
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.ValidateCategoryTransition(triageQualityObject, (TriageQualityObject_ValidateCategoryTransition_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus actions = this.GetActions((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus resultStatus = this.Load((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject triageQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageQualityObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TriageQualityObject) triageQualityObject, (TriageQualityObject_Parameters) parameters, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      try
      {
        TriageQualityObjectMethod[] methods = new TriageQualityObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITriageQualityObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TriageQualityObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TriageQualityObject cdo,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      try
      {
        return ((ITriageQualityObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TriageQualityObject_Result result1;
        ResultStatus environment = this.GetEnvironment((TriageQualityObject) cdo, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.GetEnvironment((TriageQualityObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TriageQualityObject cdo,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      result = (TriageQualityObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageQualityObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TriageQualityObjectMethod(cdo, TriageQualityObjectMethods.ExecuteTransaction, (TriageQualityObject_Parameters) null));
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
        TriageQualityObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TriageQualityObject) cdo, (TriageQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TriageQualityObject cdo)
    {
      return this.ExecuteTransaction(cdo, (TriageQualityObject_Request) null, out TriageQualityObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result)
    {
      return this.ExecuteTransaction((TriageQualityObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TriageQualityObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TriageQualityObjectMethod(cdo, TriageQualityObjectMethods.AddDataTransaction, (TriageQualityObject_Parameters) null));
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
        return this.AddDataTransaction((TriageQualityObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
