// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ESigCosignReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ESigCosignReasonMaintService : UserCodeMaintBase
  {
    public ESigCosignReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IESigCosignReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).Delete(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus Delete(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.Delete(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.Delete(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).Freeze(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus Freeze(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.Freeze(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.Freeze(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.GetWIPMsgs(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.GetWIPMsgs(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).Load(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus Load(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.Load(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus Load(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.Load(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_LoadESigDetails_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.LoadESigDetails, (ESigCosignReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_LoadESigDetails_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.LoadESigDetails(eSigCosignReasonMaint, (ESigCosignReasonMaint_LoadESigDetails_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.LoadESigDetails(eSigCosignReasonMaint, (ESigCosignReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).New(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus New(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.New(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus New(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.New(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).NewCopy(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.NewCopy(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.NewCopy(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).SaveAs(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.SaveAs(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.SaveAs(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Parameters parameters,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).UnFreeze(this._UserProfile, eSigCosignReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(eSigCosignReasonMaint, ESigCosignReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eSigCosignReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ESigCosignReasonMaint) null, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ESigCosignReasonMaint eSigCosignReasonMaint)
    {
      return this.UnFreeze(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ESigCosignReasonMaint eSigCosignReasonMaint,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.UnFreeze(eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_LoadESigDetails_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eSigCosignReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigCosignReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ESigCosignReasonMaint) eSigCosignReasonMaint, (ESigCosignReasonMaint_Parameters) parameters, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      try
      {
        ESigCosignReasonMaintMethod[] methods = new ESigCosignReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IESigCosignReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigCosignReasonMaint cdo,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      try
      {
        return ((IESigCosignReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ESigCosignReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ESigCosignReasonMaint) cdo, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.GetEnvironment((ESigCosignReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ESigCosignReasonMaint cdo,
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      result = (ESigCosignReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigCosignReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ESigCosignReasonMaintMethod(cdo, ESigCosignReasonMaintMethods.ExecuteTransaction, (ESigCosignReasonMaint_Parameters) null));
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
        ESigCosignReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ESigCosignReasonMaint) cdo, (ESigCosignReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ESigCosignReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ESigCosignReasonMaint_Request) null, out ESigCosignReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ESigCosignReasonMaint_Request request,
      out ESigCosignReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ESigCosignReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ESigCosignReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ESigCosignReasonMaintMethod(cdo, ESigCosignReasonMaintMethods.AddDataTransaction, (ESigCosignReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ESigCosignReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
