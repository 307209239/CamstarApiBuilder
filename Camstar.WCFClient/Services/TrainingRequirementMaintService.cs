// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingRequirementMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TrainingRequirementMaintService : RevisionedObjectMaintBase
  {
    public TrainingRequirementMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITrainingRequirementMaintService), userProfile);
    }

    public ResultStatus Delete(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).Delete(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus Delete(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.Delete(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus Delete(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.Delete(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.DeleteAllRevisions(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.DeleteAllRevisions(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).Freeze(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus Freeze(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.Freeze(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus Freeze(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.Freeze(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).GetWIPMsgs(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.GetWIPMsgs(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.GetWIPMsgs(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).Load(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus Load(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.Load(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus Load(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.Load(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_LoadESigDetails_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).LoadESigDetails(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.LoadESigDetails, (TrainingRequirementMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TrainingRequirementMaint) null, (TrainingRequirementMaint_LoadESigDetails_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.LoadESigDetails(trainingRequirementMaint, (TrainingRequirementMaint_LoadESigDetails_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.LoadESigDetails(trainingRequirementMaint, (TrainingRequirementMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).New(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus New(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.New(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus New(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.New(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).NewCopy(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus NewCopy(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.NewCopy(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus NewCopy(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.NewCopy(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).NewRev(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus NewRev(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.NewRev(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus NewRev(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.NewRev(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).NewRevCopy(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus NewRevCopy(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.NewRevCopy(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.NewRevCopy(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).SaveAs(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus SaveAs(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.SaveAs(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus SaveAs(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.SaveAs(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).SaveAsRev(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus SaveAsRev(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.SaveAsRev(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.SaveAsRev(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).UnFreeze(this._UserProfile, trainingRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(trainingRequirementMaint, TrainingRequirementMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) trainingRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TrainingRequirementMaint) null, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus UnFreeze(TrainingRequirementMaint trainingRequirementMaint)
    {
      return this.UnFreeze(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.UnFreeze(trainingRequirementMaint, (TrainingRequirementMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_LoadESigDetails_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.New((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.Load((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject trainingRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRequirementMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TrainingRequirementMaint) trainingRequirementMaint, (TrainingRequirementMaint_Parameters) parameters, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      try
      {
        TrainingRequirementMaintMethod[] methods = new TrainingRequirementMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITrainingRequirementMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingRequirementMaint cdo,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      try
      {
        return ((ITrainingRequirementMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TrainingRequirementMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TrainingRequirementMaint) cdo, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.GetEnvironment((TrainingRequirementMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TrainingRequirementMaint cdo,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      result = (TrainingRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRequirementMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TrainingRequirementMaintMethod(cdo, TrainingRequirementMaintMethods.ExecuteTransaction, (TrainingRequirementMaint_Parameters) null));
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
        TrainingRequirementMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TrainingRequirementMaint) cdo, (TrainingRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TrainingRequirementMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TrainingRequirementMaint_Request) null, out TrainingRequirementMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result)
    {
      return this.ExecuteTransaction((TrainingRequirementMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TrainingRequirementMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TrainingRequirementMaintMethod(cdo, TrainingRequirementMaintMethods.AddDataTransaction, (TrainingRequirementMaint_Parameters) null));
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
        return this.AddDataTransaction((TrainingRequirementMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
