// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtApplicationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeMgtApplicationMaintService : ApplicationMaintBase
  {
    public ChangeMgtApplicationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeMgtApplicationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).Delete(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus Delete(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.Delete(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus Delete(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.Delete(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).Freeze(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.Freeze(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.Freeze(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.GetWIPMsgs(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.GetWIPMsgs(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).Load(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus Load(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.Load(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus Load(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.Load(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_LoadESigDetails_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).LoadESigDetails(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.LoadESigDetails, (ChangeMgtApplicationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_LoadESigDetails_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.LoadESigDetails(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_LoadESigDetails_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.LoadESigDetails(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).New(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus New(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.New(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus New(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.New(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).NewCopy(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.NewCopy(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.NewCopy(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).SaveAs(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.SaveAs(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.SaveAs(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Parameters parameters,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).UnFreeze(this._UserProfile, changeMgtApplicationMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(changeMgtApplicationMaint, ChangeMgtApplicationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) changeMgtApplicationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChangeMgtApplicationMaint) null, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangeMgtApplicationMaint changeMgtApplicationMaint)
    {
      return this.UnFreeze(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangeMgtApplicationMaint changeMgtApplicationMaint,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.UnFreeze(changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_LoadESigDetails_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.New((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeMgtApplicationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeMgtApplicationMaint) changeMgtApplicationMaint, (ChangeMgtApplicationMaint_Parameters) parameters, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      try
      {
        ChangeMgtApplicationMaintMethod[] methods = new ChangeMgtApplicationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeMgtApplicationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtApplicationMaint cdo,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      try
      {
        return ((IChangeMgtApplicationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeMgtApplicationMaint) cdo, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.GetEnvironment((ChangeMgtApplicationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtApplicationMaint cdo,
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      result = (ChangeMgtApplicationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtApplicationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(cdo, ChangeMgtApplicationMaintMethods.ExecuteTransaction, (ChangeMgtApplicationMaint_Parameters) null));
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
        ChangeMgtApplicationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeMgtApplicationMaint) cdo, (ChangeMgtApplicationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeMgtApplicationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeMgtApplicationMaint_Request) null, out ChangeMgtApplicationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtApplicationMaint_Request request,
      out ChangeMgtApplicationMaint_Result result)
    {
      return this.ExecuteTransaction((ChangeMgtApplicationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeMgtApplicationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeMgtApplicationMaintMethod(cdo, ChangeMgtApplicationMaintMethods.AddDataTransaction, (ChangeMgtApplicationMaint_Parameters) null));
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
        return this.AddDataTransaction((ChangeMgtApplicationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
