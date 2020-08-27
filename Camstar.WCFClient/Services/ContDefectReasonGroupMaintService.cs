// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContDefectReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContDefectReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public ContDefectReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContDefectReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).Delete(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.Delete(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.Delete(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.Freeze(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.Freeze(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.GetWIPMsgs(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).Load(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.Load(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.Load(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.LoadESigDetails, (ContDefectReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_LoadESigDetails_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.LoadESigDetails(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_LoadESigDetails_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).New(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.New(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.New(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.NewCopy(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.NewCopy(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.SaveAs(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.SaveAs(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, contDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(contDefectReasonGroupMaint, ContDefectReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) contDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ContDefectReasonGroupMaint) null, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint)
    {
      return this.UnFreeze(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.UnFreeze(contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_LoadESigDetails_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject contDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContDefectReasonGroupMaint) contDefectReasonGroupMaint, (ContDefectReasonGroupMaint_Parameters) parameters, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      try
      {
        ContDefectReasonGroupMaintMethod[] methods = new ContDefectReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContDefectReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContDefectReasonGroupMaint cdo,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      try
      {
        return ((IContDefectReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ContDefectReasonGroupMaint) cdo, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((ContDefectReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContDefectReasonGroupMaint cdo,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      result = (ContDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContDefectReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(cdo, ContDefectReasonGroupMaintMethods.ExecuteTransaction, (ContDefectReasonGroupMaint_Parameters) null));
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
        ContDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContDefectReasonGroupMaint) cdo, (ContDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContDefectReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ContDefectReasonGroupMaint_Request) null, out ContDefectReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ContDefectReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContDefectReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContDefectReasonGroupMaintMethod(cdo, ContDefectReasonGroupMaintMethods.AddDataTransaction, (ContDefectReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ContDefectReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
