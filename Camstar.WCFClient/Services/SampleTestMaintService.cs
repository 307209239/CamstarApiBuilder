// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SampleTestMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SampleTestMaintService : RevisionedObjectMaintBase
  {
    public SampleTestMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISampleTestMaintService), userProfile);
    }

    public ResultStatus Delete(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).Delete(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus Delete(SampleTestMaint sampleTestMaint)
    {
      return this.Delete(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus Delete(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.Delete(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(SampleTestMaint sampleTestMaint)
    {
      return this.DeleteAllRevisions(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.DeleteAllRevisions(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).Freeze(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus Freeze(SampleTestMaint sampleTestMaint)
    {
      return this.Freeze(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus Freeze(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.Freeze(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SampleTestMaint sampleTestMaint)
    {
      return this.GetWIPMsgs(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.GetWIPMsgs(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).Load(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus Load(SampleTestMaint sampleTestMaint)
    {
      return this.Load(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus Load(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.Load(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_LoadESigDetails_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).LoadESigDetails(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.LoadESigDetails, (SampleTestMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SampleTestMaint) null, (SampleTestMaint_LoadESigDetails_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SampleTestMaint sampleTestMaint)
    {
      return this.LoadESigDetails(sampleTestMaint, (SampleTestMaint_LoadESigDetails_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.LoadESigDetails(sampleTestMaint, (SampleTestMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).New(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus New(SampleTestMaint sampleTestMaint)
    {
      return this.New(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus New(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.New(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).NewCopy(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus NewCopy(SampleTestMaint sampleTestMaint)
    {
      return this.NewCopy(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus NewCopy(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.NewCopy(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).NewRev(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus NewRev(SampleTestMaint sampleTestMaint)
    {
      return this.NewRev(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus NewRev(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.NewRev(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).NewRevCopy(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus NewRevCopy(SampleTestMaint sampleTestMaint)
    {
      return this.NewRevCopy(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.NewRevCopy(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).SaveAs(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus SaveAs(SampleTestMaint sampleTestMaint)
    {
      return this.SaveAs(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus SaveAs(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.SaveAs(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).SaveAsRev(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus SaveAsRev(SampleTestMaint sampleTestMaint)
    {
      return this.SaveAsRev(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.SaveAsRev(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).UnFreeze(this._UserProfile, sampleTestMaint, parameters, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(sampleTestMaint, SampleTestMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sampleTestMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SampleTestMaint) null, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus UnFreeze(SampleTestMaint sampleTestMaint)
    {
      return this.UnFreeze(sampleTestMaint, (SampleTestMaint_Parameters) null, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.UnFreeze(sampleTestMaint, (SampleTestMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SampleTestMaint) sampleTestMaint, (SampleTestMaint_LoadESigDetails_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.New((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.Load((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sampleTestMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SampleTestMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SampleTestMaint) sampleTestMaint, (SampleTestMaint_Parameters) parameters, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      try
      {
        SampleTestMaintMethod[] methods = new SampleTestMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISampleTestMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SampleTestMaint cdo,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      try
      {
        return ((ISampleTestMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SampleTestMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SampleTestMaint) cdo, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.GetEnvironment((SampleTestMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SampleTestMaint cdo,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      result = (SampleTestMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISampleTestMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SampleTestMaintMethod(cdo, SampleTestMaintMethods.ExecuteTransaction, (SampleTestMaint_Parameters) null));
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
        SampleTestMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SampleTestMaint) cdo, (SampleTestMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SampleTestMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SampleTestMaint_Request) null, out SampleTestMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result)
    {
      return this.ExecuteTransaction((SampleTestMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SampleTestMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SampleTestMaintMethod(cdo, SampleTestMaintMethods.AddDataTransaction, (SampleTestMaint_Parameters) null));
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
        return this.AddDataTransaction((SampleTestMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
