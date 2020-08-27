// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerDefectReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerDefectReasonMaintService : UserCodeMaintBase
  {
    public ContainerDefectReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerDefectReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).Delete(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.Delete(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.Delete(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).Freeze(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.Freeze(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.Freeze(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.GetWIPMsgs(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.GetWIPMsgs(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).Load(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus Load(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.Load(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus Load(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.Load(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_LoadESigDetails_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.LoadESigDetails, (ContainerDefectReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_LoadESigDetails_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.LoadESigDetails(containerDefectReasonMaint, (ContainerDefectReasonMaint_LoadESigDetails_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.LoadESigDetails(containerDefectReasonMaint, (ContainerDefectReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).New(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus New(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.New(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus New(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.New(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).NewCopy(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.NewCopy(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.NewCopy(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).SaveAs(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.SaveAs(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.SaveAs(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).UnFreeze(this._UserProfile, containerDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(containerDefectReasonMaint, ContainerDefectReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) containerDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ContainerDefectReasonMaint) null, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ContainerDefectReasonMaint containerDefectReasonMaint)
    {
      return this.UnFreeze(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.UnFreeze(containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_LoadESigDetails_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerDefectReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerDefectReasonMaint) containerDefectReasonMaint, (ContainerDefectReasonMaint_Parameters) parameters, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      try
      {
        ContainerDefectReasonMaintMethod[] methods = new ContainerDefectReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerDefectReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerDefectReasonMaint cdo,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      try
      {
        return ((IContainerDefectReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerDefectReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerDefectReasonMaint) cdo, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.GetEnvironment((ContainerDefectReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerDefectReasonMaint cdo,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      result = (ContainerDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerDefectReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(cdo, ContainerDefectReasonMaintMethods.ExecuteTransaction, (ContainerDefectReasonMaint_Parameters) null));
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
        ContainerDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerDefectReasonMaint) cdo, (ContainerDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerDefectReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerDefectReasonMaint_Request) null, out ContainerDefectReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ContainerDefectReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerDefectReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerDefectReasonMaintMethod(cdo, ContainerDefectReasonMaintMethods.AddDataTransaction, (ContainerDefectReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ContainerDefectReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
