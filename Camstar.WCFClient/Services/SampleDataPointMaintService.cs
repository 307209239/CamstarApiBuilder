// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SampleDataPointMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SampleDataPointMaintService : RevisionedObjectMaintBase
  {
    public SampleDataPointMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISampleDataPointMaintService), userProfile);
    }

    public ResultStatus Delete(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).Delete(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus Delete(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.Delete(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus Delete(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.Delete(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.DeleteAllRevisions(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.DeleteAllRevisions(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).Freeze(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus Freeze(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.Freeze(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus Freeze(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.Freeze(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.GetWIPMsgs(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.GetWIPMsgs(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).Load(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus Load(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.Load(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus Load(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.Load(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_LoadESigDetails_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).LoadESigDetails(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.LoadESigDetails, (SampleDataPointMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SampleDataPointMaint) null, (SampleDataPointMaint_LoadESigDetails_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.LoadESigDetails(sampleDataPointMaint, (SampleDataPointMaint_LoadESigDetails_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.LoadESigDetails(sampleDataPointMaint, (SampleDataPointMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).New(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus New(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.New(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus New(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.New(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).NewCopy(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus NewCopy(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.NewCopy(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus NewCopy(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.NewCopy(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).NewRev(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus NewRev(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.NewRev(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus NewRev(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.NewRev(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).NewRevCopy(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus NewRevCopy(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.NewRevCopy(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.NewRevCopy(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).SaveAs(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus SaveAs(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.SaveAs(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus SaveAs(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.SaveAs(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).SaveAsRev(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus SaveAsRev(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.SaveAsRev(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.SaveAsRev(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).UnFreeze(this._UserProfile, sampleDataPointMaint, parameters, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(sampleDataPointMaint, SampleDataPointMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sampleDataPointMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SampleDataPointMaint) null, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus UnFreeze(SampleDataPointMaint sampleDataPointMaint)
    {
      return this.UnFreeze(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.UnFreeze(sampleDataPointMaint, (SampleDataPointMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_LoadESigDetails_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.New((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.Load((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sampleDataPointMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleDataPointMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SampleDataPointMaint) sampleDataPointMaint, (SampleDataPointMaint_Parameters) parameters, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      try
      {
        SampleDataPointMaintMethod[] methods = new SampleDataPointMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISampleDataPointMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SampleDataPointMaint cdo,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      try
      {
        return ((ISampleDataPointMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SampleDataPointMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SampleDataPointMaint) cdo, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.GetEnvironment((SampleDataPointMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SampleDataPointMaint cdo,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      result = (SampleDataPointMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleDataPointMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SampleDataPointMaintMethod(cdo, SampleDataPointMaintMethods.ExecuteTransaction, (SampleDataPointMaint_Parameters) null));
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
        SampleDataPointMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SampleDataPointMaint) cdo, (SampleDataPointMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SampleDataPointMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SampleDataPointMaint_Request) null, out SampleDataPointMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result)
    {
      return this.ExecuteTransaction((SampleDataPointMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SampleDataPointMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SampleDataPointMaintMethod(cdo, SampleDataPointMaintMethods.AddDataTransaction, (SampleDataPointMaint_Parameters) null));
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
        return this.AddDataTransaction((SampleDataPointMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
