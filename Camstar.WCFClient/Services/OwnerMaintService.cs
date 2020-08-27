// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OwnerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OwnerMaintService : UserCodeWithWMMaintBase
  {
    public OwnerMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOwnerMaintService), userProfile);
    }

    public ResultStatus Delete(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).Delete(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus Delete(OwnerMaint ownerMaint)
    {
      return this.Delete(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus Delete(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.Delete(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).Freeze(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus Freeze(OwnerMaint ownerMaint)
    {
      return this.Freeze(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus Freeze(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.Freeze(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).GetWIPMsgs(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(OwnerMaint ownerMaint)
    {
      return this.GetWIPMsgs(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.GetWIPMsgs(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).Load(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus Load(OwnerMaint ownerMaint)
    {
      return this.Load(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus Load(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.Load(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OwnerMaint ownerMaint,
      OwnerMaint_LoadESigDetails_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).LoadESigDetails(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.LoadESigDetails, (OwnerMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OwnerMaint) null, (OwnerMaint_LoadESigDetails_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(OwnerMaint ownerMaint)
    {
      return this.LoadESigDetails(ownerMaint, (OwnerMaint_LoadESigDetails_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.LoadESigDetails(ownerMaint, (OwnerMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).New(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus New(OwnerMaint ownerMaint)
    {
      return this.New(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus New(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.New(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).NewCopy(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus NewCopy(OwnerMaint ownerMaint)
    {
      return this.NewCopy(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus NewCopy(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.NewCopy(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).SaveAs(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus SaveAs(OwnerMaint ownerMaint)
    {
      return this.SaveAs(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus SaveAs(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.SaveAs(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      OwnerMaint ownerMaint,
      OwnerMaint_Parameters parameters,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) ownerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).UnFreeze(this._UserProfile, ownerMaint, parameters, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(ownerMaint, OwnerMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) ownerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((OwnerMaint) null, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus UnFreeze(OwnerMaint ownerMaint)
    {
      return this.UnFreeze(ownerMaint, (OwnerMaint_Parameters) null, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus UnFreeze(
      OwnerMaint ownerMaint,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.UnFreeze(ownerMaint, (OwnerMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.Delete((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OwnerMaint) ownerMaint, (OwnerMaint_LoadESigDetails_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.New((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.Load((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject ownerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OwnerMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OwnerMaint) ownerMaint, (OwnerMaint_Parameters) parameters, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      try
      {
        OwnerMaintMethod[] methods = new OwnerMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOwnerMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OwnerMaint cdo,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      try
      {
        return ((IOwnerMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OwnerMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((OwnerMaint) cdo, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.GetEnvironment((OwnerMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OwnerMaint cdo,
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      result = (OwnerMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOwnerMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OwnerMaintMethod(cdo, OwnerMaintMethods.ExecuteTransaction, (OwnerMaint_Parameters) null));
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
        OwnerMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OwnerMaint) cdo, (OwnerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OwnerMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (OwnerMaint_Request) null, out OwnerMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OwnerMaint_Request request,
      out OwnerMaint_Result result)
    {
      return this.ExecuteTransaction((OwnerMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OwnerMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OwnerMaintMethod(cdo, OwnerMaintMethods.AddDataTransaction, (OwnerMaint_Parameters) null));
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
        return this.AddDataTransaction((OwnerMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
