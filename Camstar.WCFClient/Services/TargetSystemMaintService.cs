// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TargetSystemMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TargetSystemMaintService : NamedDataObjectMaintBase
  {
    public TargetSystemMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITargetSystemMaintService), userProfile);
    }

    public ResultStatus Delete(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).Delete(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus Delete(TargetSystemMaint targetSystemMaint)
    {
      return this.Delete(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus Delete(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.Delete(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).Freeze(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus Freeze(TargetSystemMaint targetSystemMaint)
    {
      return this.Freeze(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus Freeze(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.Freeze(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).GetWIPMsgs(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TargetSystemMaint targetSystemMaint)
    {
      return this.GetWIPMsgs(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.GetWIPMsgs(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).Load(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus Load(TargetSystemMaint targetSystemMaint)
    {
      return this.Load(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus Load(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.Load(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_LoadESigDetails_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).LoadESigDetails(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.LoadESigDetails, (TargetSystemMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TargetSystemMaint) null, (TargetSystemMaint_LoadESigDetails_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TargetSystemMaint targetSystemMaint)
    {
      return this.LoadESigDetails(targetSystemMaint, (TargetSystemMaint_LoadESigDetails_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.LoadESigDetails(targetSystemMaint, (TargetSystemMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).New(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus New(TargetSystemMaint targetSystemMaint)
    {
      return this.New(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus New(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.New(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).NewCopy(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus NewCopy(TargetSystemMaint targetSystemMaint)
    {
      return this.NewCopy(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus NewCopy(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.NewCopy(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).SaveAs(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus SaveAs(TargetSystemMaint targetSystemMaint)
    {
      return this.SaveAs(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus SaveAs(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.SaveAs(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Parameters parameters,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).UnFreeze(this._UserProfile, targetSystemMaint, parameters, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(targetSystemMaint, TargetSystemMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) targetSystemMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TargetSystemMaint) null, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus UnFreeze(TargetSystemMaint targetSystemMaint)
    {
      return this.UnFreeze(targetSystemMaint, (TargetSystemMaint_Parameters) null, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TargetSystemMaint targetSystemMaint,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.UnFreeze(targetSystemMaint, (TargetSystemMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_LoadESigDetails_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.New((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.Load((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject targetSystemMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TargetSystemMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TargetSystemMaint) targetSystemMaint, (TargetSystemMaint_Parameters) parameters, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      try
      {
        TargetSystemMaintMethod[] methods = new TargetSystemMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITargetSystemMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TargetSystemMaint cdo,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      try
      {
        return ((ITargetSystemMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TargetSystemMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TargetSystemMaint) cdo, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.GetEnvironment((TargetSystemMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TargetSystemMaint cdo,
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      result = (TargetSystemMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITargetSystemMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TargetSystemMaintMethod(cdo, TargetSystemMaintMethods.ExecuteTransaction, (TargetSystemMaint_Parameters) null));
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
        TargetSystemMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TargetSystemMaint) cdo, (TargetSystemMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TargetSystemMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TargetSystemMaint_Request) null, out TargetSystemMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TargetSystemMaint_Request request,
      out TargetSystemMaint_Result result)
    {
      return this.ExecuteTransaction((TargetSystemMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TargetSystemMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TargetSystemMaintMethod(cdo, TargetSystemMaintMethods.AddDataTransaction, (TargetSystemMaint_Parameters) null));
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
        return this.AddDataTransaction((TargetSystemMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
