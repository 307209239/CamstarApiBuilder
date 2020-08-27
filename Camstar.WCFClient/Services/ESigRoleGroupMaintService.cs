// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ESigRoleGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ESigRoleGroupMaintService : NamedObjectGroupMaintBase
  {
    public ESigRoleGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IESigRoleGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).Delete(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus Delete(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.Delete(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.Delete(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).Freeze(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus Freeze(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.Freeze(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.Freeze(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.GetWIPMsgs(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.GetWIPMsgs(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).Load(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus Load(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.Load(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus Load(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.Load(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_LoadESigDetails_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.LoadESigDetails, (ESigRoleGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_LoadESigDetails_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.LoadESigDetails(eSigRoleGroupMaint, (ESigRoleGroupMaint_LoadESigDetails_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.LoadESigDetails(eSigRoleGroupMaint, (ESigRoleGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).New(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus New(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.New(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus New(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.New(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).NewCopy(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.NewCopy(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.NewCopy(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).SaveAs(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.SaveAs(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.SaveAs(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Parameters parameters,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).UnFreeze(this._UserProfile, eSigRoleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(eSigRoleGroupMaint, ESigRoleGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eSigRoleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ESigRoleGroupMaint) null, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ESigRoleGroupMaint eSigRoleGroupMaint)
    {
      return this.UnFreeze(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ESigRoleGroupMaint eSigRoleGroupMaint,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.UnFreeze(eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_LoadESigDetails_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eSigRoleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ESigRoleGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ESigRoleGroupMaint) eSigRoleGroupMaint, (ESigRoleGroupMaint_Parameters) parameters, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      try
      {
        ESigRoleGroupMaintMethod[] methods = new ESigRoleGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IESigRoleGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigRoleGroupMaint cdo,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      try
      {
        return ((IESigRoleGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ESigRoleGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ESigRoleGroupMaint) cdo, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.GetEnvironment((ESigRoleGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ESigRoleGroupMaint cdo,
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      result = (ESigRoleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IESigRoleGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ESigRoleGroupMaintMethod(cdo, ESigRoleGroupMaintMethods.ExecuteTransaction, (ESigRoleGroupMaint_Parameters) null));
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
        ESigRoleGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ESigRoleGroupMaint) cdo, (ESigRoleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ESigRoleGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ESigRoleGroupMaint_Request) null, out ESigRoleGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ESigRoleGroupMaint_Request request,
      out ESigRoleGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ESigRoleGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ESigRoleGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ESigRoleGroupMaintMethod(cdo, ESigRoleGroupMaintMethods.AddDataTransaction, (ESigRoleGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ESigRoleGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
