// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SamplingPlanMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SamplingPlanMaintService : RevisionedObjectMaintBase
  {
    public SamplingPlanMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISamplingPlanMaintService), userProfile);
    }

    public ResultStatus Delete(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).Delete(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus Delete(SamplingPlanMaint samplingPlanMaint)
    {
      return this.Delete(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus Delete(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.Delete(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(SamplingPlanMaint samplingPlanMaint)
    {
      return this.DeleteAllRevisions(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.DeleteAllRevisions(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).Freeze(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus Freeze(SamplingPlanMaint samplingPlanMaint)
    {
      return this.Freeze(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus Freeze(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.Freeze(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).GetWIPMsgs(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SamplingPlanMaint samplingPlanMaint)
    {
      return this.GetWIPMsgs(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.GetWIPMsgs(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).Load(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus Load(SamplingPlanMaint samplingPlanMaint)
    {
      return this.Load(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus Load(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.Load(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_LoadESigDetails_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).LoadESigDetails(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.LoadESigDetails, (SamplingPlanMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SamplingPlanMaint) null, (SamplingPlanMaint_LoadESigDetails_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SamplingPlanMaint samplingPlanMaint)
    {
      return this.LoadESigDetails(samplingPlanMaint, (SamplingPlanMaint_LoadESigDetails_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.LoadESigDetails(samplingPlanMaint, (SamplingPlanMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).New(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus New(SamplingPlanMaint samplingPlanMaint)
    {
      return this.New(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus New(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.New(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).NewCopy(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus NewCopy(SamplingPlanMaint samplingPlanMaint)
    {
      return this.NewCopy(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus NewCopy(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.NewCopy(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).NewRev(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus NewRev(SamplingPlanMaint samplingPlanMaint)
    {
      return this.NewRev(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus NewRev(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.NewRev(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).NewRevCopy(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus NewRevCopy(SamplingPlanMaint samplingPlanMaint)
    {
      return this.NewRevCopy(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.NewRevCopy(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).SaveAs(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus SaveAs(SamplingPlanMaint samplingPlanMaint)
    {
      return this.SaveAs(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus SaveAs(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.SaveAs(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).SaveAsRev(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus SaveAsRev(SamplingPlanMaint samplingPlanMaint)
    {
      return this.SaveAsRev(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.SaveAsRev(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).UnFreeze(this._UserProfile, samplingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(samplingPlanMaint, SamplingPlanMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) samplingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SamplingPlanMaint) null, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus UnFreeze(SamplingPlanMaint samplingPlanMaint)
    {
      return this.UnFreeze(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.UnFreeze(samplingPlanMaint, (SamplingPlanMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_LoadESigDetails_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.New((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.Load((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject samplingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SamplingPlanMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SamplingPlanMaint) samplingPlanMaint, (SamplingPlanMaint_Parameters) parameters, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      try
      {
        SamplingPlanMaintMethod[] methods = new SamplingPlanMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISamplingPlanMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SamplingPlanMaint cdo,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      try
      {
        return ((ISamplingPlanMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SamplingPlanMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SamplingPlanMaint) cdo, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.GetEnvironment((SamplingPlanMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SamplingPlanMaint cdo,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      result = (SamplingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISamplingPlanMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SamplingPlanMaintMethod(cdo, SamplingPlanMaintMethods.ExecuteTransaction, (SamplingPlanMaint_Parameters) null));
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
        SamplingPlanMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SamplingPlanMaint) cdo, (SamplingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SamplingPlanMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SamplingPlanMaint_Request) null, out SamplingPlanMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result)
    {
      return this.ExecuteTransaction((SamplingPlanMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SamplingPlanMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SamplingPlanMaintMethod(cdo, SamplingPlanMaintMethods.AddDataTransaction, (SamplingPlanMaint_Parameters) null));
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
        return this.AddDataTransaction((SamplingPlanMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
