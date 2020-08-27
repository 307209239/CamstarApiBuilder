// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.LocalReworkReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class LocalReworkReasonMaintService : UserCodeMaintBase
  {
    public LocalReworkReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ILocalReworkReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).Delete(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus Delete(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.Delete(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus Delete(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.Delete(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).Freeze(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus Freeze(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.Freeze(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.Freeze(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.GetWIPMsgs(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.GetWIPMsgs(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).Load(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus Load(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.Load(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus Load(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.Load(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_LoadESigDetails_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.LoadESigDetails, (LocalReworkReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_LoadESigDetails_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.LoadESigDetails(localReworkReasonMaint, (LocalReworkReasonMaint_LoadESigDetails_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.LoadESigDetails(localReworkReasonMaint, (LocalReworkReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).New(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus New(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.New(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus New(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.New(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).NewCopy(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus NewCopy(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.NewCopy(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.NewCopy(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).SaveAs(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus SaveAs(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.SaveAs(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.SaveAs(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).UnFreeze(this._UserProfile, localReworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(localReworkReasonMaint, LocalReworkReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) localReworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((LocalReworkReasonMaint) null, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(LocalReworkReasonMaint localReworkReasonMaint)
    {
      return this.UnFreeze(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.UnFreeze(localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_LoadESigDetails_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject localReworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LocalReworkReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((LocalReworkReasonMaint) localReworkReasonMaint, (LocalReworkReasonMaint_Parameters) parameters, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      try
      {
        LocalReworkReasonMaintMethod[] methods = new LocalReworkReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ILocalReworkReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LocalReworkReasonMaint cdo,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      try
      {
        return ((ILocalReworkReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        LocalReworkReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((LocalReworkReasonMaint) cdo, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.GetEnvironment((LocalReworkReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      LocalReworkReasonMaint cdo,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      result = (LocalReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILocalReworkReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new LocalReworkReasonMaintMethod(cdo, LocalReworkReasonMaintMethods.ExecuteTransaction, (LocalReworkReasonMaint_Parameters) null));
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
        LocalReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((LocalReworkReasonMaint) cdo, (LocalReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(LocalReworkReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (LocalReworkReasonMaint_Request) null, out LocalReworkReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result)
    {
      return this.ExecuteTransaction((LocalReworkReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(LocalReworkReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new LocalReworkReasonMaintMethod(cdo, LocalReworkReasonMaintMethods.AddDataTransaction, (LocalReworkReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((LocalReworkReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
