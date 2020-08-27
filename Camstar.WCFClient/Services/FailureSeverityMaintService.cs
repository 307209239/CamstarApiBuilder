// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FailureSeverityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FailureSeverityMaintService : UserCodeMaintBase
  {
    public FailureSeverityMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFailureSeverityMaintService), userProfile);
    }

    public ResultStatus Delete(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).Delete(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus Delete(FailureSeverityMaint failureSeverityMaint)
    {
      return this.Delete(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus Delete(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.Delete(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).Freeze(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus Freeze(FailureSeverityMaint failureSeverityMaint)
    {
      return this.Freeze(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus Freeze(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.Freeze(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).GetWIPMsgs(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FailureSeverityMaint failureSeverityMaint)
    {
      return this.GetWIPMsgs(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.GetWIPMsgs(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).Load(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus Load(FailureSeverityMaint failureSeverityMaint)
    {
      return this.Load(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus Load(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.Load(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_LoadESigDetails_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).LoadESigDetails(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.LoadESigDetails, (FailureSeverityMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FailureSeverityMaint) null, (FailureSeverityMaint_LoadESigDetails_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FailureSeverityMaint failureSeverityMaint)
    {
      return this.LoadESigDetails(failureSeverityMaint, (FailureSeverityMaint_LoadESigDetails_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.LoadESigDetails(failureSeverityMaint, (FailureSeverityMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).New(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus New(FailureSeverityMaint failureSeverityMaint)
    {
      return this.New(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus New(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.New(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).NewCopy(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus NewCopy(FailureSeverityMaint failureSeverityMaint)
    {
      return this.NewCopy(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus NewCopy(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.NewCopy(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).SaveAs(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus SaveAs(FailureSeverityMaint failureSeverityMaint)
    {
      return this.SaveAs(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus SaveAs(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.SaveAs(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Parameters parameters,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).UnFreeze(this._UserProfile, failureSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(failureSeverityMaint, FailureSeverityMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) failureSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FailureSeverityMaint) null, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus UnFreeze(FailureSeverityMaint failureSeverityMaint)
    {
      return this.UnFreeze(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FailureSeverityMaint failureSeverityMaint,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.UnFreeze(failureSeverityMaint, (FailureSeverityMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_LoadESigDetails_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.New((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.Load((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject failureSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FailureSeverityMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FailureSeverityMaint) failureSeverityMaint, (FailureSeverityMaint_Parameters) parameters, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      try
      {
        FailureSeverityMaintMethod[] methods = new FailureSeverityMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFailureSeverityMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureSeverityMaint cdo,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      try
      {
        return ((IFailureSeverityMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FailureSeverityMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FailureSeverityMaint) cdo, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.GetEnvironment((FailureSeverityMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FailureSeverityMaint cdo,
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      result = (FailureSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFailureSeverityMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FailureSeverityMaintMethod(cdo, FailureSeverityMaintMethods.ExecuteTransaction, (FailureSeverityMaint_Parameters) null));
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
        FailureSeverityMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FailureSeverityMaint) cdo, (FailureSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FailureSeverityMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FailureSeverityMaint_Request) null, out FailureSeverityMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FailureSeverityMaint_Request request,
      out FailureSeverityMaint_Result result)
    {
      return this.ExecuteTransaction((FailureSeverityMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FailureSeverityMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FailureSeverityMaintMethod(cdo, FailureSeverityMaintMethods.AddDataTransaction, (FailureSeverityMaint_Parameters) null));
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
        return this.AddDataTransaction((FailureSeverityMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
