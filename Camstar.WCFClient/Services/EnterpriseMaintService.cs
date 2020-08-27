// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EnterpriseMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EnterpriseMaintService : NamedDataObjectMaintBase
  {
    public EnterpriseMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEnterpriseMaintService), userProfile);
    }

    public ResultStatus Delete(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).Delete(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus Delete(EnterpriseMaint enterpriseMaint)
    {
      return this.Delete(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus Delete(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.Delete(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).Freeze(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus Freeze(EnterpriseMaint enterpriseMaint)
    {
      return this.Freeze(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus Freeze(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.Freeze(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).GetWIPMsgs(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EnterpriseMaint enterpriseMaint)
    {
      return this.GetWIPMsgs(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.GetWIPMsgs(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).Load(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus Load(EnterpriseMaint enterpriseMaint)
    {
      return this.Load(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus Load(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.Load(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_LoadESigDetails_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).LoadESigDetails(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.LoadESigDetails, (EnterpriseMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EnterpriseMaint) null, (EnterpriseMaint_LoadESigDetails_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EnterpriseMaint enterpriseMaint)
    {
      return this.LoadESigDetails(enterpriseMaint, (EnterpriseMaint_LoadESigDetails_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.LoadESigDetails(enterpriseMaint, (EnterpriseMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).New(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus New(EnterpriseMaint enterpriseMaint)
    {
      return this.New(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus New(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.New(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).NewCopy(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus NewCopy(EnterpriseMaint enterpriseMaint)
    {
      return this.NewCopy(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus NewCopy(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.NewCopy(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).SaveAs(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus SaveAs(EnterpriseMaint enterpriseMaint)
    {
      return this.SaveAs(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus SaveAs(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.SaveAs(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).UnFreeze(this._UserProfile, enterpriseMaint, parameters, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(enterpriseMaint, EnterpriseMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) enterpriseMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EnterpriseMaint) null, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus UnFreeze(EnterpriseMaint enterpriseMaint)
    {
      return this.UnFreeze(enterpriseMaint, (EnterpriseMaint_Parameters) null, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.UnFreeze(enterpriseMaint, (EnterpriseMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_LoadESigDetails_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.New((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.Load((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject enterpriseMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EnterpriseMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EnterpriseMaint) enterpriseMaint, (EnterpriseMaint_Parameters) parameters, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      try
      {
        EnterpriseMaintMethod[] methods = new EnterpriseMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEnterpriseMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EnterpriseMaint cdo,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      try
      {
        return ((IEnterpriseMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EnterpriseMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EnterpriseMaint) cdo, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.GetEnvironment((EnterpriseMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EnterpriseMaint cdo,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      result = (EnterpriseMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEnterpriseMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EnterpriseMaintMethod(cdo, EnterpriseMaintMethods.ExecuteTransaction, (EnterpriseMaint_Parameters) null));
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
        EnterpriseMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EnterpriseMaint) cdo, (EnterpriseMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EnterpriseMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EnterpriseMaint_Request) null, out EnterpriseMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result)
    {
      return this.ExecuteTransaction((EnterpriseMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EnterpriseMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EnterpriseMaintMethod(cdo, EnterpriseMaintMethods.AddDataTransaction, (EnterpriseMaint_Parameters) null));
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
        return this.AddDataTransaction((EnterpriseMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
