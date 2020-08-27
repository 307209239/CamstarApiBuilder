// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DispatchRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DispatchRuleMaintService : NamedDataObjectMaintBase
  {
    public DispatchRuleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDispatchRuleMaintService), userProfile);
    }

    public ResultStatus Delete(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).Delete(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus Delete(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.Delete(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus Delete(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.Delete(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).Freeze(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus Freeze(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.Freeze(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.Freeze(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.GetWIPMsgs(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.GetWIPMsgs(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).Load(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus Load(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.Load(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus Load(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.Load(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_LoadESigDetails_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).LoadESigDetails(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.LoadESigDetails, (DispatchRuleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DispatchRuleMaint) null, (DispatchRuleMaint_LoadESigDetails_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.LoadESigDetails(dispatchRuleMaint, (DispatchRuleMaint_LoadESigDetails_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.LoadESigDetails(dispatchRuleMaint, (DispatchRuleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).New(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus New(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.New(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus New(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.New(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).NewCopy(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus NewCopy(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.NewCopy(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.NewCopy(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).SaveAs(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus SaveAs(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.SaveAs(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.SaveAs(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).UnFreeze(this._UserProfile, dispatchRuleMaint, parameters, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(dispatchRuleMaint, DispatchRuleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dispatchRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DispatchRuleMaint) null, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(DispatchRuleMaint dispatchRuleMaint)
    {
      return this.UnFreeze(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.UnFreeze(dispatchRuleMaint, (DispatchRuleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_LoadESigDetails_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.New((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.Load((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dispatchRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispatchRuleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DispatchRuleMaint) dispatchRuleMaint, (DispatchRuleMaint_Parameters) parameters, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      try
      {
        DispatchRuleMaintMethod[] methods = new DispatchRuleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDispatchRuleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DispatchRuleMaint cdo,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      try
      {
        return ((IDispatchRuleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DispatchRuleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DispatchRuleMaint) cdo, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.GetEnvironment((DispatchRuleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DispatchRuleMaint cdo,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      result = (DispatchRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispatchRuleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DispatchRuleMaintMethod(cdo, DispatchRuleMaintMethods.ExecuteTransaction, (DispatchRuleMaint_Parameters) null));
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
        DispatchRuleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DispatchRuleMaint) cdo, (DispatchRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DispatchRuleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DispatchRuleMaint_Request) null, out DispatchRuleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result)
    {
      return this.ExecuteTransaction((DispatchRuleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DispatchRuleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DispatchRuleMaintMethod(cdo, DispatchRuleMaintMethods.AddDataTransaction, (DispatchRuleMaint_Parameters) null));
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
        return this.AddDataTransaction((DispatchRuleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
