// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ESigRequirementMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ESigRequirementMaintService : NamedDataObjectMaintBase
  {
    public ESigRequirementMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IESigRequirementMaintService), userProfile);
    }

    public ResultStatus Delete(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).Delete(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus Delete(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.Delete(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus Delete(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.Delete(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).Freeze(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus Freeze(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.Freeze(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus Freeze(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.Freeze(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.GetWIPMsgs(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.GetWIPMsgs(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).Load(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus Load(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.Load(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus Load(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.Load(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_LoadESigDetails_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).LoadESigDetails(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.LoadESigDetails, (ESigRequirementMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ESigRequirementMaint) null, (ESigRequirementMaint_LoadESigDetails_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.LoadESigDetails(eSigRequirementMaint, (ESigRequirementMaint_LoadESigDetails_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.LoadESigDetails(eSigRequirementMaint, (ESigRequirementMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).New(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus New(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.New(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus New(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.New(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).NewCopy(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus NewCopy(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.NewCopy(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus NewCopy(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.NewCopy(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).SaveAs(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus SaveAs(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.SaveAs(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus SaveAs(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.SaveAs(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Parameters parameters,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).UnFreeze(this._UserProfile, eSigRequirementMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(eSigRequirementMaint, ESigRequirementMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eSigRequirementMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ESigRequirementMaint) null, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus UnFreeze(ESigRequirementMaint eSigRequirementMaint)
    {
      return this.UnFreeze(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ESigRequirementMaint eSigRequirementMaint,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.UnFreeze(eSigRequirementMaint, (ESigRequirementMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_LoadESigDetails_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.New((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.Load((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eSigRequirementMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRequirementMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ESigRequirementMaint) eSigRequirementMaint, (ESigRequirementMaint_Parameters) parameters, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      try
      {
        ESigRequirementMaintMethod[] methods = new ESigRequirementMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IESigRequirementMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigRequirementMaint cdo,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      try
      {
        return ((IESigRequirementMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ESigRequirementMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ESigRequirementMaint) cdo, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.GetEnvironment((ESigRequirementMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ESigRequirementMaint cdo,
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      result = (ESigRequirementMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRequirementMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ESigRequirementMaintMethod(cdo, ESigRequirementMaintMethods.ExecuteTransaction, (ESigRequirementMaint_Parameters) null));
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
        ESigRequirementMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ESigRequirementMaint) cdo, (ESigRequirementMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ESigRequirementMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ESigRequirementMaint_Request) null, out ESigRequirementMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ESigRequirementMaint_Request request,
      out ESigRequirementMaint_Result result)
    {
      return this.ExecuteTransaction((ESigRequirementMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ESigRequirementMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ESigRequirementMaintMethod(cdo, ESigRequirementMaintMethods.AddDataTransaction, (ESigRequirementMaint_Parameters) null));
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
        return this.AddDataTransaction((ESigRequirementMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
