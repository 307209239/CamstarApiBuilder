// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RemoveDifferenceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RemoveDifferenceReasonMaintService : UserCodeMaintBase
  {
    public RemoveDifferenceReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRemoveDifferenceReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).Delete(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus Delete(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.Delete(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus Delete(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.Delete(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).Freeze(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.Freeze(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.Freeze(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.GetWIPMsgs(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.GetWIPMsgs(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).Load(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus Load(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.Load(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus Load(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.Load(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_LoadESigDetails_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.LoadESigDetails, (RemoveDifferenceReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_LoadESigDetails_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.LoadESigDetails(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_LoadESigDetails_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.LoadESigDetails(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).New(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus New(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.New(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus New(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.New(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).NewCopy(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.NewCopy(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.NewCopy(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).SaveAs(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.SaveAs(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.SaveAs(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).UnFreeze(this._UserProfile, removeDifferenceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(removeDifferenceReasonMaint, RemoveDifferenceReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) removeDifferenceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RemoveDifferenceReasonMaint) null, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint)
    {
      return this.UnFreeze(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.UnFreeze(removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_LoadESigDetails_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject removeDifferenceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RemoveDifferenceReasonMaint) removeDifferenceReasonMaint, (RemoveDifferenceReasonMaint_Parameters) parameters, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      try
      {
        RemoveDifferenceReasonMaintMethod[] methods = new RemoveDifferenceReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRemoveDifferenceReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemoveDifferenceReasonMaint cdo,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      try
      {
        return ((IRemoveDifferenceReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RemoveDifferenceReasonMaint) cdo, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.GetEnvironment((RemoveDifferenceReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RemoveDifferenceReasonMaint cdo,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      result = (RemoveDifferenceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemoveDifferenceReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(cdo, RemoveDifferenceReasonMaintMethods.ExecuteTransaction, (RemoveDifferenceReasonMaint_Parameters) null));
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
        RemoveDifferenceReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RemoveDifferenceReasonMaint) cdo, (RemoveDifferenceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RemoveDifferenceReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RemoveDifferenceReasonMaint_Request) null, out RemoveDifferenceReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result)
    {
      return this.ExecuteTransaction((RemoveDifferenceReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RemoveDifferenceReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RemoveDifferenceReasonMaintMethod(cdo, RemoveDifferenceReasonMaintMethods.AddDataTransaction, (RemoveDifferenceReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((RemoveDifferenceReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
