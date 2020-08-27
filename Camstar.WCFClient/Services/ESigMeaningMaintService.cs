// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ESigMeaningMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ESigMeaningMaintService : UserCodeMaintBase
  {
    public ESigMeaningMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IESigMeaningMaintService), userProfile);
    }

    public ResultStatus Delete(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).Delete(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus Delete(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.Delete(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus Delete(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.Delete(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).Freeze(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus Freeze(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.Freeze(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus Freeze(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.Freeze(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.GetWIPMsgs(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.GetWIPMsgs(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).Load(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus Load(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.Load(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus Load(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.Load(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_LoadESigDetails_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).LoadESigDetails(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.LoadESigDetails, (ESigMeaningMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ESigMeaningMaint) null, (ESigMeaningMaint_LoadESigDetails_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.LoadESigDetails(eSigMeaningMaint, (ESigMeaningMaint_LoadESigDetails_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.LoadESigDetails(eSigMeaningMaint, (ESigMeaningMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).New(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus New(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.New(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus New(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.New(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).NewCopy(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus NewCopy(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.NewCopy(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus NewCopy(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.NewCopy(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).SaveAs(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus SaveAs(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.SaveAs(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus SaveAs(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.SaveAs(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).UnFreeze(this._UserProfile, eSigMeaningMaint, parameters, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(eSigMeaningMaint, ESigMeaningMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eSigMeaningMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ESigMeaningMaint) null, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus UnFreeze(ESigMeaningMaint eSigMeaningMaint)
    {
      return this.UnFreeze(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.UnFreeze(eSigMeaningMaint, (ESigMeaningMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_LoadESigDetails_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.New((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.Load((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eSigMeaningMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigMeaningMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ESigMeaningMaint) eSigMeaningMaint, (ESigMeaningMaint_Parameters) parameters, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      try
      {
        ESigMeaningMaintMethod[] methods = new ESigMeaningMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IESigMeaningMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigMeaningMaint cdo,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      try
      {
        return ((IESigMeaningMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ESigMeaningMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ESigMeaningMaint) cdo, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.GetEnvironment((ESigMeaningMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ESigMeaningMaint cdo,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      result = (ESigMeaningMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigMeaningMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ESigMeaningMaintMethod(cdo, ESigMeaningMaintMethods.ExecuteTransaction, (ESigMeaningMaint_Parameters) null));
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
        ESigMeaningMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ESigMeaningMaint) cdo, (ESigMeaningMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ESigMeaningMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ESigMeaningMaint_Request) null, out ESigMeaningMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result)
    {
      return this.ExecuteTransaction((ESigMeaningMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ESigMeaningMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ESigMeaningMaintMethod(cdo, ESigMeaningMaintMethods.AddDataTransaction, (ESigMeaningMaint_Parameters) null));
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
        return this.AddDataTransaction((ESigMeaningMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
