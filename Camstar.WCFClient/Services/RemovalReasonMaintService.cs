// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RemovalReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RemovalReasonMaintService : UserCodeMaintBase
  {
    public RemovalReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRemovalReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).Delete(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus Delete(RemovalReasonMaint removalReasonMaint)
    {
      return this.Delete(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus Delete(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.Delete(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).Freeze(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus Freeze(RemovalReasonMaint removalReasonMaint)
    {
      return this.Freeze(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.Freeze(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RemovalReasonMaint removalReasonMaint)
    {
      return this.GetWIPMsgs(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.GetWIPMsgs(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).Load(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus Load(RemovalReasonMaint removalReasonMaint)
    {
      return this.Load(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus Load(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.Load(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_LoadESigDetails_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.LoadESigDetails, (RemovalReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RemovalReasonMaint) null, (RemovalReasonMaint_LoadESigDetails_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RemovalReasonMaint removalReasonMaint)
    {
      return this.LoadESigDetails(removalReasonMaint, (RemovalReasonMaint_LoadESigDetails_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.LoadESigDetails(removalReasonMaint, (RemovalReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).New(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus New(RemovalReasonMaint removalReasonMaint)
    {
      return this.New(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus New(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.New(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).NewCopy(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus NewCopy(RemovalReasonMaint removalReasonMaint)
    {
      return this.NewCopy(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.NewCopy(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).SaveAs(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus SaveAs(RemovalReasonMaint removalReasonMaint)
    {
      return this.SaveAs(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.SaveAs(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).UnFreeze(this._UserProfile, removalReasonMaint, parameters, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(removalReasonMaint, RemovalReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) removalReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RemovalReasonMaint) null, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(RemovalReasonMaint removalReasonMaint)
    {
      return this.UnFreeze(removalReasonMaint, (RemovalReasonMaint_Parameters) null, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.UnFreeze(removalReasonMaint, (RemovalReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_LoadESigDetails_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject removalReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RemovalReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RemovalReasonMaint) removalReasonMaint, (RemovalReasonMaint_Parameters) parameters, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      try
      {
        RemovalReasonMaintMethod[] methods = new RemovalReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRemovalReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemovalReasonMaint cdo,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      try
      {
        return ((IRemovalReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RemovalReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RemovalReasonMaint) cdo, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.GetEnvironment((RemovalReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RemovalReasonMaint cdo,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      result = (RemovalReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRemovalReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RemovalReasonMaintMethod(cdo, RemovalReasonMaintMethods.ExecuteTransaction, (RemovalReasonMaint_Parameters) null));
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
        RemovalReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RemovalReasonMaint) cdo, (RemovalReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RemovalReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RemovalReasonMaint_Request) null, out RemovalReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result)
    {
      return this.ExecuteTransaction((RemovalReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RemovalReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RemovalReasonMaintMethod(cdo, RemovalReasonMaintMethods.AddDataTransaction, (RemovalReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((RemovalReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
